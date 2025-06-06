﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Castle.Core.Resource;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.UserContext;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        private IQualityControlService _qualityControlService;

        private IUserContextService _userContextService;


        public OrderManager(IOrderDal orderDal, IUserContextService userContextService, IQualityControlService qualityControlService)
        {
            _orderDal = orderDal;
            _userContextService = userContextService;
            _qualityControlService = qualityControlService;
        }

        [ValidationAspect(typeof(OrderValidator))]
        public IResult Add(Order order)
        {
            int userId = _userContextService.GetUserId();

            var newOrder = new Order
            {
                OrderNumber = OrderNumberGenerator.Generate(),
                PantId = order.PantId,          
                PantQuantity = order.PantQuantity,        
                CreatedUserId = userId,
                CreatedDate = DateTime.Now,
                LastUpdatedUserId = userId,
                LastUpdatedDate = DateTime.Now,
                Status = true,
                IsDeleted = false
            };

            _orderDal.Add(newOrder);

            int newOrderId = newOrder.Id;

            _qualityControlService.FirstCreate(newOrderId);

            return new SuccessResult(Messages.OrderCreated);
        }

        public IDataResult<List<OrderPantDto>> GetAllWithPant()
        {
            return new SuccessDataResult<List<OrderPantDto>>(_orderDal.GetAllWithPant());
        }
    }

}
