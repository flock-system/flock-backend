using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;
using Flock.Domain.Entities;
using System.Globalization;
using Flock.Application.DTOs.Member;
using Flock.Infrastructure.Persistance;


namespace Flock.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MemberController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("create")]
        public IActionResult CreateMember([FromBody] CreateMemberRequest request)
        {
            //Instanciando o membro a ser criado
            var member = new Member
            {
                firstName = request.firstName,
                lastName = request.lastName,
                phoneNumber = request.phoneNumber,
                email = request.email,
                dateOfBirth = request.dateOfBirth,
                createdAt = DateOnly.FromDateTime(DateTime.Today),
                isActive = true,

            };
            
            //Fazendo as validações
            bool isValidName = Regex.IsMatch(member.firstName, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s\-]+$") && Regex.IsMatch(member.lastName, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s\-]+$");
            bool isValidPhoneNumber = Regex.IsMatch(member.phoneNumber, @"^[0-9()+\s-]+$");

            if (!isValidPhoneNumber) return BadRequest(new { message = "insira um número de telefone válido" });
            if (!isValidName) return BadRequest(new { message = "insira um nome válido" });
            if (!validateDateOfBirth(member.dateOfBirth.ToString())) return BadRequest(new { message = "insira uma data válida" });

            //Adicionando no banco e salvando alterações
            _context.Members.Add(member);
            _context.SaveChanges();


            return Ok(member);
        }


        private static bool validateDateOfBirth(string input)
        {
            string[] formats = { "dd/MM/yyyy", "dd-MM-yyyy", "yyyy-MM-dd", "yyyy/MM/dd" };

            return DateTime.TryParseExact(input, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }
}
