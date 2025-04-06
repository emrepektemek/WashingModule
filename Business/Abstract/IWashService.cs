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
        public IResult Add(Wash wash);
        public Wash WashExists(Wash wash);
        public bool WashTimeControl(Wash wash);

    }
}
