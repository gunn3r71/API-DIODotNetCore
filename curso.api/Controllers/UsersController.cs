using curso.api.Filters;
using curso.api.Models.Comum;
using curso.api.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Autenticação de usuário
        /// </summary>
        /// <param name="login">Recebe os dados de login</param>
        /// <returns>Usuário autenticado</returns>
        [SwaggerResponse(200, Description ="Usuário autenticado", Type =typeof(LoginViewModelInput))]
        [SwaggerResponse(400, Description ="Usuário inválido", Type =typeof(FieldsValidationViewModel))]
        [SwaggerResponse(500, Description ="Erro interno", Type =typeof(ErrorViewModel))]
        [ModelStateValidation]
        [HttpPost]
        [Route("Auth")]
        public IActionResult Login(LoginViewModelInput login)
        {
            return Ok(login);
        }

        /// <summary>
        /// Registro de novo usuário
        /// </summary>
        /// <param name="user">Usuário a ser cadastrado</param>
        /// <returns>Usuário</returns>
        [SwaggerResponse(200, Description ="Usuário Registrado", Type =typeof(AddViewModelInput))]
        [SwaggerResponse(400, Description = "Usuário inválido", Type = typeof(FieldsValidationViewModel))]
        [SwaggerResponse(500, Description = "Erro interno", Type = typeof(ErrorViewModel))]
        [ModelStateValidation]
        [HttpPost]
        public IActionResult Add(AddViewModelInput user)
        {
            return Created("",user);
        }
    }
}
