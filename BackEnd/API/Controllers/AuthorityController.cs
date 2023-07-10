using Business.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class AuthorityController : ControllerBase
    {
        private readonly IAuhorityService _authorityService;

        public AuthorityController(IAuhorityService authorityService)
        {
            _authorityService=authorityService;
        }
        [HttpGet("api/authority/getall")]
        public IActionResult GetAll()
        {
            var result = _authorityService.GetAll();
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("api/authority/getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _authorityService.GetById(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("api/authority/add")]
        public IActionResult Add(Authority authority)
        {
            var result = _authorityService.Add(authority);
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("api/authority/update")]
        public IActionResult Update(Authority authority)
        {
            var result = _authorityService.Update(authority);
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("api/authority/delete")]
        public IActionResult Delete(Authority authority)
        {
            _authorityService.Delete(authority);
            return Ok();
        }
    }
}
