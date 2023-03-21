using Dominio;
using System;
using System.Collections.Generic;

namespace Repositorio
{
    public class ICategoriaRepository
    {
        void Adicionar(Categoria categoria);
        void Salvar(Categoria categoria);
        IEnumerable<Categoria> ListarTodos();
        Categoria BuscarPor(int idCategoria);
    }
}
