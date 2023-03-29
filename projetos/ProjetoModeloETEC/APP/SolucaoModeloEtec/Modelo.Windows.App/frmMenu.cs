using Modelo.Windows.App.Cadastros;
namespace Modelo.Windows.App
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCadCategorias frmCategoria = new frmCadCategorias())
            {
                frmCategoria.ShowDialog();
            }
        }
    }
}