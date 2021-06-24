using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQuizDal: EfEntityRepositoryBase<SqlServerProjecetDbContext, Quiz>,IQuizDal
    {
    }
}
