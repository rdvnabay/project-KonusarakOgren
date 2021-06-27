using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Services
{
    public interface IWebRequestContentSiteService
    {
        List<string> LoadSite(string url);
    }
}
