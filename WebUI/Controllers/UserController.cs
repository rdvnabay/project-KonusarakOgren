using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

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
            var quiz= _articleService.GetArticleAndQuizzes(articleId);
            return View(quiz);
        }
    }
}
