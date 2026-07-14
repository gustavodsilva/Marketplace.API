using Marketplace.API.Services;
using Microsoft.AspNetCore.Mvc;
using Marketplace.API.Models;

namespace Marketplace.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;

    public AuthController(TokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost("login")]

    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (request.Usuario == "admin" && request.Senha == "admin")
        {
            var token = _tokenService.GerarToken(request.Usuario);
            return Ok(new { Token = token });
        }
        else
        {
            return Unauthorized();
        }
    }
}
