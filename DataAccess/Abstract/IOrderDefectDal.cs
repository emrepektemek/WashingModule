﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IOrderDefectDal: IEntityRepository<OrderDefect>
    {
        List<OrderDefectWithDefectAndOrderDto> GetAllWithDefectName();
        OrderDefect GetNoTracking(Expression<Func<OrderDefect, bool>> filter);
        void UpdateAsNoTracking(OrderDefect orderDefect);

    }
}
