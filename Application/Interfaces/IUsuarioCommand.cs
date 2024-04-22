﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUsuarioCommand
    {
        Task InsertUsuario(Usuario usuario);    
        Task RemoveUsuario(int UsuarioID);
    }
}
