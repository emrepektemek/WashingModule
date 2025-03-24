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
    public class EfWashDal : EfEntityRepositoryBase<Wash, WashingModuleContext>, IWashDal
    {
        private WashingModuleContext _context;
        public EfWashDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }
    }
}
