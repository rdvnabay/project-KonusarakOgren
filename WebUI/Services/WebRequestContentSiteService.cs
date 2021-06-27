using HtmlAgilityPack;
using System.Collections.Generic;
using WebUI.Helper;

namespace WebUI.Services
{
    public class WebRequestContentSiteService : IWebRequestContentSiteService
    {
        public List<string> LoadSite(string url)
        {
            List<string> titles = new();
            var web = new HtmlWeb();
            var document = web.Load(url);
            var title = $"{XPathTagElement.div}{XPathTagElement.ul}{XPathTagElement.li}{XPathTagElement.h5}";
            foreach (var item in document.DocumentNode.SelectNodes(title))
            {
                titles.Add(item.InnerText);
            }
            return titles;
        }
    }
}
