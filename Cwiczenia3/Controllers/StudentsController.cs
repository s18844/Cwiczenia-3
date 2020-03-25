using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia3.DAL;
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
        {
            _dbService = dbService;
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            return Ok(_dbService.GetStudents());
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