using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using aspwebapi.EmployeeData;
using aspwebapi.Data;

namespace aspwebapi.Controllers
{
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private Students _studentsData;

        public StudentsController(Students studentsData)
        {
            _studentsData = studentsData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStudents()
        {
            return Ok("200");
            //return Ok(_studentsData.GetStudents());
        }
    }
}
