using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WashingTypesController : Controller
    {
        private IWashingTypeService _washingTypeService;

        public WashingTypesController(IWashingTypeService washingTypeService)
        {
            _washingTypeService = washingTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _washingTypeService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
