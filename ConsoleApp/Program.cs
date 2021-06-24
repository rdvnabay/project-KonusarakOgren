using HtmlAgilityPack;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://www.wired.com/";
            var web = new HtmlWeb();
            var document = web.Load(url);

            var htmlTag = "h5";
            var cssName = "post-listing";
            var div= "post-listing-list-item__description";
            var ul = "ul[@class='post-listing-component__list']";
            var li = "li[@class='post-listing-list-item__post']";
           // var a= "//a[class='post-listing-list-item__link']";
            var div2 = "div[@class='post-listing-list-item__description']";
            var h5= "h5[@class='post-listing-list-item__title']";
            //foreach (var item in document.DocumentNode.SelectNodes($"//div[@class='{div}']/{htmlTag}[@class='{cssName}']"))

    
            foreach (var item in document.DocumentNode.SelectNodes($"//{h5}"))
            {
                Console.WriteLine(item.InnerText);
            
            }

        }
    }
}
