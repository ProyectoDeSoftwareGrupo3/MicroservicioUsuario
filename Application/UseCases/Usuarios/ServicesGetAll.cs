using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Usuarios
{
    public class ServicesGetAll : IServicesGetAll
    {
        public object GetAll()
        {
            return new { name = "string" };
        }
    }
}
