﻿using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationClaimsController : Controller
    {
       private IUserOperationClaimService _userOperationClaimService;

        public UserOperationClaimsController(IUserOperationClaimService userOperationClaimService)
        {
                _userOperationClaimService = userOperationClaimService;
        }


        [HttpPost("add")]
        public ActionResult Add(UserOperationClaim userOperationClaim)
        {
            
            var result = _userOperationClaimService.Add(userOperationClaim);

            if (result.Success)
            {
                return Ok(result);  
            }

            return BadRequest(result);


        }


        [HttpPost("update")]
        public ActionResult Update(UserOperationClaim userOperationClaim)
        {

            var result = _userOperationClaimService.Update(userOperationClaim);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }



        [HttpPost("delete")]
        public ActionResult Delete(UserOperationClaim userOperationClaim)
        {

            var result = _userOperationClaimService.Delete(userOperationClaim);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


    }
}
