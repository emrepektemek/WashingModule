using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDefectsController : Controller
    {
        IOrderDefectService _orderDefectService;

        public OrderDefectsController(IOrderDefectService orderDefectService)
        {
            _orderDefectService = orderDefectService;
        }

        [HttpGet("getallwithdefectname")]
        public IActionResult GetAllWithDefectName()
        {
            var result = _orderDefectService.GetAllWithDefectName();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public ActionResult Add(OrderDefect orderDefect)
        {
            var result = _orderDefectService.Add(orderDefect);

            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);

        }
    }
}
