using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using trabajo_final_backend.Factory;
using trabajo_final_backend.Models;
using trabajo_final_backend.Singleton;

namespace trabajo_final_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        [HttpGet]
        [Route("api/CrearSuperheroe")]
        public IActionResult CreateSuperheroe([FromQuery] string tipo, string nombre)
        {
            ISuperheroe superheroe = SuperheroeFactory.CreateSuperheroe(tipo, nombre);
            if (superheroe == null)
            {
                return BadRequest("Tipo de superhéroe no válido.");
            }
            return Ok(superheroe);
        }

        [HttpGet]
        [Route("api/VisitarEnfermeria")]
        public IActionResult VisitarEnfermeria(string type, int health, int times)
        {
            EnfermeriaSingleton enfermeria = EnfermeriaSingleton.Instance;

            int healthBefore = health;

            if (type.ToLower() == "guerrero" || type.ToLower() == "mago" || type.ToLower() == "arquero")
            {
                int healthAfter = enfermeria.Attend(type, health, times);

                if (healthBefore == healthAfter)
                {
                    return BadRequest("No se pudo incrementar la salud debido a que se alcanzó el límite de visitas.");
                }

                return Ok(new { HealthBefore = healthBefore, HealthAfter = healthAfter });
            }

            return BadRequest("Tipo de superhéroe no válido.");
        }
    }
}
