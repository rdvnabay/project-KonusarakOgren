using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using WebUI.Extensions;

namespace WebUI.Services
{
    public class AuthSessionService : IAuthSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;
        public AuthSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetUser(UserForLoginDto user)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("user", user);

        }
        public UserForLoginDto GetUser()
        {
            UserForLoginDto userToCheck = _httpContextAccessor.HttpContext.Session.GetObject<UserForLoginDto>("user");
            if (userToCheck == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("user", new UserForLoginDto());
                userToCheck = _httpContextAccessor.HttpContext.Session.GetObject<UserForLoginDto>("user");
            }
            return userToCheck;
        }
        public void Clear()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
        }
    }
}
