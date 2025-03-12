﻿using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getapproves")]
        public IActionResult GetOrderApproves()
        {
            var result = _orderService.GetOrderApproves();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpGet("getreports")]
        public IActionResult GetInventoryReports()
        {
            var result = _orderService.GetOrderReports();   

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpGet("getuserreports")]
        public IActionResult GetUserOrderReports(int customerId)
        {
            var result = _orderService.GetByCustomerId(customerId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Order order)
        {
            var result = _orderService.Add(order);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpPost("reject")]
        public ActionResult ApproveReject(OrderUpdateApproveRejectDto orderUpdateApproveRejectDto)
        {

            var result = _orderService.UpdateIsApprovedFalse(orderUpdateApproveRejectDto);    

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }



        [HttpPost("accept")]
        public ActionResult ApproveAccept(OrderUpdateApproveAcceptDto orderUpdateApproveAcceptDto)
        {

            var result = _orderService.UpdateIsApprovedTrue(orderUpdateApproveAcceptDto);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
    }
}
