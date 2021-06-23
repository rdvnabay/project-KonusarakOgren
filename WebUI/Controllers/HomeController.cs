using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
