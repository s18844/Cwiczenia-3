using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1) return Ok("Kowalski");
            else if (id == 2) return Ok("Malewski");
            return NotFound("Nie znaleziono studenta");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 2000)}";
            return Ok(student);
        }

        [HttpPut]
        public IActionResult PutCos(int id)
        {
            String message = "Aktualizacja dokonczona " + id;
            return Ok(message);
        }

        [HttpDelete]
        public IActionResult DeleteCos(int id)
        {
            String message = "Usunie zakonczone " + id;
            return Ok(message);
        }

        [HttpGet]
        public string GetStudent(string orderBy)
        {
            return $"Kowalski,Malewski,Adrzejewski sortowanie={orderBy}";
        }
    }
}