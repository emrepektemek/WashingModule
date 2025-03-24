using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Wash: AuditBaseEntity, IEntity
    {
        public int OrderId { get; set; }
        public int WashingTypeId { get; set; }
        public string Shift { get; set; }
    }
}
