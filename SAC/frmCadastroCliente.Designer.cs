namespace SAC
{
    partial class frmCadastroCliente
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.lbRsocial = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.txtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.lbRGIE = new System.Windows.Forms.Label();
            this.txtRGIE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lbValorIncorreto);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.txtCelular);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtTelefone);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.txtRua);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtCep);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtRGIE);
            this.pnDados.Controls.Add(this.lbRGIE);
            this.pnDados.Controls.Add(this.txtCPFCNPJ);
            this.pnDados.Controls.Add(this.lbCPFCNPJ);
            this.pnDados.Controls.Add(this.txtRSocial);
            this.pnDados.Controls.Add(this.lbRsocial);
            this.pnDados.Controls.Add(this.groupBox1);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label1);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(22, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(19, 49);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(88, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome do Cliente:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(518, 20);
            this.txtNome.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbJuridica);
            this.groupBox1.Controls.Add(this.rbFisica);
            this.groupBox1.Location = new System.Drawing.Point(173, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do cliente";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(118, 20);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Pessoa Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(18, 20);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(92, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Pessoa Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // lbRsocial
            // 
            this.lbRsocial.AutoSize = true;
            this.lbRsocial.Location = new System.Drawing.Point(19, 90);
            this.lbRsocial.Name = "lbRsocial";
            this.lbRsocial.Size = new System.Drawing.Size(73, 13);
            this.lbRsocial.TabIndex = 5;
            this.lbRsocial.Text = "Razão Social:";
            this.lbRsocial.Visible = false;
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(22, 106);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(518, 20);
            this.txtRSocial.TabIndex = 6;
            this.txtRSocial.Visible = false;
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(19, 131);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(30, 13);
            this.lbCPFCNPJ.TabIndex = 7;
            this.lbCPFCNPJ.Text = "CPF:";
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(22, 147);
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(254, 20);
            this.txtCPFCNPJ.TabIndex = 8;
            this.txtCPFCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFCNPJ_KeyPress);
            this.txtCPFCNPJ.Leave += new System.EventHandler(this.txtCPFCNPJ_Leave);
            // 
            // lbRGIE
            // 
            this.lbRGIE.AutoSize = true;
            this.lbRGIE.Location = new System.Drawing.Point(283, 131);
            this.lbRGIE.Name = "lbRGIE";
            this.lbRGIE.Size = new System.Drawing.Size(26, 13);
            this.lbRGIE.TabIndex = 9;
            this.lbRGIE.Text = "RG:";
            // 
            // txtRGIE
            // 
            this.txtRGIE.Location = new System.Drawing.Point(286, 147);
            this.txtRGIE.Name = "txtRGIE";
            this.txtRGIE.Size = new System.Drawing.Size(254, 20);
            this.txtRGIE.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CEP:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(22, 188);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 12;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(130, 188);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(146, 20);
            this.txtEstado.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(286, 188);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(254, 20);
            this.txtCidade.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(22, 230);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(406, 20);
            this.txtRua.TabIndex = 18;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(440, 230);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Número:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(22, 271);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(330, 20);
            this.txtBairro.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(358, 271);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(182, 20);
            this.txtTelefone.TabIndex = 24;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(22, 312);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(182, 20);
            this.txtCelular.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Celular:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(210, 312);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "E-mail:";
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(55, 131);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(49, 13);
            this.lbValorIncorreto.TabIndex = 29;
            this.lbValorIncorreto.Text = "Incorreto";
            this.lbValorIncorreto.Visible = false;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Name = "frmCadastroCliente";
            this.Text = "...: Cadastro de Cliente :...";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.Label lbRsocial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRGIE;
        private System.Windows.Forms.Label lbRGIE;
        private System.Windows.Forms.TextBox txtCPFCNPJ;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbValorIncorreto;
    }
}
