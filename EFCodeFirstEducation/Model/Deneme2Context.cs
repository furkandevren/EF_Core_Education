using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstEducation.Model
{
    public class Deneme2Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-B88QDOP;Database=Database2CodeFirst;Integrated Security=true ;TrustServerCertificate=true;");
        }

        public DbSet<Test> Furkans { get; set; }

    }
}
