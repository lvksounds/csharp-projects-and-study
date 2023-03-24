using Modelo.ORM.DAL;
using Modelo.ORM.INFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.BLL
{
    public class ProdutoBll
    {
        ProdutoDal dal = new ProdutoDal();

        public ProdutoInfo Salvar(ProdutoInfo obj)
        {
            return dal.Salvar(obj);
        }
        public ProdutoInfo Selecionar(int categoriaId)
        {
            return dal.Selecionar(categoriaId);
        }
        public bool Excluir(int categoriaId)
        {
            return dal.Excluir(categoriaId);
        }
        public List<ProdutoInfo> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }
    }
}
