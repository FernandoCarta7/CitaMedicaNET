using CitasMedicas.Services;
using Microsoft.AspNetCore.Mvc;

namespace CitasMedicas.Controllers;

[ApiController]
[Route("cita/[controller]")]
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
}