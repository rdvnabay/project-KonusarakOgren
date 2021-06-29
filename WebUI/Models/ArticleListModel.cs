using System.Collections.Generic;

namespace WebUI.Models
{
    public class ArticleListModel
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public List<string> Titles { get; set; }
        public List<string> Links { get; set; }
        public List<string> Contents { get; set; }
    }
}
