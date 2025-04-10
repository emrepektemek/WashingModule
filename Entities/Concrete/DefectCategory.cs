using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DefectCategory: AuditBaseEntity, IEntity
    {
        public string CategoryName { get; set; }
  
    }
}
