using BECRUDMASCOTAS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BECRUDMASCOTAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        private readonly AplicationDbContext _contex; 
        public MascotaController(AplicationDbContext contex)
        {
            _contex = contex;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listaMascotas = await _contex.mascotas.ToListAsync();
                return Ok(listaMascotas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
      
        }
    }
}
