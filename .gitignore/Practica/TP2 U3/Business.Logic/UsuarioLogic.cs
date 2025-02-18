﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic: BusinessLogic
    {
        Data.Database.UsuarioAdapter UsuarioData;
        public UsuarioLogic()
        {
            UsuarioData = new Data.Database.UsuarioAdapter();
        }

        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public void Save(Usuario user)
        {
            UsuarioData.Save(user);
        }

        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }

        public Usuario BuscarPorNombre(string nombre)
        {
            return UsuarioData.BuscarPorNombre(nombre);
        }
    }
}
