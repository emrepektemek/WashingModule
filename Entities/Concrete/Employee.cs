using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employee: AuditBaseEntity, IEntity 
    {
        public string FullName { get; set; }

        public string Title { get; set; }

        public string PhoneNumber { get; set; }   
    }
}
