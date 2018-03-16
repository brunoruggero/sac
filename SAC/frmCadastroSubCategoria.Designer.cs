namespace SAC
{
    partial class frmCadastroSubCategoria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCatCod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScatCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btAdicionar = new System.Windows.Forms.LinkLabel();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btAdicionar);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtScatCod);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.cbCatCod);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Size = new System.Drawing.Size(458, 176);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(3, 3);
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(79, 3);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(155, 3);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(231, 3);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(307, 3);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(383, 3);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(12, 194);
            this.pnBotoes.Size = new System.Drawing.Size(458, 77);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome SubCategoria:";
            // 
            // cbCatCod
            // 
            this.cbCatCod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCatCod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCatCod.FormattingEnabled = true;
            this.cbCatCod.Location = new System.Drawing.Point(28, 130);
            this.cbCatCod.Name = "cbCatCod";
            this.cbCatCod.Size = new System.Drawing.Size(228, 21);
            this.cbCatCod.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome Categoria:";
            // 
            // txtScatCod
            // 
            this.txtScatCod.Enabled = false;
            this.txtScatCod.Location = new System.Drawing.Point(28, 33);
            this.txtScatCod.Name = "txtScatCod";
            this.txtScatCod.Size = new System.Drawing.Size(100, 20);
            this.txtScatCod.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(28, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(399, 20);
            this.txtNome.TabIndex = 5;
            // 
            // btAdicionar
            // 
            this.btAdicionar.AutoSize = true;
            this.btAdicionar.Location = new System.Drawing.Point(259, 135);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(13, 13);
            this.btAdicionar.TabIndex = 7;
            this.btAdicionar.TabStop = true;
            this.btAdicionar.Text = "+";
            this.btAdicionar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btAdicionar_LinkClicked);
            // 
            // frmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(485, 279);
            this.Name = "frmCadastroSubCategoria";
            this.Text = "...: Cadastro de SubCategoria :...";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtScatCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCatCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btAdicionar;
    }
}
