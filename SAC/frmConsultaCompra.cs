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
    public partial class frmConsultaCompra : Form
    {
        public int codigo = 0;

        public frmConsultaCompra()
        {
            InitializeComponent();
        }

        private void FrmConsultaCompra_Load(object sender, EventArgs e)
        {
            rbTodas_CheckedChanged(sender, e);
        }

        public void ExecutaConsulta(int op)
        {
            //op = 1 -> consultar todas as compras
            //op = 2 -> consultar por fornecedor
            //op = 3 -> consultar por data da compra
            //op = 4 -> consultar por parcelas em aberto

        }

        public void AtualizaCabecalhoDGCompra()
        {
            //btLocFornecedor_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Data da Compra";
            dgvDados.Columns[1].Width = 110;
            dgvDados.Columns[2].HeaderText = "Nota Fiscal";
            dgvDados.Columns[2].Width = 110;
            dgvDados.Columns[3].HeaderText = "Parcelas";
            dgvDados.Columns[3].Width = 60;
            dgvDados.Columns[4].HeaderText = "Fornecedor";
            dgvDados.Columns[4].Width = 90;
            dgvDados.Columns[5].HeaderText = "Status";
            dgvDados.Columns[5].Width = 90;
            dgvDados.Columns[6].HeaderText = "Código Fornecedor";
            dgvDados.Columns[6].Width = 90;
            dgvDados.Columns[7].HeaderText = "Código Tipo de Pagamento";
            dgvDados.Columns[7].Width = 90;
            dgvDados.Columns[8].HeaderText = "Total";
            dgvDados.Columns[8].Width = 60;

            dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;
            
        }

        private void btLocFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                lbForNome.Text = modelo.ForNome;
                BLLCompra bllCompra = new BLLCompra(cx);
                dgvDados.DataSource = bllCompra.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoDGCompra();
            }
            else
            {
                txtForCod.Text = "";
                lbForNome.Text = "Localize o Fornecedor";
            }
                
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            //ocultar paineis
            pFornecedor.Visible = false;
            pData.Visible = false;

            //limpar os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;

            if(rbTodas.Checked == true)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLCompra bllCompra = new BLLCompra(cx);
                dgvDados.DataSource = bllCompra.LocalizarTodas();
                this.AtualizaCabecalhoDGCompra();
            }

            if (rbFornecedor.Checked == true)
            {
                pFornecedor.Visible = true;
            }

            if (rbData.Checked == true)
            {
                pData.Visible = true;
            }

            if (rbParcelas.Checked == true)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLCompra bllCompra = new BLLCompra(cx);
                dgvDados.DataSource = bllCompra.LocalizarParcelasAberto();
                this.AtualizaCabecalhoDGCompra();
            }
        }

        private void btLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dateTimePicker1.Value;
            DateTime dtfim = dateTimePicker2.Value;
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLCompra bllCompra = new BLLCompra(cx);
            dgvDados.DataSource = bllCompra.Localizar(dtini, dtfim);
            this.AtualizaCabecalhoDGCompra();
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
            catch
            {

            }



        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                //itens da compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                //parcelas da compra
                BLLParcelasCompra bllParcelas = new BLLParcelasCompra(cx);
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
    }
}
