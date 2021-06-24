using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IArticleService
    {
        void Add(Article article);
        List<ArticleDto> GetAll();
        //ArticleDto GetById(int articleId);
        void DeleteById(int articleId);
    }
}
