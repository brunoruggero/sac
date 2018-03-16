namespace SAC
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEntrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLogUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnEntrar);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Controls.Add(this.txtLogUsuario);
            this.panel2.Controls.Add(this.cbNivelAcesso);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(7, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 320);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Depth = 0;
            this.btnSair.Location = new System.Drawing.Point(165, 226);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.Primary = true;
            this.btnSair.Size = new System.Drawing.Size(94, 44);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Depth = 0;
            this.btnEntrar.Location = new System.Drawing.Point(61, 226);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = true;
            this.btnEntrar.Size = new System.Drawing.Size(94, 44);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(57, 102);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Senha:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(57, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Usuário:";
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSenha.Hint = "Informe sua senha";
            this.txtSenha.Location = new System.Drawing.Point(62, 124);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(199, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // txtLogUsuario
            // 
            this.txtLogUsuario.Depth = 0;
            this.txtLogUsuario.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLogUsuario.Hint = "Informe seu usuário";
            this.txtLogUsuario.Location = new System.Drawing.Point(61, 69);
            this.txtLogUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogUsuario.Name = "txtLogUsuario";
            this.txtLogUsuario.PasswordChar = '\0';
            this.txtLogUsuario.SelectedText = "";
            this.txtLogUsuario.SelectionLength = 0;
            this.txtLogUsuario.SelectionStart = 0;
            this.txtLogUsuario.Size = new System.Drawing.Size(199, 23);
            this.txtLogUsuario.TabIndex = 1;
            this.txtLogUsuario.UseSystemPasswordChar = false;
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelAcesso.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Items.AddRange(new object[] {
            "Selecione o nível de acesso!",
            "Administrador",
            "Usuario",
            "Gerente",
            "Supervisor",
            "Recursos Humanos"});
            this.cbNivelAcesso.Location = new System.Drawing.Point(61, 179);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(200, 27);
            this.cbNivelAcesso.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nível de Acesso:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(336, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 320);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SAC.Properties.Resources.Seguranca_desenho;
            this.pictureBox3.Location = new System.Drawing.Point(55, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAC.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SAC.Properties.Resources.acesso;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(654, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 384);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...: Acesso ao Sistema :...";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbNivelAcesso;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSair;
        private MaterialSkin.Controls.MaterialRaisedButton btnEntrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogUsuario;
    }
}