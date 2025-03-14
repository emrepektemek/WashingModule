﻿using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
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
    public class EfOrderDal : EfEntityRepositoryBase<Order, WashingModuleContext>, IOrderDal
    {

        private WashingModuleContext _context;

        public EfOrderDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }   


    }
}


