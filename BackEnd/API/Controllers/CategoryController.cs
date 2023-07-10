using Business.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService=categoryService;
        }

        [HttpGet("api/category/paging/{skip},{take}")]
        public IActionResult Paging(int skip, int take)
        {
            var categories = _categoryService.Paging(skip, take);
            return Ok(categories);
        }
        [HttpGet("api/category/getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var category = _categoryService.GetById(id);
            if (category!=null)
            {
                return Ok(category);
            }
            return NotFound();
        }
        [HttpPost("api/category/add")]
        public IActionResult Add([FromBody] Category category)
        {
            var result = _categoryService.Add(category);
            if (result!=null)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("api/category/update")]
        public IActionResult Update([FromBody] Category category)
        {
            var result = _categoryService.Update(category);
            if (result!=null)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("api/category/delete")]
        public IActionResult Delete([FromBody] Category category)
        {
            _categoryService.Delete(category);
            return Ok(category);
        }
        [HttpGet("api/category/getall")]
        public IActionResult GetAll()
        {
            var categories = _categoryService.GetAll();
            return Ok(categories);
        }

    }
}
