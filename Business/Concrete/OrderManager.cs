using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Castle.Core.Resource;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.UserContext;
using Core.Entities.Concrete;
using Core.Utilities.Business;
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

        private IUserContextService _userContextService;


        public OrderManager(IOrderDal orderDal, IUserContextService userContextService)
        {
            _orderDal = orderDal;
            _userContextService = userContextService;
        }

        [ValidationAspect(typeof(OrderValidator))]
        public IResult Add(Order order)
        {

            int userId = _userContextService.GetUserId();

            var newOrder = new Order
            {
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

            return new SuccessResult(Messages.OrderCreated);
        }
    }

}
