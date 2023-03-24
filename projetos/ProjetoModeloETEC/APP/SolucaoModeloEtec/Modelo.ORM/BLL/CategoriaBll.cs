﻿using Modelo.ORM.DAL;
using Modelo.ORM.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.BLL
{
    public class CategoriaBll
    {
        CategoriaDal dal = new CategoriaDal();

        public CategoriaInfo Salvar(CategoriaInfo obj)
        {
            return dal.Salvar(obj);
        }
        public CategoriaInfo Selecionar(int categoriaId)
        {
            return dal.Selecionar(categoriaId);
        }
        public bool Excluir(int categoriaId)
        {
            return dal.Excluir(categoriaId);
        }
        public List<CategoriaInfo> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }
    }
}
