using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class ProjectDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Project.db;");
        }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
