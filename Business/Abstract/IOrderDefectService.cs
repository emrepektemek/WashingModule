﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderDefectService
    {
        IDataResult<List<OrderDefectWithDefectAndOrderDto>> GetAllWithDefectName();
        IResult Add(OrderDefect orderDefect);
        IResult Update(OrderDefect orderDefect);
        OrderDefect GetCurrentOrderDefect(OrderDefect orderDefect);

    }
}
