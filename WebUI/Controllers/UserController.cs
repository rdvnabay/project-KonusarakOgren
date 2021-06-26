using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {
        private IArticleService _articleService;
        private IQuizService _quizService;
        public UserController(IArticleService articleService, IQuizService quizService)
        {
            _articleService = articleService;
            _quizService = quizService;
        }
        public IActionResult Quiz(int articleId)
        {
            var quiz = _quizService.GetAllByArticle(articleId);
            return View(quiz);
        }

        [HttpPost]
        public IActionResult QuizResult(List<QuizDto> quizDto)
        {
            return RedirectToAction("Quiz","User");
        }
    }
}
