using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PantFabricDto: AuditBaseEntity, IDto
    {
        public int FabricId { get; set; }
        public string FabricMaterials { get; set; }
        public string ModelName { get; set; } 
        
    }
}
