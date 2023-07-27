using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer("server=LAPTOP-VLOIQ6M3;database=CoreBlogApiDB;integrated security=true; TrustServerCertificate=True;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
