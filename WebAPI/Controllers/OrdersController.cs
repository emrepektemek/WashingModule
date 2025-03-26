using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }


        [HttpPost("add")]
        public ActionResult Add(Order order)
        {
            var result = _orderService.Add(order);

            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);

        }

        [HttpGet("getallwhitpant")]
        public IActionResult GetAllWithPant()
        {
            var result = _orderService.GetAllWithPant();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


    }
}
