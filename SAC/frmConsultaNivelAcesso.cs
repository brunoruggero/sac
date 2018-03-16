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
    public partial class frmConsultaNivelAcesso : Form
    {

        public int codigo = 0;

        public frmConsultaNivelAcesso()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void frmConsultaNivelAcesso_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Nível de Acesso";
            dgvDados.Columns[1].Width = 468;
        }
    }
}
