using AdminPanel.DataAccess.Abstract;
using AdminPanel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Business.Abstract
{
   

    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        void delete(User user);
        User GetByMail(string Email);
    }
}
