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
    public class EfWashDal : EfEntityRepositoryBase<Wash, WashingModuleContext>, IWashDal
    {
        private WashingModuleContext _context;
        public EfWashDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }

        public List<WashingDto> GetAllForWashing()
        {
            var result = from w in _context.Washes
                         join o in _context.Orders
                         on w.OrderId equals o.Id
                         join wt in _context.WashingTypes
                         on w.WashingTypeId equals wt.Id
                         join p in _context.Pants
                         on o.PantId equals p.Id
                         orderby w.CreatedDate descending
                         select new WashingDto
                         {
                             OrderNumber = o.OrderNumber,
                             PantId = o.PantId,
                             ModelName = p.ModelName,
                             WashingTypeName = wt.WashingTypeName,
                             WashingTime = wt.WashingTime,
                             OrderId = w.OrderId,
                             WashingTypeId = w.WashingTypeId,
                             Shift = w.Shift,
                             Id = w.Id,
                             CreatedUserId = w.CreatedUserId,
                             CreatedDate = w.CreatedDate,
                             LastUpdatedUserId = w.LastUpdatedUserId,
                             LastUpdatedDate = w.LastUpdatedDate,
                             Status = w.Status,
                             IsDeleted = w.IsDeleted
                         };
                          

            return result.ToList();
        }
    }
}
