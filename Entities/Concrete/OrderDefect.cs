using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderDefect: AuditBaseEntity, IEntity
    {
        public int OrderId { get; set; }
        public int DefectId { get; set; }
        public int RowNumber { get; set; }
        public string Decision { get; set; }
       
    }
}
