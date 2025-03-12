using Core.DataAccess.EntityFramework;
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
    public class EfDefectDal: EfEntityRepositoryBase<Defect, WashingModuleContext>, IDefectDal    
    {

        private WashingModuleContext _context;
        public EfDefectDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }
    }

}
