﻿namespace Entities.Concrete
{
    public class Quiz
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectAnswer { get; set; }

        public Article Article { get; set; }
    }
}
