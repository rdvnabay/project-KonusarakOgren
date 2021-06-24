using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ArticleController : Controller
    {
        private IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IActionResult List()
        {
            var articles= _articleService.GetAll();
            return View(articles);
        }

        public IActionResult Delete(int articleId)
        {
            _articleService.DeleteById(articleId);
            return RedirectToAction("List", "Article");
        }
    }
}
