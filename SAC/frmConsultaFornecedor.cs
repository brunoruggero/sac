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
    public partial class frmConsultaFornecedor : Form
    {

        public int codigo = 0;
        
        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCNPJ(txtValor.Text);
            }
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[1].Width = 70;
            dgvDados.Columns[2].HeaderText = "Razão Social";
            dgvDados.Columns[2].Width = 70;
            dgvDados.Columns[3].HeaderText = "IE";
            dgvDados.Columns[3].Width = 70;
            dgvDados.Columns[4].HeaderText = "CNPJ";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "CEP";
            dgvDados.Columns[5].Width = 70;
            dgvDados.Columns[6].HeaderText = "Endereço";
            dgvDados.Columns[6].Width = 70;
            dgvDados.Columns[7].HeaderText = "Bairro";
            dgvDados.Columns[7].Width = 70;
            dgvDados.Columns[8].HeaderText = "Telefone";
            dgvDados.Columns[8].Width = 70;
            dgvDados.Columns[9].HeaderText = "Celular";
            dgvDados.Columns[9].Width = 70;
            dgvDados.Columns[10].HeaderText = "E-mail";
            dgvDados.Columns[10].Width = 80;
            dgvDados.Columns[11].HeaderText = "Número";
            dgvDados.Columns[11].Width = 70;
            dgvDados.Columns[12].HeaderText = "Cidade";
            dgvDados.Columns[12].Width = 70;
            dgvDados.Columns[13].HeaderText = "Estado";
            dgvDados.Columns[13].Width = 70;

            /*
            //oculta colunas do datagrid
            dgvDados.Columns["pro_foto"].Visible = false;
            dgvDados.Columns["pro_valorpago"].Visible = false;
            dgvDados.Columns["cat_cod"].Visible = false;
            dgvDados.Columns["scat_cod"].Visible = false;
            dgvDados.Columns["umed_cod"].Visible = false;
            */
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
