using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, WashingModuleContext>, IOrderDal
    {

        private WashingModuleContext _context;
        public EfOrderDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }

        public List<OrderPantDto> GetAllWithPant()
        {
            var result = from o in _context.Orders
                         join p in _context.Pants
                         on o.PantId equals p.Id
                         orderby o.CreatedDate descending
                         select new OrderPantDto
                         {                                      
                             ModelName = p.ModelName,
                             OrderNumber = o.OrderNumber,
                             PantId = o.PantId,
                             PantQuantity = o.PantQuantity,
                             Id = o.Id,
                             CreatedUserId = o.CreatedUserId,
                             CreatedDate = o.CreatedDate,
                             LastUpdatedUserId = o.LastUpdatedUserId,
                             LastUpdatedDate = o.LastUpdatedDate,
                             Status = o.Status,
                             IsDeleted = o.IsDeleted
                         };

            return result.ToList();
        }
    }
}


