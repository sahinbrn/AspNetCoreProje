using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLater.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UsersManager : IUsersService
    {
        IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public void TAdd(Users t)
        {
            _usersDal.Insert(t);
        }

        public void TDelete(Users t)
        {
            _usersDal.Delete(t);
        }

        public Users TGetByID(int id)
        {
            return _usersDal.GetByID(id);
        }

        public List<Users> TGetList()
        {
            return _usersDal.GetList();
        }

        public List<Users> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Users t)
        {
            _usersDal.Update(t);
        }
    }
}
