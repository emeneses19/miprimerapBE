using Microsoft.EntityFrameworkCore;

namespace BECRUDMASCOTAS.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Mascota> mascotas { get; set; }
    }
}
