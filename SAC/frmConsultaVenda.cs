using BLL;
using DAO;
using Modelo;
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
    public partial class frmConsultaVenda : Form
    {
        public int codigo = 0;

        public frmConsultaVenda()
        {
            InitializeComponent();
        }

        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            rbTodas_CheckedChanged(sender, e);
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            //ocultar paineis
            pCliente.Visible = false;
            pData.Visible = false;

            //limpar os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;

            if (rbTodas.Checked == true)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLVenda bllVenda = new BLLVenda(cx);
                dgvDados.DataSource = bllVenda.LocalizarTodas();
                this.AtualizaCabecalhoDGVenda();
            }

            if (rbCliente.Checked == true)
            {
                pCliente.Visible = true;
            }

            if (rbData.Checked == true)
            {
                pData.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLVenda bllVenda = new BLLVenda(cx);
                dgvDados.DataSource = bllVenda.LocalizarParcelasAberto();
                this.AtualizaCabecalhoDGVenda();
            }
        }

        public void AtualizaCabecalhoDGVenda()
        {
            //btLocFornecedor_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Data da Venda";
            dgvDados.Columns[1].Width = 110;
            dgvDados.Columns[2].HeaderText = "Nota Fiscal";
            dgvDados.Columns[2].Width = 60;
            dgvDados.Columns[3].HeaderText = "Parcelas";
            dgvDados.Columns[3].Width = 60;
            dgvDados.Columns[4].HeaderText = "Cliente";
            dgvDados.Columns[4].Width = 90;
            dgvDados.Columns[5].HeaderText = "Status";
            dgvDados.Columns[5].Width = 60;
            dgvDados.Columns[6].HeaderText = "Código Cliente";
            dgvDados.Columns[6].Width = 90;
            dgvDados.Columns[7].HeaderText = "Tipo de Pagamento";
            dgvDados.Columns[7].Width = 90;
            dgvDados.Columns[8].HeaderText = "Vista/Prazo";
            dgvDados.Columns[8].Width = 60;
            dgvDados.Columns[9].HeaderText = "Total";
            dgvDados.Columns[9].Width = 65;

            //dgvDados.Columns[3].Visible = false;
            //dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;

        }

        public void AtualizaCabecalhoItensParcelas()
        {
            try
            {
                dgvItens.Columns[0].Visible = false;
                dgvItens.Columns[1].HeaderText = "Código do Item";
                dgvItens.Columns[2].HeaderText = "Código do Produto";
                dgvItens.Columns[3].HeaderText = "Nome do Produto";
                dgvItens.Columns[4].HeaderText = "Quantidade";
                dgvItens.Columns[5].HeaderText = "Valor";

                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Valor";
                dgvParcelas.Columns[2].HeaderText = "Data Pagamento";
                dgvParcelas.Columns[3].HeaderText = "Data Vencimento";
                dgvParcelas.Columns[4].Visible = false;
            }
            catch { }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                //itens da venda
                BLLItensVenda bllItens = new BLLItensVenda(cx);
                dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                //parcelas da venda
                BLLParcelasVenda bllParcelas = new BLLParcelasVenda(cx);
                dgvParcelas.DataSource = bllParcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                this.AtualizaCabecalhoItensParcelas();
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btLocCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                lbCliNome.Text = modelo.CliNome;
                BLLVenda bllVenda = new BLLVenda(cx);
                dgvDados.DataSource = bllVenda.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoDGVenda();
            }
            else
            {
                txtCliCod.Text = "";
                lbCliNome.Text = "Localize o Cliente";
            }
        }

        private void btLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dateTimePicker1.Value;
            DateTime dtfim = dateTimePicker2.Value;
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLVenda bllVenda = new BLLVenda(cx);
            dgvDados.DataSource = bllVenda.Localizar(dtini, dtfim);
            this.AtualizaCabecalhoDGVenda();
        }
    }
}
