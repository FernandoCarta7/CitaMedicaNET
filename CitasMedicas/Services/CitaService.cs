using CitasMedicas.Data;
using CitasMedicas.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CitasMedicas.Services
{
    public class CitaService : ICitaService
    {

        private readonly CitasMedicasDbContext context;

        public CitaService (CitasMedicasDbContext _context)
        {
            context = _context;
        }

        public Cita Add(Cita cita)
        {
            context.Add(cita);
            return cita;
        }

        public bool Delete(int id)
        {

            Cita? cita = context.Cita.Find(id);

            if (cita is not null)
            {
                context.Remove(id);
                return true;
            }
            return false; 
        }

        public async Task<IEnumerable<Cita>> GetAllAsync()
        {
            var lista = context.Cita
                .Include(c => c.Medico)
                .Include(c => c.Paciente)
                .ToListAsync();
            return await lista;
        }

        public async Task<Cita?> GetByIdAsync(int id)
        {
            return await context.Cita.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(int id, Cita cita)
        {
            Cita? cita1 = context.Cita.Find(id);

            if (cita1 is not null)
            {
                cita1.fecha_cita = cita.fecha_cita;
                context.Cita.Update(cita1);
                return true;
            }
            return false;
        }
    }
}