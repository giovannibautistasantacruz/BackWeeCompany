using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ComunidadContext: DbContext
    {
        public ComunidadContext(DbContextOptions<ComunidadContext> options):
            base(options)
        { 
            
        
        }


        public DbSet<Personas> Personas { get; set; }
    }
}