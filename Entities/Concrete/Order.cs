using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order: AuditBaseEntity, IEntity
    {
        public int PantId { get; set; }
        public int WashingTypeId { get; set; }
        public int PantQuantity { get; set; }
        public string? Shift { get; set; }

    }
}
