using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.UserContext;
using Core.Entities.Concrete;
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
    public class OrderDefectManager : IOrderDefectService
    {

        private IOrderDefectDal _orderDefectDal;

        private IUserContextService _userContextService;

        public OrderDefectManager(IOrderDefectDal orderDefectDal, IUserContextService userContextService)
        {
            _orderDefectDal = orderDefectDal;
            _userContextService = userContextService;
        }

        public IDataResult<List<OrderDefectWithDefectAndOrderDto>> GetAllWithDefectName()
        {
            return new SuccessDataResult<List<OrderDefectWithDefectAndOrderDto>>(_orderDefectDal.GetAllWithDefectName());
        }

        [ValidationAspect(typeof(OrderDefectValidator))]
        public IResult Add(OrderDefect orderDefect)
        {

            var orderDefectToCheck = GetCurrentOrderDefect(orderDefect);       

            if (orderDefectToCheck != null)
            {
                var update = Update(orderDefect);

                return update;
            }

            int userId = _userContextService.GetUserId();

            var newOrderDefect = new OrderDefect
            {
                DefectId = orderDefect.DefectId,
                OrderId = orderDefect.OrderId,
                RowNumber = orderDefect.RowNumber,
                Decision = orderDefect.Decision,
                CreatedUserId = userId,
                CreatedDate = DateTime.Now,
                LastUpdatedUserId = userId,
                LastUpdatedDate = DateTime.Now,
                Status = true,
                IsDeleted = false
            };

            _orderDefectDal.Add(newOrderDefect);

            return new SuccessResult(Messages.OrderDefectAdded);         
              
        }

        [ValidationAspect(typeof(OrderDefectValidator))]
        public IResult Update(OrderDefect orderDefect)
        {

            int userId = _userContextService.GetUserId();

            var currentOrderDefect = GetCurrentOrderDefect(orderDefect);

            var uptadeOrderDefect = new OrderDefect
            {
                Id = currentOrderDefect.Id,
                DefectId = orderDefect.DefectId,
                OrderId = orderDefect.OrderId,
                RowNumber = orderDefect.RowNumber,
                Decision = orderDefect.Decision,
                CreatedUserId = currentOrderDefect.CreatedUserId,
                CreatedDate = currentOrderDefect.CreatedDate,      
                LastUpdatedUserId = userId,
                LastUpdatedDate = DateTime.Now,
                Status = true,
                IsDeleted = false
            };

            _orderDefectDal.UpdateAsNoTracking(uptadeOrderDefect);

            return new SuccessResult(Messages.OrderDefectUpdated);
        }

        public OrderDefect GetCurrentOrderDefect(OrderDefect orderDefect)
        {
            return _orderDefectDal.GetNoTracking(od => od.OrderId == orderDefect.OrderId && od.RowNumber == orderDefect.RowNumber);
        }
    }
}
