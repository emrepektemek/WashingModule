using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class WashingDto: Wash
    {
        // Orders
        public string OrderNumber { get; set; }
        public int PantId { get; set; }
        public int PantQuantity { get; set; }

        // Pants
        public string ModelName { get; set; }

        // WashingTypes
        public string WashingTypeName { get; set; }
        public int WashingTime { get; set; }

        // Machines
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string MachineType { get; set; }

    }
}
