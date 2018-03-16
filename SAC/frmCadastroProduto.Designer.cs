namespace SAC
{
    partial class frmCadastroProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUnd = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.btLoFoto = new System.Windows.Forms.Button();
            this.btRmFoto = new System.Windows.Forms.Button();
            this.btAddCategoria = new System.Windows.Forms.LinkLabel();
            this.btAddSubCategoria = new System.Windows.Forms.LinkLabel();
            this.btAddUnidadeMedida = new System.Windows.Forms.LinkLabel();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btAddUnidadeMedida);
            this.pnDados.Controls.Add(this.btAddSubCategoria);
            this.pnDados.Controls.Add(this.btAddCategoria);
            this.pnDados.Controls.Add(this.btRmFoto);
            this.pnDados.Controls.Add(this.btLoFoto);
            this.pnDados.Controls.Add(this.cbSubCategoria);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.cbUnd);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.pbFoto);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.label2);
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
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(270, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(10, 110);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(270, 98);
            this.txtDescricao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Pago:";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(10, 227);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(120, 20);
            this.txtValorPago.TabIndex = 7;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade:";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(10, 267);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(120, 20);
            this.txtQtde.TabIndex = 11;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            this.txtQtde.Leave += new System.EventHandler(this.txtQtde_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(10, 306);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(120, 21);
            this.cbCategoria.TabIndex = 17;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Foto:";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(295, 29);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(260, 235);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 13;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor de Venda:";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(154, 227);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(120, 20);
            this.txtValorVenda.TabIndex = 9;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Unidade de Medida:";
            // 
            // cbUnd
            // 
            this.cbUnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUnd.FormattingEnabled = true;
            this.cbUnd.Location = new System.Drawing.Point(154, 267);
            this.cbUnd.Name = "cbUnd";
            this.cbUnd.Size = new System.Drawing.Size(120, 21);
            this.cbUnd.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "SubCategoria:";
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(154, 306);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(120, 21);
            this.cbSubCategoria.TabIndex = 19;
            // 
            // btLoFoto
            // 
            this.btLoFoto.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoFoto.Image = global::SAC.Properties.Resources.novaFoto;
            this.btLoFoto.Location = new System.Drawing.Point(295, 269);
            this.btLoFoto.Name = "btLoFoto";
            this.btLoFoto.Size = new System.Drawing.Size(128, 66);
            this.btLoFoto.TabIndex = 20;
            this.btLoFoto.Text = "Carregar";
            this.btLoFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLoFoto.UseVisualStyleBackColor = true;
            this.btLoFoto.Click += new System.EventHandler(this.btLoFoto_Click);
            // 
            // btRmFoto
            // 
            this.btRmFoto.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRmFoto.Image = global::SAC.Properties.Resources.removerFoto;
            this.btRmFoto.Location = new System.Drawing.Point(427, 269);
            this.btRmFoto.Name = "btRmFoto";
            this.btRmFoto.Size = new System.Drawing.Size(129, 66);
            this.btRmFoto.TabIndex = 21;
            this.btRmFoto.Text = "Remover";
            this.btRmFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRmFoto.UseVisualStyleBackColor = true;
            this.btRmFoto.Click += new System.EventHandler(this.btRmFoto_Click);
            // 
            // btAddCategoria
            // 
            this.btAddCategoria.AutoSize = true;
            this.btAddCategoria.Location = new System.Drawing.Point(130, 311);
            this.btAddCategoria.Name = "btAddCategoria";
            this.btAddCategoria.Size = new System.Drawing.Size(13, 13);
            this.btAddCategoria.TabIndex = 22;
            this.btAddCategoria.TabStop = true;
            this.btAddCategoria.Text = "+";
            this.btAddCategoria.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btAddCategoria_LinkClicked);
            // 
            // btAddSubCategoria
            // 
            this.btAddSubCategoria.AutoSize = true;
            this.btAddSubCategoria.Location = new System.Drawing.Point(275, 311);
            this.btAddSubCategoria.Name = "btAddSubCategoria";
            this.btAddSubCategoria.Size = new System.Drawing.Size(13, 13);
            this.btAddSubCategoria.TabIndex = 23;
            this.btAddSubCategoria.TabStop = true;
            this.btAddSubCategoria.Text = "+";
            this.btAddSubCategoria.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btAddSubCategoria_LinkClicked);
            // 
            // btAddUnidadeMedida
            // 
            this.btAddUnidadeMedida.AutoSize = true;
            this.btAddUnidadeMedida.Location = new System.Drawing.Point(275, 273);
            this.btAddUnidadeMedida.Name = "btAddUnidadeMedida";
            this.btAddUnidadeMedida.Size = new System.Drawing.Size(13, 13);
            this.btAddUnidadeMedida.TabIndex = 24;
            this.btAddUnidadeMedida.TabStop = true;
            this.btAddUnidadeMedida.Text = "+";
            this.btAddUnidadeMedida.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btAddUnidadeMedida_LinkClicked);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Name = "frmCadastroProduto";
            this.Text = "...: Cadastro de Produto :...";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRmFoto;
        private System.Windows.Forms.Button btLoFoto;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbUnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btAddCategoria;
        private System.Windows.Forms.LinkLabel btAddSubCategoria;
        private System.Windows.Forms.LinkLabel btAddUnidadeMedida;
    }
}
