using Application.Interfaces;
using Application.Request;
using Microsoft.AspNetCore.Mvc;

namespace UsuarioRepository.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioServices _services;
        public UsuariosController(IUsuarioServices services) 
        {
            _services = services;
        }
        
       [HttpPost]
        public async Task<IActionResult> CreateUsuario(CreateUsuarioRequest request)
        {
            var result = await _services.CreateUsuario(request);
            return new JsonResult(result) { StatusCode=201};
            
       }
       
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var result = await _services.GetAllUsuarios();
            return new JsonResult(new {result});
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

