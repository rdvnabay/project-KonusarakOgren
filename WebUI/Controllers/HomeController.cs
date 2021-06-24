using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //WebRequest SiteyeBaglantiTalebi = HttpWebRequest.Create("https://www.wired.com/");
            //WebResponse GelenCevap = SiteyeBaglantiTalebi.GetResponse();
            //StreamReader CevapOku = new StreamReader(GelenCevap.GetResponseStream());
            //string KaynakKodlar = CevapOku.ReadToEnd();
            //int IcerikBaslangicIndex = KaynakKodlar.IndexOf("<h5>") + 4;
            //int IcerikBitisIndex = KaynakKodlar.Substring(IcerikBaslangicIndex).IndexOf("</h5>");

            //Console.WriteLine(KaynakKodlar.Substring(IcerikBaslangicIndex, IcerikBitisIndex));
            //Console.Read();
            return View();
        }
    }
}
