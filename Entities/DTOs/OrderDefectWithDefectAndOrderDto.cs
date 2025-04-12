using Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class OrderDefectWithDefectAndOrderDto: OrderDefect,IDto
    {
        public string DefectName { get; set; }
        public string OrderNumber { get; set; }
        public int PantQuantity { get; set; }
        public DateTime OrderCreatedDate { get; set; }

    }
}
