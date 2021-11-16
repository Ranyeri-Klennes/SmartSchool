using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [ApiController]//> Evita fazer algumas validações em cada action da Controller
    [Route("api/[controller]")] //> Informando a rota Http
    public class AlunoController : ControllerBase //> Class herda de ControllerBase
    {//> Abaixo crio objetos e suas caracteristicas
        public List<Aluno> Alunos = new List<Aluno>() {//> Objetos
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
        //> Aqui eu puxo um Get do HTTP
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
        
        [HttpGet("byId/{id}")] //> Utilizando o QueryString
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O aluno não foi encontrado");

            return Ok(aluno);
        }

        [HttpGet("{ByName}")]
        public IActionResult GetByName(string nome, string Sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => 
                a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome));
            
            if (aluno == null) return BadRequest("Aluno não encontrado");
            
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }
        
        [HttpPatch]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}