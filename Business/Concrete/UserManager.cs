using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User getByUserName(string userName)
        {
            return _userDal.Get(x =>x.UserName==userName);
        }
    }
}
