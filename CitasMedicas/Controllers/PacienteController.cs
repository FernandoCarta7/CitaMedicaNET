using System.Threading.Tasks;
using CitasMedicas.Models;
using CitasMedicas.Services;
using Microsoft.AspNetCore.Mvc;

namespace CitasMedicas.Controllers;

[ApiController]
[Route("app/[controller]")]
public class PacienteController : ControllerBase
{
    private PacienteService _service;

    public PacienteController(PacienteService service)
    {
        _service = service;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var pacientes = await _service.GetAllAsync();



        return Ok(pacientes);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult?> GetPacienteById(int id)
    {
        Paciente? paciente = await _service.GetByIdAsync(id);
        
        if (paciente is not null)
        {
            return Ok(paciente);
        }
        return null;
    }
    
}