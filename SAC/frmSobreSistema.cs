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
    public partial class frmSobreSistema : Form
    {
        public frmSobreSistema()
        {
            InitializeComponent();
            this.txtVersao.Text = String.Format("Versão: {0}", AssemblyVersion);
            this.txtCopy.Text = AssemblyCopyright;
        }

        #region Acessório de Atributos do Assembly

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSobreSistema_Load(object sender, EventArgs e)
        {

        }
    }
}
