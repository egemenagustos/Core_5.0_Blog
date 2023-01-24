using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EGEMEN\\SQLEXPRESS;database=CoreBlogApiDb; integrated security=true;");
        }

        public DbSet<Employe> Employes { get; set; }
    }
}
