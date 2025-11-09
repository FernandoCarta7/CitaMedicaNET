using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CitasMedicas.Data;
using CitasMedicas.Models;
using CitasMedicas.Services;
using Microsoft.AspNetCore.Mvc;
namespace CitasMedicas.Controllers
{
    [ApiController]
    [Route("app/[controller]")]
    public class CitaController : ControllerBase
    {
        public CitaService service;

        public CitaController(CitaService _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var citas = await service.GetAllAsync();
            return Ok(citas);
        }
    }
}
