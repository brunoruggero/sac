using BLL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAC
{
    public partial class frmConsultaBeneficio : Form
    {
        public frmConsultaBeneficio()
        {
            InitializeComponent();
        }

        public int codigo = 0;

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLBeneficio bll = new BLLBeneficio(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaBeneficio_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Benefício";
            dgvDados.Columns[1].Width = 600;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
