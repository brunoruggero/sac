namespace SAC
{
    partial class frmLoading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.pbcarrega = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCarregar = new System.Windows.Forms.Label();
            this.txtVLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcarrega
            // 
            this.pbcarrega.Location = new System.Drawing.Point(-1, 345);
            this.pbcarrega.Name = "pbcarrega";
            this.pbcarrega.Size = new System.Drawing.Size(634, 23);
            this.pbcarrega.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAC.Properties.Resources.Ellipsis_1_5s_20px;
            this.pictureBox1.Location = new System.Drawing.Point(132, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbCarregar
            // 
            this.lbCarregar.AutoSize = true;
            this.lbCarregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbCarregar.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarregar.ForeColor = System.Drawing.Color.Black;
            this.lbCarregar.Location = new System.Drawing.Point(3, 325);
            this.lbCarregar.Name = "lbCarregar";
            this.lbCarregar.Size = new System.Drawing.Size(134, 18);
            this.lbCarregar.TabIndex = 2;
            this.lbCarregar.Text = "Carregando Sistema ";
            // 
            // txtVLoading
            // 
            this.txtVLoading.AutoSize = true;
            this.txtVLoading.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVLoading.Location = new System.Drawing.Point(548, 9);
            this.txtVLoading.Name = "txtVLoading";
            this.txtVLoading.Size = new System.Drawing.Size(40, 16);
            this.txtVLoading.TabIndex = 3;
            this.txtVLoading.Text = "label1";
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::SAC.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(632, 369);
            this.ControlBox = false;
            this.Controls.Add(this.txtVLoading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCarregar);
            this.Controls.Add(this.pbcarrega);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pbcarrega;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCarregar;
        private System.Windows.Forms.Label txtVLoading;
    }
}