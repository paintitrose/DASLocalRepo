using Microsoft.EntityFrameworkCore;
using T2_VEGA_CHRIS.Models;

namespace T2_VEGA_CHRIS.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Distribuidor> Distribuidor { get; set; }
    }
}
