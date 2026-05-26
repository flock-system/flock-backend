using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Flock.Domain.DTOs.Auth;

namespace Flock.Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public AuthController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        //usuario hardcoded
        if (request.username != "admin" || request.password != "123456")
        {
            return Unauthorized();
        }

        var Claims = new[]
        {
            new Claim(ClaimTypes.Name, request.username),
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256) ;

        var token = new JwtSecurityToken(
           issuer: _configuration["Jwt:Issuer"],
           audience: _configuration["Jwt:Audience"],
           claims: Claims,
           expires: DateTime.UtcNow.AddMinutes(2),
           signingCredentials: creds
           );

        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        return Ok(new
        {
            token = tokenString
        });
    }

}
