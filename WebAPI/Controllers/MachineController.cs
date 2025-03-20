﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : Controller
    {

        private IMachineService _machineService;
        public MachineController(IMachineService machineService)
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
