
using CitasMedicas.Data;
using CitasMedicas.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasMedicas.Services
{
    public class PacienteService : IPacienteService
    {

        private readonly CitasMedicasDbContext _context;


        public PacienteService(CitasMedicasDbContext context)
        {
            _context = context;
        }

        public Task<Paciente> AddAsync(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Paciente>> GetAllAsync()
        {
            var lista = _context.Paciente.ToListAsync();
            return await lista;
        }

        public Task<Paciente?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IPacienteService.UpdateAsync(int id, Paciente paciente)
        {
            throw new NotImplementedException();
        }

        /**Task<bool> UpdateAsync(int id, Paciente paciente)
        {
            throw new NotImplementedException();
        }*/
    }
}