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
            this.lblCod = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.pnlDados.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
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
            this.pnlCadastro.Controls.Add(this.chkAtivo);
            this.pnlCadastro.Controls.Add(this.txtDescricao);
            this.pnlCadastro.Controls.Add(this.lblCod);
            this.pnlCadastro.Location = new System.Drawing.Point(4, 55);
            this.pnlCadastro.Size = new System.Drawing.Size(480, 501);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(6, 94);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(35, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "label1";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 110);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(6, 136);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(80, 17);
            this.chkAtivo.TabIndex = 2;
            this.chkAtivo.Text = "checkBox1";
            this.chkAtivo.UseVisualStyleBackColor = true;
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
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox chkAtivo;
        private TextBox txtDescricao;
        private Label lblCod;
    }
}