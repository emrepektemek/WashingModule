using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
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
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, WashingModuleContext>, IUserOperationClaimDal
    {

        private WashingModuleContext _context;
        public EfUserOperationClaimDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }

    }
}
