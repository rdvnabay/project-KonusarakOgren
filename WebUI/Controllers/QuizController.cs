using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        [HttpPost]
        public IActionResult Add(QuizAddDto quizAddDto)
        {
            _quizService.Add(quizAddDto);
            return RedirectToAction("Index","Home");
        }

        public IActionResult List(int articleId)
        {
            var quiz=_quizService.GetAllById(articleId);
            return View(quiz);
        }
    }
}
