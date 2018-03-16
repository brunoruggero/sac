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
    public partial class frmPagamentoCompra : Form
    {
        public frmPagamentoCompra()
        {
            InitializeComponent();
        }

        public int pcoCod = 0;

        //limpa tela
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtFornecedor.Clear();
            txtFiscal.Clear();
            txtValor.Clear();
            dgvParcelas.Rows.Clear();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            btPagar.Enabled = false;
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txtCodigo.Text = modelo.ComCod.ToString();
                txtFiscal.Text = modelo.ComNFiscal.ToString();
                dtData.Value = modelo.ComData;
                
                //pegar o nome do fornecedor                
                BLLFornecedor bllf = new BLLFornecedor(cx);
                ModeloFornecedor modelof = bllf.CarregaModeloFornecedor(modelo.ForCod);
                txtFornecedor.Text = modelof.ForNome;
                txtValor.Text = modelo.ComTotal.ToString();

                //inserindo as parcelas
                BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                dgvParcelas.DataSource = bllp.Localizar(modelo.ComCod);

                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Valor da Parcela";
                dgvParcelas.Columns[2].HeaderText = "Pago em";
                dgvParcelas.Columns[3].HeaderText = "Vencimento";
                dgvParcelas.Columns[4].Visible = false;

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //limpar tela
            this.LimpaTela();
           // this.alteraBotoes(1);
           // this.totalCompra = 0;
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
            int comCod = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtpPagto.Value;
            bllp.EfetuaPagamentoParcela(comCod, this.pcoCod, data);
           
            //inserindo as parcelas
            BLLParcelasCompra bllpp = new BLLParcelasCompra(cx);
            dgvParcelas.DataSource = bllpp.Localizar(comCod);
            dgvParcelas.Columns[0].HeaderText = "Parcela";
            dgvParcelas.Columns[1].HeaderText = "Valor da Parcela";
            dgvParcelas.Columns[2].HeaderText = "Pago em";
            dgvParcelas.Columns[3].HeaderText = "Vencimento";
            btPagar.Enabled = false;

        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btPagar.Enabled = false;
            this.pcoCod = 0;

            if (e.RowIndex >= 0 && dgvParcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                btPagar.Enabled = true;
                this.pcoCod = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);
            }
            //MessageBox.Show("Parcela paga com sucesso!");
        }
    }
}
