using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, WashingModuleContext>, IUserDal
    {

        private WashingModuleContext _context;

        public EfUserDal(WashingModuleContext context) : base(context) 
        {
            _context = context;
        }


        public List<OperationClaim> GetClaims(User user)
        {
            
            var result = from operationClaim in _context.OperationClaims
                            join userOperationClaim in _context.UserOperationClaims
                                on operationClaim.Id equals userOperationClaim.OperationClaimId
                            where userOperationClaim.UserId == user.Id
                            select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();

            
        }

        public List<UserOperationAssignmentDto> GetUsers()
        {
           
            var result = from u in _context.Users
                            join uoc in _context.UserOperationClaims
                            on u.Id equals uoc.UserId into userClaims
                            from uoc in userClaims.DefaultIfEmpty()
                            join oc in _context.OperationClaims
                            on uoc.OperationClaimId equals oc.Id into claims
                            from oc in claims.DefaultIfEmpty()
                            select new UserOperationAssignmentDto
                            {
                                Id = uoc.Id,
                                UserId = u.Id,
                                OperationClaimId = oc.Id, 
                                OperationClaimName = oc.Name,
                                FirstName = u.FirstName,
                                LastName = u.LastName, 
                                Email = u.Email,
                                PhoneNumber = u.PhoneNumber,
                                IsDeleted = uoc.IsDeleted
                            };

                return result.ToList();
   
        }

        public User Add(User user)
        {
            
            var addedEntity = _context.Entry(user);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
            

            return user;
        }

       
    }
}
