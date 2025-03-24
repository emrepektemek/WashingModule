using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WashingTypeManager : IWashingTypeService
    {

        private IWashingTypeDal _washingTypeDal;

        public WashingTypeManager(IWashingTypeDal washingTypeDal)
        {
            _washingTypeDal = washingTypeDal;
        }
        public IDataResult<List<WashingType>> GetAll()
        {
            return new SuccessDataResult<List<WashingType>>(_washingTypeDal.GetAll());  
        }
    }
}
