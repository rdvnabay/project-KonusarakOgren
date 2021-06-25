using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<ProjectDbContext, Article>, IArticleDal
    {
        public Article GetArticleAndQuizzes(int articleId)
        {
            using (var context = new ProjectDbContext())
            {

                var result = context.Articles
                                .Include(a => a.Quizzes)
                                .Where(a => a.Id == articleId)
                                .FirstOrDefault();
                return result;
            }
        }
    }
}
