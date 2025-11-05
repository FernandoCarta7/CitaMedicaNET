
using CitasMedicas.Models;

namespace CitasMedicas.Services
{
    public interface IPacienteService
    {
        Task<IEnumerable<Paciente>> GetAllAsync();
        Task<Paciente?> GetByIdAsync(int id);
        Task<Paciente> AddAsync(Paciente paciente);
        Task<bool> UpdateAsync(int id, Paciente paciente);
        Task<bool> DeleteAsync(int id);
    }
}