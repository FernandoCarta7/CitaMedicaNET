using CitasMedicas.Models;

namespace CitasMedicas.Services
{
    public interface IMedicoService
    {
        Task<IEnumerable<Medico>> GetAllAsync();
        Task<Medico?> GetByIdAsync(int id);
        Task<Medico> AddAsync(Medico medico);
        Task<bool> UpdateAsync(int id, Medico medico);
        Task<bool> DeleteAsync(int id);
    }
}