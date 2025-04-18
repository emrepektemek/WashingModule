using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWashService
    {
        IDataResult<List<WashingDto>> GetAll();
        IResult Add(Wash wash);
        Wash WashExists(Wash wash);
        bool WashTimeControl(Wash wash);
        bool MachineBusyControl(Wash wash);

    }
}
