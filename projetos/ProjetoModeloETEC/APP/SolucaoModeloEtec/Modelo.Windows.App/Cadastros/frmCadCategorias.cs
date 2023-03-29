using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Windows.App.Base;
using Modelo.Helper;
using Modelo.ORM.BLL;
using Modelo.ORM.INFO;

namespace Modelo.Windows.App.Cadastros
{
    public partial class frmCadCategorias : frmBaseCadastro
    {
        CategoriaBll categoriaBll = new CategoriaBll();
        public frmCadCategorias()
        {
            InitializeComponent();
        }

        private void frmCadCategorias_Load(object sender, EventArgs e)
        {
         
            
        }

        public override void frmBaseCadastro_Load(object sender, EventArgs e)
        {
            SetaTituloForm("Cadastro das categorias");
            gridLista.DataSource = categoriaBll.SelecionarTodos();
            base.frmBaseCadastro_Load(sender, e);
        }

        public override void btnAdicionar_Click(object sender, EventArgs e)
        {
            base.btnAdicionar_Click(sender, e);
        }

        public override void btnEditar_Click(object sender, EventArgs e)
        {
            base.btnEditar_Click(sender, e);
        }

        public override void btnExcluir_Click(object sender, EventArgs e)
        {
            base.btnExcluir_Click(sender, e);
        }

        public override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

        public override void btnConfirmar_Click(object sender, EventArgs e)
        {
            base.btnConfirmar_Click(sender, e);
        }

        public override void gridLista_SelectionChanged(object sender, EventArgs e)
        {
            base.gridLista_SelectionChanged(sender, e);
        }

    }
}
