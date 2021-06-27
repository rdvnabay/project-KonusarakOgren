using HtmlAgilityPack;
using System.Collections.Generic;
using WebUI.Helper;

namespace WebUI.Services
{
    public class WebRequestContentSiteService : IWebRequestContentSiteService
    {
        private readonly string url = "https://www.wired.com/";
        public List<string> Links()
        {
            List<string> links = new();
            var url = "https://www.wired.com/story/the-secret-workings-of-smell-receptors-revealed-at-last/";
            var web = new HtmlWeb();
            var document = web.Load(url);
            var paragraph = $"{XPathTagElement.paragraph}";
            var items = document.DocumentNode.SelectNodes(paragraph);
            foreach (var item in items)
            {
                links.Add(item.InnerText);
            }

            return links;

            
            //var web = new HtmlWeb();
            //var document = web.Load(url);
            //var title = $"{XPathTagElement.div}{XPathTagElement.ul}{XPathTagElement.li}";
            //for (int i = 0; i < 5; i++)
            //{
            //    string link = document.DocumentNode.SelectNodes($"{title}{XPathTagElement.a}")[i].Attributes["href"].Value;
            //    link = url + link;
            //    //document = web.Load(link);
            //    //var paragraph = $"{XPathTagElement.div}{XPathTagElement.ul}{XPathTagElement.li}";
            //    links.Add(link);
            //}
            //return links;
        }

        public List<string> LoadSite()
        {
            List<string> titles = new();
            var web = new HtmlWeb();
            var document = web.Load(url);
            var title = $"{XPathTagElement.div}{XPathTagElement.ul}{XPathTagElement.li}{XPathTagElement.h5}";
            var items = document.DocumentNode.SelectNodes(title);
            foreach (var item in items)
            {
                titles.Add(item.InnerText);
            }
            return titles;
        }
    }
}
