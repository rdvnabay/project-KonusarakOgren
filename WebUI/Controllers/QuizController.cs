using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
            return View();
        }

        [HttpPost]
        public IActionResult Add(List<QuizAddDto> quizAddDto)
        {
            _quizService.AddMultiple(quizAddDto);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult List()
        {
            var quiz = _quizService.GetAll();
            return View(quiz);
        }
    }
}
