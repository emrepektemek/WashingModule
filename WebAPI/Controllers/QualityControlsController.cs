using Business.Abstract;
using Entities.Concrete;
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

        [HttpPost("update")]
        public ActionResult Update(QualityControl qualityControl)
        {
            var result = _qualityControlService.Update(qualityControl);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
