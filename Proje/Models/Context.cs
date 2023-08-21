using Microsoft.EntityFrameworkCore;

namespace Proje.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CIHAN\\SQLEXPRESS;Database=proje;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<departmanlar> departmanlars { get; set; }
        
    }
}
