using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IArticleService
    {
        void Add(ArticleAddDto articleAddDto);
        List<ArticleDto> GetAll();
        void DeleteById(int articleId);
        List<string> GetAllByTitle();
        Article GetArticleAndQuizzes(int articleId);
        string getByContent(int id);
        Article GetById(int id);
    }
}
