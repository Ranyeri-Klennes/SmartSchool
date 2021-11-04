using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public List<Professor> Professores = new List<Professor>() {
            new Professor() {
                Id = 1,
                Nome = "Prof.João"
            },
            new Professor() {
                Id = 2,
                Nome = "Prof.Lucas"
            }
        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Professores);
        }
    }
}