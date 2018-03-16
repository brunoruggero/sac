namespace SAC
{
    partial class frmBackupBanco
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
            this.btBackup = new System.Windows.Forms.Button();
            this.btRestaura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBackup
            // 
            this.btBackup.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackup.Location = new System.Drawing.Point(12, 257);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(270, 48);
            this.btBackup.TabIndex = 0;
            this.btBackup.Text = "Efetuar Backup";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btRestaura
            // 
            this.btRestaura.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaura.Location = new System.Drawing.Point(12, 307);
            this.btRestaura.Name = "btRestaura";
            this.btRestaura.Size = new System.Drawing.Size(270, 48);
            this.btRestaura.TabIndex = 3;
            this.btRestaura.Text = "Restaurar Backup";
            this.btRestaura.UseVisualStyleBackColor = true;
            this.btRestaura.Click += new System.EventHandler(this.btRestaura_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAC.Properties.Resources.dadosBackup;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmBackupBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRestaura);
            this.Controls.Add(this.btBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupBanco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...: Backup Banco de Dados :...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btRestaura;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}