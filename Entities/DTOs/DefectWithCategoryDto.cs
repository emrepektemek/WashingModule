﻿using Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class DefectWithCategoryDto: Defect,IDto
    {
        public string CategoryName { get; set; }
    }
}
