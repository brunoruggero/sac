namespace SAC
{
    partial class frmPagamentoCompra
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
            this.btLocalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.btPagar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFiscal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPagto = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(436, 64);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(138, 23);
            this.btLocalizar.TabIndex = 0;
            this.btLocalizar.Text = "Localizar Compra";
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Compra:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(118, 24);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(350, 20);
            this.txtFornecedor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data da Compra:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(251, 66);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(179, 20);
            this.txtValor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor:";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(12, 119);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(562, 245);
            this.dgvParcelas.TabIndex = 9;
            this.dgvParcelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcelas_CellClick);
            // 
            // dtData
            // 
            this.dtData.Enabled = false;
            this.dtData.Location = new System.Drawing.Point(12, 66);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(233, 20);
            this.dtData.TabIndex = 12;
            // 
            // btPagar
            // 
            this.btPagar.Enabled = false;
            this.btPagar.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagar.Image = global::SAC.Properties.Resources.pagar1;
            this.btPagar.Location = new System.Drawing.Point(501, 370);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(70, 70);
            this.btPagar.TabIndex = 11;
            this.btPagar.Text = "Pagar";
            this.btPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(565, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "_________________________________________________________________________________" +
    "____________";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Parcelas:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SAC.Properties.Resources.print1;
            this.button1.Location = new System.Drawing.Point(426, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 22;
            this.button1.Text = "Imprimir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtFiscal
            // 
            this.txtFiscal.Enabled = false;
            this.txtFiscal.Location = new System.Drawing.Point(474, 24);
            this.txtFiscal.Name = "txtFiscal";
            this.txtFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtFiscal.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nota Fiscal:";
            // 
            // dtpPagto
            // 
            this.dtpPagto.Location = new System.Drawing.Point(12, 386);
            this.dtpPagto.Name = "dtpPagto";
            this.dtpPagto.Size = new System.Drawing.Size(233, 20);
            this.dtpPagto.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Data do Pagamento:";
            // 
            // frmPagamentoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.dtpPagto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFiscal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.btPagar);
            this.Controls.Add(this.dgvParcelas);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagamentoCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...: Pagamento - Compras :...";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFiscal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPagto;
        private System.Windows.Forms.Label label7;
    }
}