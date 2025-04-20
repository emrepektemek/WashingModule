using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class QualityControl: AuditBaseEntity, IEntity
    {
        public int OrderId { get; set; }
        public string? Result { get; set; }
        public string? Shift { get; set; }
    }
}
