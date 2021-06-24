using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IQuizService
    {
        void Add(QuizAddDto quizAddDto);
        void AddMultiple(QuizAddDto[] quizAddDto);
        void Delete(Quiz quiz);
        void Update(Quiz quiz);
        Quiz Get(int quizId);
        List<Quiz> GetAll();
        List<QuizDto> GetAllById(int articleId);
    }
}
