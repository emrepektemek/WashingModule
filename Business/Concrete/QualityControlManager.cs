using Business.Abstract;
using Business.Constants;
using Core.CrossCuttingConcerns.UserContext;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class QualityControlManager : IQualityControlService
    {
        private IQualityControlDal _qualityControlDal;
        private IUserContextService _userContextService;

        public QualityControlManager(IQualityControlDal qualityControlDal, IUserContextService userContextService)
        {
            _qualityControlDal = qualityControlDal;
            _userContextService = userContextService;

        }

        public IResult FirstCreate(int orderId)
        {
            int userId = _userContextService.GetUserId();

            var newQualityControl = new QualityControl
            {
                OrderId = orderId,         
                Result = null,
                CreatedUserId = userId,
                CreatedDate = DateTime.Now,
                LastUpdatedUserId = userId,
                LastUpdatedDate = DateTime.Now,
                Status = true,
                IsDeleted = false
            };

            _qualityControlDal.Add(newQualityControl);

            return new SuccessResult(Messages.QualityControlCreated);
        }

        public IDataResult<List<QualityControl>> GetAll()
        {
            return new SuccessDataResult<List<QualityControl>>(_qualityControlDal.GetAll());
        }
  
        public IResult Update(QualityControl qualityControl)
        {
            int userId = _userContextService.GetUserId();

            var currentQualityControl = GetCurrentQualityControl(qualityControl);

            var uptadeQualityControl = new QualityControl
            {
                Id = currentQualityControl.Id,
                OrderId = qualityControl.OrderId,
                Result = qualityControl.Result,
                CreatedUserId = currentQualityControl.CreatedUserId,
                CreatedDate = currentQualityControl.CreatedDate,
                LastUpdatedUserId = userId,
                LastUpdatedDate = DateTime.Now,
                Status = true,
                IsDeleted = false
            };

            _qualityControlDal.UpdateAsNoTracking(uptadeQualityControl);

            return new SuccessResult(Messages.QualityControlUpdated);
        }

        public QualityControl GetCurrentQualityControl(QualityControl qualityControl)
        {
            return _qualityControlDal.Get(qc => qc.OrderId == qualityControl.OrderId);
        }

    }
}
