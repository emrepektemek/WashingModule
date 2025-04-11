using Business.Abstract;
using Core.CrossCuttingConcerns.UserContext;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DefectManager : IDefectService
    {
        private IDefectDal _defectDal;

        private IUserContextService _userContextService;

        public DefectManager(IDefectDal defectDal, IUserContextService userContextService)
        {
            _defectDal = defectDal;
            _userContextService = userContextService;
        }


        public IDataResult<List<DefectWithCategoryDto>> GetAllWitCategory()
        {
            return new SuccessDataResult<List<DefectWithCategoryDto>>(_defectDal.GetAllWitCategory());
        }
    }
}
