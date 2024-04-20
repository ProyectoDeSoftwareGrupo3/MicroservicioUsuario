using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public int RolId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set;}
        public int DNI { get; set; }
        public string Email {  get; set; }
        public int Celular {  get; set; }
        public string Direccion {  get; set; }
        public string CalificacionId {  get; set; }

        public Calificacion Calificacion { get; set; }
        public Rol Rol { get; set; }
    }
}
