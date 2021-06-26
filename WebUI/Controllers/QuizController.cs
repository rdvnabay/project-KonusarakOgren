using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebUI.Controllers
{
    public class QuizController : Controller
    {
        private IQuizService _quizService;
        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }
        public IActionResult Add()
        {
           // QuizAddDto[] quizAddDto = new QuizAddDto[4];
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
