using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request
{
    public class CreateUsuarioRequest
    {
        public string UsuarioApellido { get; set; }
        public string UsuarioNombre { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public int Celular { get; set; }
        public string Direccion { get; set; }

        public string RolDescripcion { get; set; }

        public string CalificacionDescripcion { get; set; }
    }
}
