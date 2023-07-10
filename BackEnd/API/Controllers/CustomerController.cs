using Business.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
   
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService=customerService;
        }

        [HttpGet("api/customer/Paging/{skip}/{take}")]
        public IActionResult Paging(int skip, int take)
        {
            var result = _customerService.Paging(skip,take);
            return Ok(result);
        }
        [HttpGet("api/customer/GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetById(id);
            if (result==null)
            {
                return NoContent();
            }
            return Ok(result);
        }
        [HttpPost("api/customer/add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            return Created("",result);
        }
        [HttpPost("api/customer/update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            return Ok(result);
        }
        [HttpPost("api/customer/delete")]
        public IActionResult Delete(Customer customer)
        {
            _customerService.Delete(customer);
            return Ok();
        }
    }
}
