using CitasMedicas.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasMedicas.Data
{
    public class CitasMedicasDbContext : DbContext
    {
        public CitasMedicasDbContext(DbContextOptions<CitasMedicasDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Paciente { get; set; }
    }
}