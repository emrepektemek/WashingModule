using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderDefectManager : IOrderDefectService
    {

        IOrderDefectDal _orderDefectDal;

        public OrderDefectManager(IOrderDefectDal orderDefectDal)
        {
            _orderDefectDal = orderDefectDal;
        }

        public IDataResult<List<OrderDefectWithDefectAndOrderDto>> GetAllWithDefectName()
        {
            return new SuccessDataResult<List<OrderDefectWithDefectAndOrderDto>>(_orderDefectDal.GetAllWithDefectName());
        }
    }
}
