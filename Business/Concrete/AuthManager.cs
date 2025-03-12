﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        private IUserOperationClaimService _userOperationClaimService;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, IUserOperationClaimService userOperationClaimService)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _userOperationClaimService = userOperationClaimService; 
        }

        [ValidationAspect(typeof(AuthValidator))]
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                PhoneNumber = userForRegisterDto.PhoneNumber,
                Gender = userForRegisterDto.Gender,
            };

            var userObject = _userService.Add(user);

            if (user != null)
            {
                var userOperationClaimObejct = new UserOperationClaim
                {
                    UserId = user.Id,
                    OperationClaimId = 4
                };

                _userOperationClaimService.Add(userOperationClaimObejct);

            }              
                return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }


        [ValidationAspect(typeof(AdminRegisterValidator))]
        public IDataResult<User> AdminRegister(AdminRegisterDto adminRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            { 
                Email = adminRegisterDto.Email,
                FirstName = adminRegisterDto.FirstName,
                LastName = adminRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                PhoneNumber = adminRegisterDto.PhoneNumber,
                Gender = adminRegisterDto.Gender,
                CreatedUserId = adminRegisterDto.CreatedUserId,
                CreatedDate = DateTime.Now,
            };

            var userObject = _userService.Add(user);


            if (user != null)
            {
                var operationClaimId = adminRegisterDto.OperationClaimId == 0 ? 4 : adminRegisterDto.OperationClaimId;

                var userOperationClaimObejct = new UserOperationClaim
                {
                    UserId = user.Id,
                    OperationClaimId = operationClaimId,
                    CreatedUserId = adminRegisterDto.CreatedUserId
                };

                _userOperationClaimService.Add(userOperationClaimObejct);

            }
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

      
    }
}
