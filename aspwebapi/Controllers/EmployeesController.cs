using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using aspwebapi.EmployeeData;

namespace aspwebapi.Controllers
{
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employeeData;

        public EmployeesController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeData.GetEmployees());
        }
    }
}
