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
        var tenantId = Guid.Parse("11111111-1111-1111-1111-111111111111");
        //usuario e tenantid hardcoded 
        if (( request.username != "admin2" && request.username != "admin") || request.password != "123456")
        {
            return Unauthorized();
        }

        if (request.username == "admin2") tenantId = Guid.Parse("22222222-2222-2222-2222-222222222222");

        var Claims = new[]
        {
            new Claim(ClaimTypes.Name, request.username),

             new Claim("TenantId", tenantId.ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

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

    [HttpPost("register")]
    public IActionResult RegisterChurch()
    {
        return Ok();
    }
    

}
