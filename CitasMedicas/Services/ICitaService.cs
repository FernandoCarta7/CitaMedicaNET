using CitasMedicas.Models;

namespace CitasMedicas.Services
{
    public interface ICitaService
    {
        Task<IEnumerable<Cita>> GetAllAsync();
        Task<Cita?> GetByIdAsync(int id);
        Task<Cita> AddAsync(Cita cita);
        Task<bool> UpdateAsync(int id, Cita cita);
        Task<bool> DeleteAsync(int id);
    }
}