using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19.Models;
using Covid19.Repositories;
using Covid19.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid19.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _services;


        public LoginController(ILoginService services)
        {
            _services = services;
        }



        [AllowAnonymous]
        [HttpPost]
        [Route("autenticacao")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Login model)
        {
            var user = _services.GetLogin(model);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            user.senha = "";
            return new
            {
                user = user,
                token = token
            };
        }
    }
}