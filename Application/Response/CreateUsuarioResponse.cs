using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response
{
    public class CreateUsuarioResponse
    { 
        public Guid Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public int Celular { get; set; }
        public string Direccion { get; set; }

        public CreateUsuarioCalificacionResponse CalificacionResponse { get; set; }

        public CreateUsuarioRolResponse RolResponse { get; set; }

    } 
    
    public class CreateUsuarioRolResponse 
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
    public class CreateUsuarioCalificacionResponse
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
    
}
