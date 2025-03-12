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
    public class EfOrderProcessDal: EfEntityRepositoryBase<OrderProcess, WashingModuleContext>, IOrderProcessDal    
    {

        private WashingModuleContext _context;

        public EfOrderProcessDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }


    }
}
