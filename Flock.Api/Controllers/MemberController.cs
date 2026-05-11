using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;
using Flock.Domain.Entities;
using System.Globalization;

namespace Flock.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {

        [HttpPost("create")]
        public IActionResult CreateMember([FromBody] Member member)
        {
            bool isValidName = Regex.IsMatch(member.firstName, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s\-]+$") && Regex.IsMatch(member.lastName, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s\-]+$");

            if (!isValidName) return BadRequest(new { message = "o nome deve conter apenas letras" });
            if (!validateDateOfBirth(member.dateOfBirth.ToString())) return BadRequest(new { message = "insira uma data válida" });


            return Ok(member);
        }


        private static bool validateDateOfBirth(string input)
        {
            string[] formats = { "dd/MM/yyyy", "dd-MM-yyyy", "yyyy-MM-dd", "yyyy/MM/dd" };

            return DateTime.TryParseExact(input, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }
}
