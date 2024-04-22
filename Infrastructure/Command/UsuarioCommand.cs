using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Command
{
    public class UsuarioCommand:IUsuarioCommand
    {
        private readonly UsuarioDbContext _context;

        public UsuarioCommand(UsuarioDbContext context)
        {
            _context=context;
        }

        public async Task InsertUsuario(Usuario usuario)
        {
             _context.Add(usuario);

            await _context.SaveChangesAsync();
        }
        
        public Task RemoveUsuario(int UsuarioId) 
        {
            throw new NotImplementedException();
        }
    }
}
