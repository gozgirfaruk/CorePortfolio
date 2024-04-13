using Microsoft.EntityFrameworkCore;
using ProjectApi.DAL.Entity;

namespace ProjectApi.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =DESKTOP-MT6QAH6\\SQLEXPRESS; database=DbCorePortfolioApi;Integrated Security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
