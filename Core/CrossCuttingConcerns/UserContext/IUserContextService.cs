﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.UserContext
{
    public interface IUserContextService
    {
        int GetUserId();
    }
}
