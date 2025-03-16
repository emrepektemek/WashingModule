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
    public class EfWashingTypeDal: EfEntityRepositoryBase<WashingType, WashingModuleContext>, IWashingTypeDal   
    {
        private WashingModuleContext _context;
        public EfWashingTypeDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }
    }
}
