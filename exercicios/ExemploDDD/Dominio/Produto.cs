using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Produto
    {
        // Propriedades
        public int Id_Produto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public int Categoria { get; set; }

        // Métodos
        public bool PodeVender()
        {
            return Quantidade > 0;
        }

        public void Vendeu()
        {
            if (PodeVender())
                Quantidade--;
        }

        public void Comprou(int qtde)
        {
            Quantidade += qtde;
        }
    }
}
