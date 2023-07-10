using Business.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;

        }
        [HttpGet("api/city/parentbyid/{parentid}/{skip}/{take}")]
        public IActionResult GetCityByParentId(int parentId, int skip, int take)
        {
            var result = _cityService.GetCityByParentId(parentId, skip, take);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("api/city/paging/{skip}/{take}")]
        public IActionResult Paging(int skip, int take)
        {
            var result = _cityService.Paging(skip, take);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("api/city/getall")]
        public IActionResult GetAll()
        {
            var result = _cityService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("api/city/getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _cityService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("api/city/add")]
        public IActionResult Add(City city)
        {
            var result = _cityService.Add(city);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPut("api/city/update")]
        public IActionResult Update(City city)
        {
            var result = _cityService.Update(city);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("api/city/delete")]
        public IActionResult Delete(City city)
        {
            _cityService.Delete(city);
            return Ok();
        }
        [HttpPost("api/city/deleterange")]
        public IActionResult DeleteRange(List<City> cities)
        {
            _cityService.DeleteRange(cities);
            return Ok();
        }


    }
}
