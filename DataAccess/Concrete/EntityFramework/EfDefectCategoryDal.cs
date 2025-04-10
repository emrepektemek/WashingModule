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
    public class EfDefectCategoryDal: EfEntityRepositoryBase<DefectCategory, WashingModuleContext>, IDefectCategoryDal
    {
        private WashingModuleContext _context;
        public EfDefectCategoryDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }
    }
    {
    }
}
