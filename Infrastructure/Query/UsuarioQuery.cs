using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Query
{
    public class UsuarioQuery : IUsuarioQuery
    {
        public List<Usuario> GetListUsuarios()
        {
            throw new NotImplementedException();
        }

        public Usuario GetUsuario(int Usuarioid)
        {
            throw new NotImplementedException();
        }
    }
}
