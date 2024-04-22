using Exchange.Service;
using Microsoft.AspNetCore.Mvc;
using RateApi.Contracts.ApiModel;
using RateApi.Contracts.IService;
using System;

namespace Exchange.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeController : ControllerBase
    {
        private readonly IExchangeProvaidorService _exchange;

        private readonly IRateService _rate;
        public ExchangeController(IExchangeProvaidorService exchange, IRateService rate)
        {
            _exchange = exchange;
            _rate = rate;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            var list = _exchange.GetAll();
            return Ok(list);
        }

        [HttpGet("index-rate")]
        public IActionResult IndexRate()
        {
            var list = _rate.GetAll();
            return Ok(list);
        }

        [HttpPost("add-exchange")]
        public IActionResult AddExchange([FromBody] ExchangeProvaidorApiModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _exchange.Add(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("add-rate")]
        public IActionResult AddRate([FromBody] RateApiModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _rate.Add(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("delete-exchange")]
        public IActionResult DeleteExchange([FromBody] ExchangeProvaidorApiModel model)
        {
            if (model == null)
            {
                return BadRequest("Model is null");
            }

            _exchange.Delete(model);
            return Ok();
        }

        [HttpDelete("delete-rate")]
        public IActionResult DeleteRate([FromBody] RateApiModel model)
        {
            if (model == null)
            {
                return BadRequest("Model is null");
            }
            _rate.Delete(model);
            return Ok();
        }

    }
}
