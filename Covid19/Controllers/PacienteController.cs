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
    public class PacienteController : ControllerBase
    {
    
        
            private readonly IPacienteService _services;

            public PacienteController(IPacienteService services)
            {
                _services = services;
            }    
                     
            [HttpGet]
            public async Task<IActionResult> Get()
            {
            var pacientes = _services.ListarTodosPacientes();
            return Ok(pacientes);
            
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> Get(int id)
            {
            var pacientes = _services.ListarTodosPacientes();
                return Ok(pacientes);
            }

            [HttpPost]
            public async Task<IActionResult> Post(Paciente paciente)
            {
                _services.IserirPaciente(paciente);
                return Ok("Paciente cadastrado com sucesso");
            }

            [HttpPut]
            public async Task<IActionResult> Put(Paciente paciente)
            {
                Paciente p = new Paciente();

                return Ok("Paciente atualizado com sucesso");
            }

            [HttpDelete]
            public async Task<IActionResult> Delete(int id)
            {

                return Ok("Paciente deleteado com sucesso");
            }

        
    }
}