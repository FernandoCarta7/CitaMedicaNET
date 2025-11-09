using CitasMedicas.Models;

namespace CitasMedicas.Services
{
    public interface ICitaService
    {
        Task<IEnumerable<Cita>> GetAllAsync();
        Task<Cita?> GetByIdAsync(int id);
        Cita Add(Cita cita);
        Task<bool> UpdateAsync(int id, Cita cita);
        bool Delete(int id);
    }
}