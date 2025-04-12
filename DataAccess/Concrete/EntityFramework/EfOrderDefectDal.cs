using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDefectDal: EfEntityRepositoryBase<OrderDefect, WashingModuleContext>, IOrderDefectDal
    {
        private WashingModuleContext _context;
        public EfOrderDefectDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }

        public List<OrderDefectWithDefectAndOrderDto> GetAllWithDefectName()
        {
            var result = from od in _context.OrderDefects
                         join d in _context.Defects
                         on od.DefectId equals d.Id
                         join o in _context.Orders
                         on od.OrderId equals o.Id
                         orderby od.OrderId, od.RowNumber
                         select new OrderDefectWithDefectAndOrderDto
                         {
                             OrderId = od.OrderId,
                             DefectId = od.DefectId,
                             RowNumber = od.RowNumber,
                             Decision = od.Decision,
                             DefectName = d.DefectName,
                             OrderNumber = o.OrderNumber,
                             OrderCreatedDate = o.CreatedDate,
                             PantQuantity = o.PantQuantity,
                             Id = od.Id,
                             CreatedUserId = od.CreatedUserId,
                             CreatedDate = od.CreatedDate,
                             LastUpdatedUserId = od.LastUpdatedUserId,
                             LastUpdatedDate = od.LastUpdatedDate,
                             Status = od.Status,
                             IsDeleted = od.IsDeleted
                         };

            return result.ToList();
        }
    }
    
  
}
