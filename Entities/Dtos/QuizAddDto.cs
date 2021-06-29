namespace Entities.Dtos
{
    public class QuizAddDto
    {
        //Article
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //Quiz
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
