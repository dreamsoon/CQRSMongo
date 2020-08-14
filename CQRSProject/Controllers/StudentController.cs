using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using CQRS.Core.Models;
using CQRS.Service.Serviceses.Student.MongoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Fields
        private readonly IMongoStudentService _studentService = null;
        #endregion
        public StudentController(IMongoStudentService studentService)
        {
            this._studentService = studentService; 
        }
        [HttpGet("GetStudents")]
        public async Task<IActionResult> GetStudentsAsync()
        {
           return Ok (await _studentService.GetAllAsync());
        }
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromForm]StudentModel student)
        {
            await _studentService.RegisterAsync(student);
            return Ok("Student is Regsiter Successfully");
        }
        [HttpPut("Edit")]
        public async Task<IActionResult> Edit([FromForm]StudentModel student)
        {
            await _studentService.UpdateAsync(student);
            return Ok("Student is Modify Successfully");
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> delete(string id)
        {
            if (!await _studentService.IsExist(id))
                return NotFound("Student Is Not Found");
            await _studentService.RemoveAsync(id);
            return Ok("Student is removed Successfully");
        }
    }
}