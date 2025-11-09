using CitasMedicas.Models;
using CitasMedicas.Services;
using Microsoft.AspNetCore.Mvc;

namespace CitasMedicas.Controllers;

[ApiController]
[Route("app/[controller]")]
public class MedicoController : ControllerBase
{
    private MedicoService _service;

    public MedicoController(MedicoService service)
    {
        _service = service;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var medicos = await _service.GetAllAsync();

        return Ok(medicos);
    }

    [HttpGet("{id:int}")]
    public IActionResult? GetMedicoById(int id)
    {
        Medico? medico = _service.GetByIdAsync(id);
        
        if (medico is not null)
        {
            return Ok(medico);
        }
        return null;
    }
}