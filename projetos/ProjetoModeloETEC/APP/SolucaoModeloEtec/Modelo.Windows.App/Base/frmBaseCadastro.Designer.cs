namespace Modelo.Windows.App.Base
{
    partial class frmBaseCadastro
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textLocalizar = new System.Windows.Forms.TextBox();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.gridListaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.pnlAcoes = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.pnlDados.SuspendLayout();
            this.pnlAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLocalizar
            // 
            this.textLocalizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.textLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLocalizar.Location = new System.Drawing.Point(5, 5);
            this.textLocalizar.Name = "textLocalizar";
            this.textLocalizar.Size = new System.Drawing.Size(270, 26);
            this.textLocalizar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textLocalizar, "Localizar");
            // 
            // pnlLista
            // 
            this.pnlLista.Controls.Add(this.gridLista);
            this.pnlLista.Controls.Add(this.textLocalizar);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLista.Location = new System.Drawing.Point(0, 0);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLista.Size = new System.Drawing.Size(280, 561);
            this.pnlLista.TabIndex = 0;
            // 
            // gridLista
            // 
            this.gridLista.AllowUserToAddRows = false;
            this.gridLista.AllowUserToDeleteRows = false;
            this.gridLista.AllowUserToResizeColumns = false;
            this.gridLista.AllowUserToResizeRows = false;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridListaDescricao});
            this.gridLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLista.Location = new System.Drawing.Point(5, 31);
            this.gridLista.MultiSelect = false;
            this.gridLista.Name = "gridLista";
            this.gridLista.ReadOnly = true;
            this.gridLista.RowTemplate.Height = 25;
            this.gridLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLista.Size = new System.Drawing.Size(270, 525);
            this.gridLista.TabIndex = 1;
            // 
            // gridListaDescricao
            // 
            this.gridListaDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gridListaDescricao.DataPropertyName = "DescPadrao";
            this.gridListaDescricao.HeaderText = "Descrição";
            this.gridListaDescricao.Name = "gridListaDescricao";
            this.gridListaDescricao.ReadOnly = true;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.pnlCadastro);
            this.pnlDados.Controls.Add(this.pnlAcoes);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(280, 0);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDados.Size = new System.Drawing.Size(504, 561);
            this.pnlDados.TabIndex = 1;
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastro.Location = new System.Drawing.Point(5, 56);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(494, 500);
            this.pnlCadastro.TabIndex = 1;
            // 
            // pnlAcoes
            // 
            this.pnlAcoes.Controls.Add(this.btnConfirmar);
            this.pnlAcoes.Controls.Add(this.btnCancelar);
            this.pnlAcoes.Controls.Add(this.btnExcluir);
            this.pnlAcoes.Controls.Add(this.btnEditar);
            this.pnlAcoes.Controls.Add(this.btnAdicionar);
            this.pnlAcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcoes.Location = new System.Drawing.Point(5, 5);
            this.pnlAcoes.Name = "pnlAcoes";
            this.pnlAcoes.Padding = new System.Windows.Forms.Padding(3);
            this.pnlAcoes.Size = new System.Drawing.Size(494, 51);
            this.pnlAcoes.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(401, 7);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 38);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(304, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(200, 7);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 38);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(101, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 38);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Green;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 7);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 38);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmBaseCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmBaseCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseCadastro";
            this.Load += new System.EventHandler(this.frmBaseCadastro_Load);
            this.pnlLista.ResumeLayout(false);
            this.pnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.pnlDados.ResumeLayout(false);
            this.pnlAcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ToolTip toolTip1;
        protected Panel pnlLista;
        private TextBox textLocalizar;
        protected Panel pnlDados;
        private DataGridViewTextBoxColumn gridListaDescricao;
        protected Panel pnlCadastro;
        private Panel pnlAcoes;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnConfirmar;
        private Button btnCancelar;
        public DataGridView gridLista;
    }
}