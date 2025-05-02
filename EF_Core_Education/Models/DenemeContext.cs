using Microsoft.EntityFrameworkCore;

namespace EF_Core_Education.Models
{
    public class DenemeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-B88QDOP; Database=Database1; Integrated Security=true; TrustServerCertificate=true;");
        }
       public DbSet<SimpleTable> SimpleTables { get; set; }
    }
    
}
