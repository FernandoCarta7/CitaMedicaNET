using CitasMedicas.Models;

namespace CitasMedicas.Services
{
    public interface IMedicoService
    {
        Task<IEnumerable<Medico>> GetAllAsync();
        Medico? GetByIdAsync(int id);
        Task<Medico> AddAsync(Medico medico);
        bool Update(int id, Medico medico);
        bool Delete(int id);
    }
}