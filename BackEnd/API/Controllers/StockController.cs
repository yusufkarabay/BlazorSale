using Business.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService=stockService;
        }
        [HttpGet("api/stock/paging/{skip}/{take}")]
        public IActionResult Paging(int skip, int take)
        {
            var result = _stockService.Paging(skip, take);
            return Ok(result);
        }
        [HttpGet("api/stock/getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _stockService.GetById(id);
            return Ok(result);
        }
        [HttpGet("api/stock/getall")]
        public IActionResult GetAll()
        {
            var result = _stockService.GetAll();
            return Ok(result);
        }
        [HttpPost("api/stock/add")]
        public IActionResult Add(Stock stock)
        {
            var result = _stockService.Add(stock);
            return Ok(result);
        }
        [HttpPost("api/stock/update")]
        public IActionResult Update(Stock stock)
        {
            var result = _stockService.Update(stock);
            return Ok(result);
        }
        [HttpPost("api/stock/delete")]
        public IActionResult Delete(Stock stock)
        {
            _stockService.Delete(stock);
            return Ok();
        }

    }
}
