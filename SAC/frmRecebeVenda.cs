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
    public partial class frmRecebeVenda : Form
    {
        public frmRecebeVenda()
        {
            InitializeComponent();
        }

        private void frmRecebeVenda_Load(object sender, EventArgs e)
        {

        }

        public int pveCod = 0;

        //limpa tela
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtCliente.Clear();
            txtFiscal.Clear();
            txtValor.Clear();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            btReceber.Enabled = false;
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                txtCodigo.Text = modelo.VenCod.ToString();
                txtFiscal.Text = modelo.VenNFiscal.ToString();
                dtData.Value = modelo.VenData;

                //pegar o nome do cliente                
                BLLCliente bllc = new BLLCliente(cx);
                ModeloCliente modeloc = bllc.CarregaModeloCliente(modelo.CliCod);
                txtCliente.Text = modeloc.CliNome;
                txtValor.Text = modelo.VenTotal.ToString();

                //inserindo as parcelas
                BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
                dgvParcelas.DataSource = bllp.Localizar(modelo.VenCod);

                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Valor da Parcela";
                dgvParcelas.Columns[2].HeaderText = "Recebido em";
                dgvParcelas.Columns[3].HeaderText = "Vencimento";
                dgvParcelas.Columns[4].Visible = false;

            }
        }

        private void btReceber_Click(object sender, EventArgs e)
        {
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
            int venCod = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtpRecebimento.Value;
            bllp.EfetuaRecebeParcela(venCod, this.pveCod, data);

            //inserindo as parcelas
            BLLParcelasVenda bllpp = new BLLParcelasVenda(cx);
            dgvParcelas.DataSource = bllpp.Localizar(venCod);
            btReceber.Enabled = false;

            dgvParcelas.Columns[0].HeaderText = "Parcela";
            dgvParcelas.Columns[1].HeaderText = "Valor da Parcela";
            dgvParcelas.Columns[2].HeaderText = "Recebido em";
            dgvParcelas.Columns[3].HeaderText = "Vencimento";
            
        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btReceber.Enabled = false;
            this.pveCod = 0;

            if (e.RowIndex >= 0 && dgvParcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                btReceber.Enabled = true;
                this.pveCod = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);
                
            }
            //dgvParcelas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
            //MessageBox.Show("Parcela paga com sucesso!");
        }
    }
}
