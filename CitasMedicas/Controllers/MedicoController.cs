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
}