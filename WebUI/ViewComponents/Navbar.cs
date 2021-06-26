using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using WebUI.Services;

namespace WebUI.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private IAuthSessionService _authSessionService;
        public Navbar(IAuthSessionService authSessionService)
        {
            _authSessionService = authSessionService;
        }
        public ViewViewComponentResult Invoke()
        {
            var user = _authSessionService.GetUser();
            return View(user);
        }
    }
}
