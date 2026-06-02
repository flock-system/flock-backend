using Flock.Application.DTOs.Member;
using Flock.Application.Interfaces;
using Flock.Infrastructure.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Globalization;


namespace Flock.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class MemberController : ControllerBase
    {
        private readonly IMemberApplication _memberApplication;

        public MemberController(IMemberApplication memberApplication)
        {
            _memberApplication = memberApplication;
        }




        [HttpPost("create")]
        [Authorize]
        public IActionResult CreateMember([FromBody] CreateMemberRequest request)
        {
            try
            {
                var tenantId = Guid.Parse(
                    User.FindFirst("TenantId")!.Value);

                var member = _memberApplication.CreateMember(request, tenantId);
        

                return Ok(member);
            }
            catch (Exception e)
            {
                return BadRequest($"An error occurred while creating the member: {e.Message}");
            }
        }


        //[HttpGet("search")]
        //public IActionResult SearchMember(string query = "")
        //{

        //    //Verificando se a query digitada consta em algum dos campos de identificação do usuário
        //    var members = _context.Members.Where(q => q.firstName.Contains(query) || q.lastName.Contains(query) || q.id.ToString().Equals(query)).ToList();

        //    //Se o usuário não digitar nada no campo, retorna uma lista de todos os usuários
        //    if (query.Equals("")) members = _context.Members.ToList();

        //    return Ok(members);

        //}


        
        private static bool validateDateOfBirth(string input)
        {
            string[] formats = { "dd/MM/yyyy", "dd-MM-yyyy", "yyyy-MM-dd", "yyyy/MM/dd" };

            return DateTime.TryParseExact(input, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }
}
