namespace SAC
{
    partial class frmConsultaVenda
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
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tpCompra = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpParcelas = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btLocData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCliNome = new System.Windows.Forms.Label();
            this.btLocCliente = new System.Windows.Forms.Button();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pCliente = new System.Windows.Forms.Panel();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbParcelas = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.pData = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tpCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tpItens.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tpParcelas.SuspendLayout();
            this.pCliente.SuspendLayout();
            this.pData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(6, 6);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(542, 253);
            this.dgvParcelas.TabIndex = 13;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(6, 6);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(542, 253);
            this.dgvItens.TabIndex = 13;
            // 
            // tpCompra
            // 
            this.tpCompra.Controls.Add(this.dgvDados);
            this.tpCompra.Location = new System.Drawing.Point(4, 22);
            this.tpCompra.Name = "tpCompra";
            this.tpCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompra.Size = new System.Drawing.Size(559, 265);
            this.tpCompra.TabIndex = 0;
            this.tpCompra.Text = "Vendas";
            this.tpCompra.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(6, 6);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(542, 253);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Location = new System.Drawing.Point(4, 22);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tpItens.Size = new System.Drawing.Size(559, 265);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens Venda";
            this.tpItens.UseVisualStyleBackColor = true;
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpCompra);
            this.tbcDados.Controls.Add(this.tpItens);
            this.tbcDados.Controls.Add(this.tpParcelas);
            this.tbcDados.Location = new System.Drawing.Point(10, 113);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(567, 291);
            this.tbcDados.TabIndex = 21;
            // 
            // tpParcelas
            // 
            this.tpParcelas.Controls.Add(this.dgvParcelas);
            this.tpParcelas.Location = new System.Drawing.Point(4, 22);
            this.tpParcelas.Name = "tpParcelas";
            this.tpParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tpParcelas.Size = new System.Drawing.Size(559, 265);
            this.tpParcelas.TabIndex = 2;
            this.tpParcelas.Text = "Parcelas Venda";
            this.tpParcelas.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btLocData
            // 
            this.btLocData.Location = new System.Drawing.Point(292, 19);
            this.btLocData.Name = "btLocData";
            this.btLocData.Size = new System.Drawing.Size(75, 23);
            this.btLocData.TabIndex = 2;
            this.btLocData.Text = "Localizar";
            this.btLocData.UseVisualStyleBackColor = true;
            this.btLocData.Click += new System.EventHandler(this.btLocData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Inicial:";
            // 
            // lbCliNome
            // 
            this.lbCliNome.AutoSize = true;
            this.lbCliNome.Location = new System.Drawing.Point(72, 4);
            this.lbCliNome.Name = "lbCliNome";
            this.lbCliNome.Size = new System.Drawing.Size(90, 13);
            this.lbCliNome.TabIndex = 3;
            this.lbCliNome.Text = "Localize o Cliente";
            // 
            // btLocCliente
            // 
            this.btLocCliente.Location = new System.Drawing.Point(109, 19);
            this.btLocCliente.Name = "btLocCliente";
            this.btLocCliente.Size = new System.Drawing.Size(75, 23);
            this.btLocCliente.TabIndex = 2;
            this.btLocCliente.Text = "Localizar";
            this.btLocCliente.UseVisualStyleBackColor = true;
            this.btLocCliente.Click += new System.EventHandler(this.btLocCliente_Click);
            // 
            // txtCliCod
            // 
            this.txtCliCod.Enabled = false;
            this.txtCliCod.Location = new System.Drawing.Point(5, 20);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(100, 20);
            this.txtCliCod.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(151, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // pCliente
            // 
            this.pCliente.Controls.Add(this.lbCliNome);
            this.pCliente.Controls.Add(this.btLocCliente);
            this.pCliente.Controls.Add(this.txtCliCod);
            this.pCliente.Controls.Add(this.label2);
            this.pCliente.Location = new System.Drawing.Point(10, 61);
            this.pCliente.Name = "pCliente";
            this.pCliente.Size = new System.Drawing.Size(189, 46);
            this.pCliente.TabIndex = 19;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(502, 21);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btLocalizar.TabIndex = 17;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(12, 22);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(108, 17);
            this.rbTodas.TabIndex = 3;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas as Vendas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // rbParcelas
            // 
            this.rbParcelas.AutoSize = true;
            this.rbParcelas.Location = new System.Drawing.Point(356, 22);
            this.rbParcelas.Name = "rbParcelas";
            this.rbParcelas.Size = new System.Drawing.Size(117, 17);
            this.rbParcelas.TabIndex = 2;
            this.rbParcelas.Text = "Parcelas em Aberto";
            this.rbParcelas.UseVisualStyleBackColor = true;
            this.rbParcelas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(230, 22);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(97, 17);
            this.rbData.TabIndex = 1;
            this.rbData.Text = "Data de Venda";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(141, 22);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // pData
            // 
            this.pData.Controls.Add(this.dateTimePicker2);
            this.pData.Controls.Add(this.label3);
            this.pData.Controls.Add(this.dateTimePicker1);
            this.pData.Controls.Add(this.btLocData);
            this.pData.Controls.Add(this.label4);
            this.pData.Location = new System.Drawing.Point(205, 61);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(371, 46);
            this.pData.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTodas);
            this.groupBox1.Controls.Add(this.rbParcelas);
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 54);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Consulta";
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 411);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.pCliente);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaVenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...: Consulta de Venda :...";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tpCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tpItens.ResumeLayout(false);
            this.tbcDados.ResumeLayout(false);
            this.tpParcelas.ResumeLayout(false);
            this.pCliente.ResumeLayout(false);
            this.pCliente.PerformLayout();
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TabPage tpCompra;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.TabControl tbcDados;
        private System.Windows.Forms.TabPage tpParcelas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btLocData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCliNome;
        private System.Windows.Forms.Button btLocCliente;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pCliente;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbParcelas;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}