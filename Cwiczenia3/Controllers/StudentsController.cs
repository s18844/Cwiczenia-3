﻿using System;
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

        [HttpGet]
        public string GetStudent(string orderBy)
        {
            return $"Kowalski,Malewski,Adrzejewski sortowanie={orderBy}";
        }
    }
}