using Dominio;
using System;
using System.Collections.Generic;

namespace Repositorio
{
    public class IProdutoRepository
    {
        public interface IProdutoRepository
        {
            void Adicionar(Produto produto);
            void Salvar(Produto produto);
            IEnumerable<Produto> ListarTodos();
            Produto BuscarPor(int idProduto);
        }
}
