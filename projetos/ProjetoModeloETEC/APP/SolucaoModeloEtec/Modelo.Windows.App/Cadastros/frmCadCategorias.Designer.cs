namespace Modelo.Windows.App.Cadastros
{
    partial class frmCadCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLista
            // 
            this.pnlLista.Padding = new System.Windows.Forms.Padding(4);
            this.pnlLista.Size = new System.Drawing.Size(240, 560);
            // 
            // pnlDados
            // 
            this.pnlDados.Location = new System.Drawing.Point(240, 0);
            this.pnlDados.Padding = new System.Windows.Forms.Padding(4);
            this.pnlDados.Size = new System.Drawing.Size(488, 560);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Location = new System.Drawing.Point(4, 55);
            this.pnlCadastro.Size = new System.Drawing.Size(480, 501);
            // 
            // frmCadCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 560);
            this.Name = "frmCadCategorias";
            this.Text = "frmCadCategorias";
            this.Load += new System.EventHandler(this.frmCadCategorias_Load);
            this.pnlDados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}