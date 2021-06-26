using Entities.Concrete;
using Entities.Dtos;

namespace WebUI.Services
{
    public interface IAuthSessionService
    {
        UserForLoginDto GetUser();
        void SetUser(UserForLoginDto user);
        void Clear();
    }
}
