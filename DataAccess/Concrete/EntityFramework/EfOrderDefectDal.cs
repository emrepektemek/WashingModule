using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
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
    }
    
  
}
