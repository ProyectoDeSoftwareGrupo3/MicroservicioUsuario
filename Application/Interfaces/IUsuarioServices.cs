using Application.Request;
using Application.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUsuarioServices
    {
        Task<CreateUsuarioResponse> CreateUsuario(CreateUsuarioRequest request);

        Task<Usuario> DeleteUsuario(int UsuarioId);

        Task<Usuario> UpdateUsuario(int UsuarioId);

        Task<List<Usuario>> GetAllUsuarios();

        Task<Usuario> GetUsuarioById(int UsuarioId);
    }
}
