using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IQuizDal : IEntityRepository<Quiz>
    {
      //  List<> GetAllByArticle(int articleId);
    }
}
