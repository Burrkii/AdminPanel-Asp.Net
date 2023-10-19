using AdminPanel.DataAccess.Abstract;
using AdminPanel.DataAccess.Concrete.EntityFramework.Context;
using AdminPanel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User, AdminPanelContext>, IUserDal
    {
        private IUserDal _userDal;
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new AdminPanelContext())
            {
                var result = from OperationClaim in context.OperationClaims
                             join UserOperationClaim in context.UserOperationClaims
                             on OperationClaim.Id equals UserOperationClaim.OperationClaimId
                             where UserOperationClaim.UserId == user.UserId
                             select new OperationClaim { Id = OperationClaim.Id, Name = OperationClaim.Name };
                return result.ToList();
            }
            
        }
    }
}
