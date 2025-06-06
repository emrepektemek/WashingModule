﻿using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantsController : Controller
    {
       private IPantService _pantService;

        public PantsController(IPantService pantService)
        {
            _pantService = pantService;
        }

        [HttpGet("getallwhitfabric")]
        public IActionResult GetAllWithFabric()
        {
            var result = _pantService.GetAllWithFabric();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
    }
}
