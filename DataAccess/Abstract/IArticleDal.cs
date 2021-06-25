using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IArticleDal:IEntityRepository<Article>
    {
        Article GetArticleAndQuizzes(int articleId);
    }
}
