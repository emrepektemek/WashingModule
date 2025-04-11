using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefectsController : Controller
    {
        IDefectService _defectService;

        public DefectsController(IDefectService defectService)
        {
            _defectService = defectService;
        }

        [HttpGet("getallwhitcategory")]
        public IActionResult GetAllWitCategory()
        {
            var result = _defectService.GetAllWitCategory();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


    }
}
