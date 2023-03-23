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
    public class CategoriaDal
    {
        public IDbConnection conexao { get; set; }

        public CategoriaDal()
        {
            conexao = new SqlConnection(
                ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
        }

        const string sqlInserir = @"insert into CATEGORIA (Descricao,isAtivo) values (@Descricao, @IsAtivo)
                                                select * from CATEGORIA where categoriaid = scope_identity()";

        const string sqlAtualizar = @"update CATEGORIA set Descricao = @Descricao,
                                                            isAtivo = @isAtivo where categoriaid = @categoriaid";

        const string sqlExcluir = @"delete from CATEGORIA where categoriaid = @Categoriaid";

        const string sqlSelecionar = @"select * from CATEGORIA where categoriaid = @Categoriaid";

        const string sqlSelecionarTodos = @"select * from CATEGORIA order by Descricao";


        public CategoriaInfo Salvar(CategoriaInfo categinfo)
        {
            if (categinfo.CategoriaId == 0)
            {
                return conexao.Query<CategoriaInfo>(sqlInserir, categinfo).SingleOrDefault();
            }
            else
            {
                conexao.Query<CategoriaInfo>(sqlAtualizar, categinfo);
                return categinfo;
            }
        }

        public bool Excluir (int categId)
        {
            return conexao.Execute(sqlExcluir, new {CategoriaId = categId}) > 0;
        }

        public CategoriaInfo Selecionar(int categId)
        {
            return conexao.Query<CategoriaInfo>(sqlSelecionar, new { CategoriaId = categId }).SingleOrDefault();
        }

        public List<CategoriaInfo> SelecionarTodos()
        {
            return conexao.Query<CategoriaInfo>(sqlSelecionarTodos, null).ToList();
        }
    }
}
