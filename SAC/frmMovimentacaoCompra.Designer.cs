namespace SAC
{
    partial class frmMovimentacaoCompra
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
            this.txtComCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.dtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.cbTpgto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDataIni = new System.Windows.Forms.DateTimePicker();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.btLocFor = new System.Windows.Forms.Button();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.btLocProd = new System.Windows.Forms.Button();
            this.lbProduto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btAddProd = new System.Windows.Forms.Button();
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btCancelarParcela = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btSalvarParcela = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label19);
            this.pnDados.Controls.Add(this.btAddProd);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.lbProduto);
            this.pnDados.Controls.Add(this.btLocProd);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.lbFornecedor);
            this.pnDados.Controls.Add(this.btLocFor);
            this.pnDados.Controls.Add(this.txtForCod);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.dtDataIni);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.cbNParcelas);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbTpgto);
            this.pnDados.Controls.Add(this.txtTotalCompra);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.dtDataCompra);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtComCod);
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
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtComCod
            // 
            this.txtComCod.Enabled = false;
            this.txtComCod.Location = new System.Drawing.Point(13, 28);
            this.txtComCod.Name = "txtComCod";
            this.txtComCod.Size = new System.Drawing.Size(81, 20);
            this.txtComCod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota Fiscal:";
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Location = new System.Drawing.Point(100, 28);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtNFiscal.TabIndex = 3;
            this.txtNFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNFiscal_KeyPress);
            // 
            // dtDataCompra
            // 
            this.dtDataCompra.Location = new System.Drawing.Point(206, 28);
            this.dtDataCompra.Name = "dtDataCompra";
            this.dtDataCompra.Size = new System.Drawing.Size(127, 20);
            this.dtDataCompra.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(453, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Location = new System.Drawing.Point(453, 311);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCompra.TabIndex = 6;
            // 
            // cbTpgto
            // 
            this.cbTpgto.FormattingEnabled = true;
            this.cbTpgto.Location = new System.Drawing.Point(140, 310);
            this.cbTpgto.Name = "cbTpgto";
            this.cbTpgto.Size = new System.Drawing.Size(121, 21);
            this.cbTpgto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Pagamento:";
            // 
            // cbNParcelas
            // 
            this.cbNParcelas.FormattingEnabled = true;
            this.cbNParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNParcelas.Location = new System.Drawing.Point(13, 310);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(121, 21);
            this.cbNParcelas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parcelas:";
            // 
            // dtDataIni
            // 
            this.dtDataIni.Location = new System.Drawing.Point(266, 311);
            this.dtDataIni.Name = "dtDataIni";
            this.dtDataIni.Size = new System.Drawing.Size(181, 20);
            this.dtDataIni.TabIndex = 11;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.forNome,
            this.forQtde,
            this.provund,
            this.provTotal});
            this.dgvItens.Location = new System.Drawing.Point(13, 142);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(540, 150);
            this.dgvItens.TabIndex = 12;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // proCod
            // 
            this.proCod.HeaderText = "Código";
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            this.proCod.Width = 70;
            // 
            // forNome
            // 
            this.forNome.HeaderText = "Nome";
            this.forNome.Name = "forNome";
            this.forNome.ReadOnly = true;
            this.forNome.Width = 210;
            // 
            // forQtde
            // 
            this.forQtde.HeaderText = "Quantidade";
            this.forQtde.Name = "forQtde";
            this.forQtde.ReadOnly = true;
            this.forQtde.Width = 70;
            // 
            // provund
            // 
            this.provund.HeaderText = "Valor Unitário";
            this.provund.Name = "provund";
            this.provund.ReadOnly = true;
            this.provund.Width = 70;
            // 
            // provTotal
            // 
            this.provTotal.HeaderText = "Valor Total";
            this.provTotal.Name = "provTotal";
            this.provTotal.ReadOnly = true;
            this.provTotal.Width = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data Inicial do Pagamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fornecedor:";
            // 
            // txtForCod
            // 
            this.txtForCod.Location = new System.Drawing.Point(339, 28);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(81, 20);
            this.txtForCod.TabIndex = 15;
            this.txtForCod.Leave += new System.EventHandler(this.txtForCod_Leave);
            // 
            // btLocFor
            // 
            this.btLocFor.Location = new System.Drawing.Point(426, 26);
            this.btLocFor.Name = "btLocFor";
            this.btLocFor.Size = new System.Drawing.Size(127, 23);
            this.btLocFor.TabIndex = 16;
            this.btLocFor.Text = "Localizar";
            this.btLocFor.UseVisualStyleBackColor = true;
            this.btLocFor.Click += new System.EventHandler(this.btLocFor_Click);
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Location = new System.Drawing.Point(399, 12);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(158, 13);
            this.lbFornecedor.TabIndex = 17;
            this.lbFornecedor.Text = "Informe o código do Fornecedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data de Compra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(547, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "_________________________________________________________________________________" +
    "_________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Código do Produto:";
            // 
            // txtProCod
            // 
            this.txtProCod.Location = new System.Drawing.Point(13, 88);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(100, 20);
            this.txtProCod.TabIndex = 21;
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // btLocProd
            // 
            this.btLocProd.Location = new System.Drawing.Point(119, 87);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(127, 23);
            this.btLocProd.TabIndex = 22;
            this.btLocProd.Text = "Localizar";
            this.btLocProd.UseVisualStyleBackColor = true;
            this.btLocProd.Click += new System.EventHandler(this.btLocProd_Click);
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(105, 72);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(141, 13);
            this.lbProduto.TabIndex = 23;
            this.lbProduto.Text = "Informe o código do Produto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(252, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Quantidade:";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(252, 88);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 25;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(358, 88);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(358, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Valor Unitário:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Itens da Compra:";
            // 
            // btAddProd
            // 
            this.btAddProd.Location = new System.Drawing.Point(464, 87);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(89, 23);
            this.btAddProd.TabIndex = 29;
            this.btAddProd.Text = "Adicionar";
            this.btAddProd.UseVisualStyleBackColor = true;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFinalizaCompra.Controls.Add(this.label18);
            this.pnFinalizaCompra.Controls.Add(this.lbTotal);
            this.pnFinalizaCompra.Controls.Add(this.label17);
            this.pnFinalizaCompra.Controls.Add(this.btCancelarParcela);
            this.pnFinalizaCompra.Controls.Add(this.label16);
            this.pnFinalizaCompra.Controls.Add(this.btSalvarParcela);
            this.pnFinalizaCompra.Controls.Add(this.label14);
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Controls.Add(this.label15);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(12, 12);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(563, 426);
            this.pnFinalizaCompra.TabIndex = 2;
            this.pnFinalizaCompra.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(475, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "R$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Red;
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(507, 320);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 32;
            this.lbTotal.Text = "0000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(381, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Total da Compra:";
            // 
            // btCancelarParcela
            // 
            this.btCancelarParcela.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarParcela.Image = global::SAC.Properties.Resources.if_Close_64_32062;
            this.btCancelarParcela.Location = new System.Drawing.Point(480, 350);
            this.btCancelarParcela.Name = "btCancelarParcela";
            this.btCancelarParcela.Size = new System.Drawing.Size(70, 70);
            this.btCancelarParcela.TabIndex = 7;
            this.btCancelarParcela.Text = "Cancelar";
            this.btCancelarParcela.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelarParcela.UseVisualStyleBackColor = true;
            this.btCancelarParcela.Click += new System.EventHandler(this.btCancelarParcela_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Informações do Parcelamento:";
            // 
            // btSalvarParcela
            // 
            this.btSalvarParcela.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarParcela.Image = global::SAC.Properties.Resources.if_6_67719;
            this.btSalvarParcela.Location = new System.Drawing.Point(404, 350);
            this.btSalvarParcela.Name = "btSalvarParcela";
            this.btSalvarParcela.Size = new System.Drawing.Size(71, 70);
            this.btSalvarParcela.TabIndex = 6;
            this.btSalvarParcela.Text = "Finalizar";
            this.btSalvarParcela.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvarParcela.UseVisualStyleBackColor = true;
            this.btSalvarParcela.Click += new System.EventHandler(this.btSalvarParcela_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Dados do Pagamento";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            this.dgvParcelas.Location = new System.Drawing.Point(11, 57);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.Size = new System.Drawing.Size(539, 252);
            this.dgvParcelas.TabIndex = 0;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor da Parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            // 
            // pco_datavecto
            // 
            this.pco_datavecto.HeaderText = "Data do Vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            this.pco_datavecto.Width = 200;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(547, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "_________________________________________________________________________________" +
    "_________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(489, 296);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "R$";
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(585, 449);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Name = "frmMovimentacaoCompra";
            this.Text = "...: Movimentação - Formulário de Compra :...";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pnFinalizaCompra, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.Button btLocFor;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DateTimePicker dtDataIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTpgto;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataCompra;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComCod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAddProd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn provund;
        private System.Windows.Forms.DataGridViewTextBoxColumn provTotal;
        private System.Windows.Forms.Panel pnFinalizaCompra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Button btCancelarParcela;
        protected System.Windows.Forms.Button btSalvarParcela;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.Label label19;
    }
}
