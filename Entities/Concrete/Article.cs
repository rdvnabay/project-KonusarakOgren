using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Article
    {
        public Article()
        {
            Quizzes = new List<Quiz>();
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Quiz> Quizzes { get; set; }
    }
}
