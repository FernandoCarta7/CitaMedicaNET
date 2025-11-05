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

        public DbSet<Cita> Cita { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
    }
}