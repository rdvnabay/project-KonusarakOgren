using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using WebUI.Services;

namespace WebUI.ViewComponents
{
    public class ArticleList : ViewComponent
    {
        private IArticleService _articleService;
        private IWebRequestContentSiteService _webRequestContentSiteService;
        public ArticleList(IArticleService articleService, IWebRequestContentSiteService webRequestContentSiteService)
        {
            _articleService = articleService;
            _webRequestContentSiteService = webRequestContentSiteService;
        }

        public IViewComponentResult Invoke()
        {
            var model = _webRequestContentSiteService.LoadSite();

            for (int i = 0; i < 5; i++)
            {
                ArticleAddDto articleAddDto = new()
                {
                    Content = model.Contents[i],
                    Title = model.Titles[i]
                };
                _articleService.Add(articleAddDto);
            }

            ViewBag.Content = _articleService.getByContent(1);
            return View(model);
        }
    }
}
