using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class GetArticleById:ViewComponent
    {
        private IArticleService _articleService;
        public GetArticleById(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var article = _articleService.GetById(7);
            return View(article);
        }
    }
}
