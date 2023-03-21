using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProdutoRepository : IProdutoRepository
    {
        private DbDataContext _context = new DbDataContext();

        public ProdutoRepository(DbDataContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

        public void Salvar(Produto prod)
        {
            if (prod.Id_Produto == 0)
            {
                _context.Produtos.Add(prod);
            }
            else
            {
                Produto dado = _context.Produtos.Find(prod.Id_Produto);
                if (dado != null)
                {
                    dado.Nome = prod.Nome;
                    dado.Descricao = prod.Descricao;
                    dado.Preco = prod.Preco;
                    dado.Quantidade = prod.Quantidade;
                    dado.Categoria = prod.Categoria;
                }
            }
        }
        void Adicionar(Produto produto)
        { }
        IEnumerable<Produto> ListarTodos()
        { return new List<Produto>(); }
        Produto BuscarPor(int idProduto)
        {
            return;
        }
    }
}
