using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Pant: AuditBaseEntity, IEntity 
    {
        public int FabricId { get; set; }
        public string ModelName { get; set; }
    }
}
