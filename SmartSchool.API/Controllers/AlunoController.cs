using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>() {
            new Aluno() {
                Id = 1,
                Nome = "João",
                Sobrenome = "Victor",
                Telefone = "1234-5678"
            },
            new Aluno() {
                Id = 2,
                Nome = "Lucas",
                Sobrenome = "Mateus",
                Telefone = "4567-9632"
            },
        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(Alunos);
        }
    }
}