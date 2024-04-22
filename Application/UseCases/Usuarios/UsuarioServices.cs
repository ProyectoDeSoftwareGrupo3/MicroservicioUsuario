using Application.Interfaces;
using Application.Request;
using Application.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Usuarios
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioCommand _command;
        private readonly IUsuarioQuery _query;

        public UsuarioServices(IUsuarioCommand command, IUsuarioQuery query)
        {
            _command = command;
            _query = query;
        }

        public async Task<CreateUsuarioResponse> CreateUsuario(CreateUsuarioRequest request)
        {
            var Usuario = new Usuario()
            {
                Nombre = request.UsuarioNombre,
                Apellido = request.UsuarioApellido,
                DNI = request.DNI,
                Email = request.Email,
                Celular = request.Celular,
                Direccion = request.Direccion,
                
                Calificacion = new Calificacion
                 {
                    Descripcion = request.CalificacionDescripcion
                  },
                 Rol= new Rol
                 {
                 Descripcion=request.RolDescripcion,
                 }

            };
           await _command.InsertUsuario(Usuario);
            return new CreateUsuarioResponse
            {
                CalificacionResponse = new CreateUsuarioCalificacionResponse
                {
                    Id = Usuario.Calificacion.Id,
                    Descripcion = Usuario.Calificacion.Descripcion,
                },
                RolResponse = new CreateUsuarioRolResponse
                {
                    Id = Usuario.Rol.Id,
                    Descripcion = Usuario.Rol.Descripcion,
                },
                Nombre = Usuario.Nombre,
                Apellido = Usuario.Apellido,
                Email = Usuario.Email,
                DNI = Usuario.DNI,
                Celular = Usuario.Celular,
                Direccion = Usuario.Direccion,
                Id = Usuario.Id,
            };
        }

        public Task<Usuario> DeleteUsuario(int UsuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> GetAllUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetUsuarioById(int UsuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> UpdateUsuario(int UsuarioId)
        {
            throw new NotImplementedException();
        }
    }
}
