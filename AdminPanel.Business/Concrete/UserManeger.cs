using AdminPanel.Business.Abstract;
using AdminPanel.DataAccess.Abstract;
using AdminPanel.Entities.Concrete;
using AdminPanel.Entities.Concrete.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Business.Concrete
{
    public class UserManeger : IUserService
    {
       private IUserDal _userDal;

        public UserManeger(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
             _userDal.Add(user);
        }

        public void delete(User user)
        {
            _userDal.delete(user);
        }

        public User GetByMail(string email)
        {
          return _userDal.Get(u=>u.Email==email);
            
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
            

        }
    }
}
