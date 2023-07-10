using Business.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
 
    [ApiController]
    public class UserAuthortyController : ControllerBase
    {
        private readonly IUserAuthorityService _userAuthortyService;

        public UserAuthortyController(IUserAuthorityService userAuthortyService)
        {
            _userAuthortyService=userAuthortyService;
        }
      
        [HttpGet("api/userauthority/GetByAuthorityId/{authorityId}/{skip}/{take}")]
        public IActionResult GetByAuthorityId(int authorityId,int skip, int take)
        {
            var result = _userAuthortyService.GetByAuthorityId(authorityId,skip,take);
            return Ok(result);
        }
        [HttpGet("api/userauthority/GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _userAuthortyService.GetById(id);
            if (result==null)
            {
                return NoContent();
            }
            return Ok(result);
        }
        [HttpPost("api/userauthority/add")]
        public IActionResult Add(UserAuthority userAuthority)
        {
            var result = _userAuthortyService.Add(userAuthority);
            return Created("",result);
        }
        [HttpPost("api/userauthority/update")]
        public IActionResult Update(UserAuthority userAuthority)
        {
            var result = _userAuthortyService.Update(userAuthority);
            return Ok(result);
        }
        [HttpPost("api/userauthority/delete")]
        public IActionResult Delete(UserAuthority userAuthority)
        {
            _userAuthortyService.Delete(userAuthority);
            return Ok();
        }
    }
}
