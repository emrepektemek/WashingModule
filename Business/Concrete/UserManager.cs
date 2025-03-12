﻿using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public User Add(User user)
        {
            return _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);

        }

        public IDataResult<List<UserOperationAssignmentDto>> GetUsers()
        {
            return new SuccessDataResult<List<UserOperationAssignmentDto>>(_userDal.GetUsers());
        }

        public IDataResult<List<User>> GetUsersForCustomer()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetUsersForCustomer());
        }
    }
}
