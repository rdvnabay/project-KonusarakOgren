using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebUI.Services;

namespace WebUI.Controllers
{
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private IAuthSessionService _authSessionService;
        public AuthController(IAuthService authService, IAuthSessionService authSessionService)
        {
            _authService = authService;
            _authSessionService = authSessionService;
        }

        public IActionResult Login()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            if (!ModelState.IsValid)
            {
                return View(userForLoginDto);
            }
            var result= _authService.Login(userForLoginDto);
            if (!result.Success)
            {
                ViewBag.UserNotFound = result.Message;
                return View();
            }
             var user= _authSessionService.GetUser();
            _authSessionService.SetUser(userForLoginDto);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            _authSessionService.Clear();
            return RedirectToAction("Login", "Auth");
        }
    }
}
