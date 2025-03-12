﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Entities.Concrete;
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
    public class UserOperationClaimManager: IUserOperationClaimService
    {
        IUserOperationClaimDal _userOperationClaimDal;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal; 
                
        }

        public IResult Add(UserOperationClaim userOperationClaim)
        {         
            
            var userOperationClaimObject = new UserOperationClaim
            {        
                UserId = userOperationClaim.UserId,
                OperationClaimId = userOperationClaim.OperationClaimId, 
                Status = true,
                IsDeleted = false,
                CreatedUserId = userOperationClaim.CreatedUserId,
                CreatedDate = DateTime.Now
            };

            _userOperationClaimDal.Add(userOperationClaimObject);

            return new SuccessResult(Messages.CreatedUserOperationClaim);   

        }


        [SecuredOperation("admin")]
        public IResult Update(UserOperationClaim userOperationClaim)
        {

            var userOperationClaimObject = new UserOperationClaim
            {
                Id = userOperationClaim.Id,
                UserId = userOperationClaim.UserId,
                OperationClaimId = userOperationClaim.OperationClaimId,
                LastUpdatedUserId = userOperationClaim.LastUpdatedUserId,
                LastUpdatedDate = DateTime.Now
            };

            _userOperationClaimDal.Update(userOperationClaimObject);

            return new SuccessResult(Messages.UpdatedUserOperationClaim);

        }


        [SecuredOperation("admin")]
        public IResult Delete(UserOperationClaim userOperationClaim)
        {
            var userOperationClaimObject = new UserOperationClaim
            {
                Id = userOperationClaim.Id,
                UserId = userOperationClaim.UserId,
                OperationClaimId = userOperationClaim.OperationClaimId,
                LastUpdatedUserId = userOperationClaim.LastUpdatedUserId,
                LastUpdatedDate = DateTime.Now,
                IsDeleted = userOperationClaim.IsDeleted
            };

            _userOperationClaimDal.Update(userOperationClaimObject);

            return new SuccessResult(Messages.DeleteddUserOperationClaim);

        }

        [SecuredOperation("admin,customer.representative")]
        public int GetUserOperatinClaimId(int userId)
        {

            var userOperatinClaimObject = _userOperationClaimDal.Get(uoc => uoc.UserId == userId);

            if(userOperatinClaimObject != null)
            {
                return userOperatinClaimObject.OperationClaimId;
            } 

            return 0;

        }



    }
}
