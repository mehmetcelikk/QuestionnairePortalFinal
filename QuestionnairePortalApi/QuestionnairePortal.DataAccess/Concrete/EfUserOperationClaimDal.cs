using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, QuestionnaireDb>, IUserOperationClaimDal
    {
        public List<UserOperationClaimDto> GetDtos(Expression<Func<UserOperationClaimDto, bool>> filter = null)
        {
            using (var context = new QuestionnaireDb())
            {
                var join = from userOperationClaims in context.UserOperationClaims
                           join users in context.Users on userOperationClaims.UserId equals users.Id
                           join operationClaims in context.OperationClaims on userOperationClaims.OperationClaimId equals operationClaims.Id
                           select new UserOperationClaimDto()
                           {
                               Id = userOperationClaims.Id,
                               UserId = users.Id,
                               OperationClaimId = operationClaims.Id,

                               UserEmail = users.Email,
                               UserFirstName = users.FirstName,
                               UserLastName = users.LastName,

                               OperationClaimName = operationClaims.Name,
                               OperationClaimIsApproved = operationClaims.IsApproved,

                               UserOperationClaimIsApproved = userOperationClaims.IsApproved
                           };
                return filter == null ? join.ToList() : join.Where(filter).ToList();
            }
        }

        public List<UserOperationClaimDto> GetDtoUserOperationClaims(User user)
        {
            using (QuestionnaireDb context = new QuestionnaireDb())
            {
                var join = from userOperationClaims in context.UserOperationClaims
                           join users in context.Users on userOperationClaims.UserId equals users.Id
                           join operationClaims in context.OperationClaims on userOperationClaims.OperationClaimId equals operationClaims.Id
                           //where userOperationClaims.UserId == user.Id
                           select new UserOperationClaimDto()
                           {
                               Id = userOperationClaims.Id,
                               UserId = users.Id,
                               OperationClaimId = operationClaims.Id,
                               
                               UserEmail = users.Email,
                               UserFirstName = users.FirstName,
                               UserLastName = users.LastName,

                               OperationClaimName = operationClaims.Name,
                               OperationClaimIsApproved = operationClaims.IsApproved,

                               UserOperationClaimIsApproved = userOperationClaims.IsApproved
                           };
                return join.Where(x => x.UserId == user.Id).ToList();
               // return join.ToList();
            }
        }
    }
}
