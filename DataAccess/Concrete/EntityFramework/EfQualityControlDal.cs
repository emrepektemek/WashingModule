using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQualityControlDal : EfEntityRepositoryBase<QualityControl, WashingModuleContext>, IQualityControlDal
    {
        private WashingModuleContext _context;
        public EfQualityControlDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }

        public void UpdateAsNoTracking(QualityControl entity)
        {
            var local = _context.Set<QualityControl>()
            .Local
            .FirstOrDefault(entry => entry.Id == entity.Id);

            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }

            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        } 
    }
}
