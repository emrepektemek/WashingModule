﻿using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IOrderDal: IEntityRepository<Order>
    {
        List<OrderReportDto> GetOrderReports();

        List<UserOrderOrderReportDto> GetUserOrderReports(int customerId);

        List<OrderApproveDto> GetOrderApproves();

        Order UpdateIsApprovedFalse(OrderUpdateApproveRejectDto orderUpdateApproveRejectDto);

        Order UpdateIsApprovedTrue(OrderUpdateApproveAcceptDto orderUpdateApproveAcceptDto);
    }
}
