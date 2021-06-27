using Business.Abstract;
using Entities.Dtos;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebUI.Helper;
using WebUI.Services;

namespace WebUI.Controllers
{
    public class QuizController : Controller
    {
        private IQuizService _quizService;
        private IWebRequestContentSiteService _webRequestContentSiteService;
        public QuizController(IQuizService quizService, IWebRequestContentSiteService webRequestContentSiteService)
        {
            _quizService = quizService;
            _webRequestContentSiteService = webRequestContentSiteService;
        }
        public IActionResult Add()
        {
            var titles=_webRequestContentSiteService.LoadSite("https://www.wired.com/");
            ViewBag.Title = titles;
            return View();
        }

        [HttpPost]
        public IActionResult Add(List<QuizAddDto> quizAddDto)
        {
            _quizService.AddMultiple(quizAddDto);
            return RedirectToAction("Index","Home");
        }

        public IActionResult List(int articleId)
        {
            var quiz=_quizService.GetAllById(articleId);
            return View(quiz);
        }
    }
}
