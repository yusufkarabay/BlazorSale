using Business.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService=employeeService;
        }

        [HttpGet("api/getall")]
        public IActionResult GetAll()
        {
            var result = _employeeService.GetAll();
            return Ok(result);
        }
        [HttpGet("api/employee/GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _employeeService.GetById(id);
            if (result==null)
            {
                return NoContent();
            }
            return Ok(result);
        }
        [HttpPost("api/employee/add")]
        public IActionResult Add(Employee employee)
        {
            var result = _employeeService.Add(employee);
            return Created("",result);
        }
        [HttpPost("api/employee/update")]
        public IActionResult Update(Employee employee)
        {
            var result = _employeeService.Update(employee);
            return Ok(result);
        }
        [HttpPost("api/employee/delete")]
        public IActionResult Delete(Employee employee)
        {
            _employeeService.Delete(employee);
            return Ok();
        }
    }
}
