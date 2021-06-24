using Entities.Dtos;

namespace Business.Abstract
{
    public interface IAuthService
    {
        void Login(UserForLoginDto userForLoginDto);
    }
}
