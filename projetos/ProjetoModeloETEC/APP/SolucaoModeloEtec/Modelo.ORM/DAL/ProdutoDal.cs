using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using Dapper;

using Modelo.ORM.INFO;

namespace Modelo.ORM.DAL
{
    public class ProdutoDal
    {
        public IDbConnection conexao { get; set; }

        public ProdutoDal()
        {
            conexao = new SqlConnection(
                 ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
        }

        const string sqlInserir = @"insert into Produto 
                                    (
                                     Descricao, Unidade, ValorCusto, PorcentagemLucro,
                                     ValorVenda1, ValorVenda2, ValorVenda3, ValorVenda4, 
                                     IsPromocao, IsForaDeLinha, IsPesavel, Marca, Modelo
                                     Referencia, CodigoBarra, IsPermiteDesconto, DescontoMAximo,
                                     EstoqueAtual, EstoqueMinimo, EstoqueMaximo, BalancaSetor, BalancaDiasValidade, BalancaaReceita,
                                     IsAtivo, Foto
                                     ) 
                                     values 
                                     (
                                     @Descricao, @Unidade, @ValorCusto, @PorcentagemLucro,
                                     @ValorVenda1, @ValorVenda2, @ValorVenda3, @ValorVenda4, 
                                     @IsPromocao, @IsForaDeLinha, @IsPesavel, @Marca, @Modelo
                                     @Referencia, @CodigoBarra, @IsPermiteDesconto, @DescontoMAximo,
                                     @EstoqueAtual, @EstoqueMinimo, @EstoqueMaximo, @BalancaSetor, @BalancaDiasValidade, @BalancaaReceita,
                                     @IsAtivo, @Foto
                                     )
                                                select * from Produto where ProdutoID = scope_identity()";

        const string sqlAtualizar = @"update PRODUTO set Descricao = @Descricao,
                                                            isAtivo = @isAtivo where ProdutoID = @ProdutoId";

        const string sqlExcluir = @"delete from Produto where ProdutoID = @ProdutoId";

        const string sqlSelecionar = @"select * from Produto where ProdutoID = @ProdutoId";
        
        const string sqlSelecionarTodos = @"select * from Produto order by ProdutoID";

        public ProdutoInfo Salvar(ProdutoInfo prodinfo)
        {
            if (prodinfo.ProdutoId == 0)
            {
                return conexao.Query<ProdutoInfo>(sqlInserir, prodinfo).SingleOrDefault();
            }
            else
            {
                conexao.Query<ProdutoInfo>(sqlAtualizar, prodinfo);
                return prodinfo;
            }
        }

        public bool Excluir(int prodinfo)
        {
            return conexao.Execute(sqlExcluir, new { ProdutoId = prodinfo }) > 0;
        }

        public ProdutoInfo Selecionar(int prodinfo)
        {
            return conexao.Query<ProdutoInfo>(sqlSelecionar, new { ProdutoId = prodinfo }).SingleOrDefault();
        }

        public List<ProdutoInfo> SelecionarTodos()
        {
            return conexao.Query<ProdutoInfo>(sqlSelecionarTodos, null).ToList();
        }
    }
}
