using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Defect: AuditBaseEntity, IEntity   
    {
        public int OrderId { get; set; }
        public string DefectName { get; set; }
        public bool IsDefect { get; set; }
        public int RowNumber { get; set; }

    }
}
