using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WashController : Controller
    {
        private IWashService _washService;

        public WashController(IWashService washService)
        {
            _washService = washService;
        }

        [HttpGet("getallforwashing")]
        public IActionResult GetAll()
        {
            var result = _washService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public ActionResult Add(Wash wash)
        {
            var result = _washService.Add(wash);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
