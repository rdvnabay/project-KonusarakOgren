using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal:EfEntityRepositoryBase<SqlServerProjecetDbContext, Article>,IArticleDal
    {
    }
}
