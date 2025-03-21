using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PantManager : IPantService
    {

        private IPantDal _pantDal;  
        public PantManager(IPantDal pantDal)
        {
            _pantDal = pantDal;
        }
     
        public IDataResult<List<PantFabricDto>> GetAllWithFabric()
        {
            return new SuccessDataResult<List<PantFabricDto>>(_pantDal.GetAllWithFabric());
        }
    }
}
