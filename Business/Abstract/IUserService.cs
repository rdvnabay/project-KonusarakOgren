using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
   public interface IUserService
    {
        User getByUserName(string userName);
    }
}
