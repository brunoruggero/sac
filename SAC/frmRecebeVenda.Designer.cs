namespace SAC
{
    partial class frmRecebeVenda
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
            this.txtFiscal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpRecebimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btImprimir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btReceber = new System.Windows.Forms.Button();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiscal
            // 
            this.txtFiscal.Enabled = false;
            this.txtFiscal.Location = new System.Drawing.Point(476, 25);
            this.txtFiscal.Name = "txtFiscal";
            this.txtFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtFiscal.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Nota Fiscal:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(120, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(350, 20);
            this.txtCliente.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Cliente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(14, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Código Venda:";
            // 
            // dtData
            // 
            this.dtData.Enabled = false;
            this.dtData.Location = new System.Drawing.Point(13, 67);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(233, 20);
            this.dtData.TabIndex = 54;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(252, 67);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(179, 20);
            this.txtValor.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Data da Venda:";
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(437, 65);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(138, 23);
            this.btLocalizar.TabIndex = 50;
            this.btLocalizar.Text = "Localizar Venda";
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(565, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "_________________________________________________________________________________" +
    "____________";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpRecebimento
            // 
            this.dtpRecebimento.Location = new System.Drawing.Point(14, 385);
            this.dtpRecebimento.Name = "dtpRecebimento";
            this.dtpRecebimento.Size = new System.Drawing.Size(233, 20);
            this.dtpRecebimento.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Data do Recebimento:";
            // 
            // btImprimir
            // 
            this.btImprimir.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Image = global::SAC.Properties.Resources.print1;
            this.btImprimir.Location = new System.Drawing.Point(428, 369);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(70, 70);
            this.btImprimir.TabIndex = 60;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Parcelas:";
            // 
            // btReceber
            // 
            this.btReceber.Enabled = false;
            this.btReceber.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReceber.Image = global::SAC.Properties.Resources.pagar1;
            this.btReceber.Location = new System.Drawing.Point(503, 369);
            this.btReceber.Name = "btReceber";
            this.btReceber.Size = new System.Drawing.Size(70, 70);
            this.btReceber.TabIndex = 58;
            this.btReceber.Text = "Receber";
            this.btReceber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReceber.UseVisualStyleBackColor = true;
            this.btReceber.Click += new System.EventHandler(this.btReceber_Click);
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(14, 118);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(562, 245);
            this.dgvParcelas.TabIndex = 56;
            this.dgvParcelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcelas_CellClick);
            // 
            // frmRecebeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.dtpRecebimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btReceber);
            this.Controls.Add(this.dgvParcelas);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFiscal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecebeVenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...: Recebimento - Venda :...";
            this.Load += new System.EventHandler(this.frmRecebeVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiscal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpRecebimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btReceber;
        private System.Windows.Forms.DataGridView dgvParcelas;
    }
}