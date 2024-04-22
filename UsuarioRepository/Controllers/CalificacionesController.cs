using Microsoft.AspNetCore.Mvc;

namespace UsuarioRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalificacionesController : Controller
    {
        [HttpPost]
        public IActionResult Create()
        {
            return new JsonResult(new { name = "string" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return new JsonResult(new { name = "string" });
        }
        //  [HttpGet]
        //public IActionResult GetbyId()
        //{
        //  return new JsonResult(new { name = "string" });
        //}

        [HttpPatch]
        public IActionResult Update()
        {
            return new JsonResult(new { name = "string" });
        }

        [HttpDelete]

        public IActionResult Delete()
        {
            return new JsonResult(new { name = "string" });
        }

    }
}
