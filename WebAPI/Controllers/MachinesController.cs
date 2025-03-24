using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : Controller
    {

        private IMachineService _machineService;
        public MachinesController(IMachineService machineService)
        {
            _machineService = machineService;
        }

        [HttpPost("add")]
        public ActionResult Add(Machine machine)
        {
            var result = _machineService.Add(machine);

            if (result.Success)
            {
                return Ok(result);
        
            }

            return BadRequest(result);


        }

    }
}
