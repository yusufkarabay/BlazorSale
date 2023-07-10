using Business.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService=saleService;
        }
        [HttpGet("api/sale/paging/{skip}/{take}")]
        public IActionResult Paging(int skip, int take)
        {
            var result = _saleService.Paging(skip, take);
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("api/sale/getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _saleService.GetById(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("api/sale/add")]
        public IActionResult Add(Sale sale)
        {
            var result = _saleService.Add(sale);
            if (result!=null)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost("api/sale/update")]
        public IActionResult Update(Sale sale)
        {
            var result = _saleService.Update(sale);
            if (result!=null)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost("api/sale/delete")]
        public IActionResult Delete(Sale sale)
        {
            _saleService.Delete(sale);

            return Ok(sale);
        }
    }
}
