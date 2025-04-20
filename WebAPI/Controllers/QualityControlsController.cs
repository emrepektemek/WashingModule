using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualityControlsController : Controller
    {
        private IQualityControlService _qualityControlService;

        public QualityControlsController(IQualityControlService qualityControlService)
        {
            _qualityControlService = qualityControlService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _qualityControlService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
