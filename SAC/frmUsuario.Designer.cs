namespace SAC
{
    partial class frmUsuario
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btRmFoto = new System.Windows.Forms.Button();
            this.btLoFoto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.cbNivelAcesso);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.btRmFoto);
            this.pnDados.Controls.Add(this.btLoFoto);
            this.pnDados.Controls.Add(this.pbFoto);
            this.pnDados.Controls.Add(this.txtSenha);
            this.pnDados.Controls.Add(this.txtUsuario);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Size = new System.Drawing.Size(519, 342);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(35, 3);
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(111, 3);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(187, 3);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(263, 3);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(339, 3);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(415, 3);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Size = new System.Drawing.Size(519, 77);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Foto:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(10, 107);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(204, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(10, 146);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(204, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(242, 32);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(260, 235);
            this.pbFoto.TabIndex = 9;
            this.pbFoto.TabStop = false;
            // 
            // btRmFoto
            // 
            this.btRmFoto.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRmFoto.Image = global::SAC.Properties.Resources.removerFoto;
            this.btRmFoto.Location = new System.Drawing.Point(373, 273);
            this.btRmFoto.Name = "btRmFoto";
            this.btRmFoto.Size = new System.Drawing.Size(129, 64);
            this.btRmFoto.TabIndex = 23;
            this.btRmFoto.Text = "Remover";
            this.btRmFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRmFoto.UseVisualStyleBackColor = true;
            this.btRmFoto.Click += new System.EventHandler(this.btRmFoto_Click);
            // 
            // btLoFoto
            // 
            this.btLoFoto.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoFoto.Image = global::SAC.Properties.Resources.novaFoto;
            this.btLoFoto.Location = new System.Drawing.Point(241, 273);
            this.btLoFoto.Name = "btLoFoto";
            this.btLoFoto.Size = new System.Drawing.Size(128, 64);
            this.btLoFoto.TabIndex = 22;
            this.btLoFoto.Text = "Carregar";
            this.btLoFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLoFoto.UseVisualStyleBackColor = true;
            this.btLoFoto.Click += new System.EventHandler(this.btLoFoto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nível de Acesso:";
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Items.AddRange(new object[] {
            "Selecione o tipo do usuário!",
            "Administrador",
            "Usuario",
            "Gerente",
            "Supervisor",
            "Recursos Humanos"});
            this.cbNivelAcesso.Location = new System.Drawing.Point(10, 185);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(204, 21);
            this.cbNivelAcesso.TabIndex = 25;
            this.cbNivelAcesso.SelectedIndexChanged += new System.EventHandler(this.cbNivelAcesso_SelectedIndexChanged);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(544, 449);
            this.Name = "frmUsuario";
            this.Text = "...: Cadastro de Usuários :...";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRmFoto;
        private System.Windows.Forms.Button btLoFoto;
        private System.Windows.Forms.ComboBox cbNivelAcesso;
        private System.Windows.Forms.Label label6;
    }
}
