using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SAC
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
            this.txtVLoading.Text = String.Format("Versão: {0}", AssemblyVersion);
        }


        #region Acessório de Atributos do Assembly

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbcarrega.Value < 100)
            {
                pbcarrega.Value = pbcarrega.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                frmLogin carragaForm = new frmLogin();
                carragaForm.ShowDialog();
            }
        }

    }
}
