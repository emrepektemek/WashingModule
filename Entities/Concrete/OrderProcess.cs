﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderProcess: AuditBaseEntity, IEntity 
    {
        public int OrderId { get; set; }
        public int CurrentRowNumber { get; set; }
        public bool IsCompleted { get; set; }
      
    }
}
