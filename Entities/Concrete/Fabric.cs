using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Fabric: AuditBaseEntity, IEntity
    {
        public string FabricMaterials { get; set; }
    }
}
