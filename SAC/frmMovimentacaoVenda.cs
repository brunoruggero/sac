using BLL;
using DAO;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAC
{
    public partial class frmMovimentacaoVenda : SAC.frmModeloDeForm
    {
        public double totalVenda = 0;

        public frmMovimentacaoVenda()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalVenda = 0;
            this.alteraBotoes(2);
            cbNParcelas.SelectedIndex = 0;
            cbVendaAVista.Checked = false;
        }

        private void btLocCli_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                txtCliCod_Leave(sender, e);
            }
        }

        private void txtCliCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txtCliCod.Text));
                if(modelo.CliCod <= 0)
                {
                    txtCliCod.Clear();
                    lbCliente.Text = "Informe o código do Cliente.";
                }
                else
                {
                    lbCliente.Text = modelo.CliNome;
                }
            }
            catch
            {
                txtCliCod.Clear();
                lbCliente.Text = "Informe o código do Cliente.";
            }
        }

        private void btLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtProCod.Text = f.codigo.ToString();
                txtProCod_Leave(sender, e);
            }
        }

        //Verificar a quantidade de produtos em estoque para venda
        private Double VerificaQtdeProdutos(int ProCod)
        {
            Double QtdeEstoque = 0;
            
            try
            {
                // verificar qtde em estoque
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(ProCod);
                QtdeEstoque = modelo.ProQtde;

                //verifica produtos no grid
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    if(Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value) == ProCod)
                    {
                        QtdeEstoque = QtdeEstoque - Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                    }
                }
            }
            catch
            {
            }
            return QtdeEstoque;
        }

        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lbProduto.Text = modelo.ProNome;
                txtQtde.Text = "1";
                txtValor.Text = modelo.ProValorVenda.ToString();
            }
            catch
            {
                txtProCod.Clear();
                lbProduto.Text = "Informe o código do Produto.";
            }
        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            Double Qtde = 0;
            try
            {
                if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    //verificação do estoque para venda
                    if(cbValidaQtde.Checked == true)
                    {
                        Qtde = VerificaQtdeProdutos(Convert.ToInt32(txtProCod.Text));
                        if (Convert.ToDouble(txtQtde.Text) > Qtde)
                        {
                            MessageBox.Show("Quantidade para venda não disponível em Estoque.\n Estoque atual: " + Qtde);
                            return;
                        }
                    }
                    Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);//metodo para calcular o total dos produtos
                    this.totalVenda = this.totalVenda + TotalLocal;//metodo para somar o total da compra
                    String[] i = new String[] { txtProCod.Text, lbProduto.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() }; //metodo para criar o vetor de string
                    this.dgvItens.Rows.Add(i);//adicionar o vetor no datagrid

                    txtProCod.Clear();
                    lbProduto.Text = "Informe o código do Produto";
                    txtQtde.Clear();
                    txtValor.Clear();

                    txtTotalVenda.Text = this.totalVenda.ToString(); //atualiza o total da venda
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referentes ao valor e quantidade do produto.");
            }
        }

        private void frmMovimentacaoVenda_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTpgto.DataSource = bll.Localizar("");
            cbTpgto.DisplayMember = "tpa_nome";
            cbTpgto.ValueMember = "tpa_cod";
            cbNParcelas.SelectedIndex = 0;
        }

        private void cbVendaAVista_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVendaAVista.Checked == true)
            {
                cbNParcelas.SelectedIndex = 0;
                cbNParcelas.Enabled = false;
            }
            else
            {
                cbNParcelas.Enabled = true;
            }
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalVenda = this.totalVenda - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalVenda.Text = this.totalVenda.ToString();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //validar os dados da venda
            try
            {
                if (Convert.ToInt32(txtCliCod.Text) <= 0)
                {
                    MessageBox.Show("Informe o código do Cliente.");
                    return;
                }
                if (Convert.ToInt32(txtNFiscal.Text) < 0)
                {
                    MessageBox.Show("Informe o número da Nota Fiscal.");
                    return;
                }
                if (totalVenda < 0)
                {
                    MessageBox.Show("Necessário inserir itens na Venda.");
                    return;
                }
                    dgvParcelas.Rows.Clear();
                    int parcelas = Convert.ToInt32(cbNParcelas.Text);
                    // Double totalLocal = Convert.ToDouble(txtTotalCompra.Text);
                    Double totalLocal = this.totalVenda;
                    double valor = totalLocal / parcelas;
                    DateTime dt = new DateTime();
                    dt = dtDataIni.Value;
                    lbTotal.Text = this.totalVenda.ToString();
                    for (int i = 1; i <= parcelas; i++)
                    {
                        String[] k = new String[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                        this.dgvParcelas.Rows.Add(k);
                        if (dt.Month != 12)
                        {
                            dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                        }
                        else
                        {
                            dt = new DateTime(dt.Year + 1, 1, dt.Day);
                        }
                    }
                    pnFinalizaVenda.Visible = true;
            }
            catch
            {
                MessageBox.Show("Verifique os dados da Venda");
            }
        }

        private void btCancelarParcela_Click(object sender, EventArgs e)
        {
            pnFinalizaVenda.Visible = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //limpar tela
            this.LimpaTela();
            this.alteraBotoes(1);
            this.totalVenda = 0;
        }

        public void LimpaTela()
        {
            txtVenCod.Clear();
            txtNFiscal.Clear();
            txtCliCod.Clear();
            lbCliente.Text = "Informe o código do Cliente";
            txtProCod.Clear();
            lbProduto.Text = "Informe o código do Produto";
            txtQtde.Clear();
            txtValor.Clear();
            txtTotalVenda.Text = "0,00";
            dgvItens.Rows.Clear();
            cbNParcelas.SelectedIndex = 0;
            cbTpgto.SelectedIndex = 0;
            lbMsg.Visible = false;

        }

        private void btSalvarParcela_Click(object sender, EventArgs e)
        {
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //leitura dos dados
                ModeloVenda modeloVenda = new ModeloVenda();
                modeloVenda.VenData = dtDataVenda.Value;
                modeloVenda.VenNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloVenda.VenNParcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloVenda.VenStatus = "ativa";
                modeloVenda.VenTotal = this.totalVenda;
                modeloVenda.CliCod = Convert.ToInt32(txtCliCod.Text);
                modeloVenda.TpaCod = Convert.ToInt32(cbTpgto.SelectedValue);
                if (modeloVenda.VenAvista == 1)
                {
                    cbVendaAVista.Checked = true;
                }
                else
                {
                    cbVendaAVista.Checked = false;
                }
                //obj para gravar os dados no banco
                //DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLVenda bllVenda = new BLLVenda(cx);

                ModeloItensVenda mitens = new ModeloItensVenda();
                BLLItensVenda bitens = new BLLItensVenda(cx);

                ModeloParcelasVenda mparcelas = new ModeloParcelasVenda();
                BLLParcelasVenda bparcelas = new BLLParcelasVenda(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma venda
                    bllVenda.Incluir(modeloVenda);

                    //cadastrar os itens da venda
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItvCod = i + 1;
                        mitens.VenCod = modeloVenda.VenCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItvQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItvValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                    }
                    
                    //inserir os itens nas parcelas da venda
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.VenCod = modeloVenda.VenCod;
                        mparcelas.PveCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PveValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PveDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }

                    MessageBox.Show("Venda efetuada: Código " + modeloVenda.VenCod.ToString());

                }
                
                this.LimpaTela();
                pnFinalizaVenda.Visible = false;
                this.alteraBotoes(1);
                cx.TerminarTransacao();
                cx.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                txtVenCod.Text = modelo.VenCod.ToString();
                txtNFiscal.Text = modelo.VenNFiscal.ToString();
                dtDataVenda.Value = modelo.VenData;
                txtCliCod.Text = modelo.CliCod.ToString();
                txtCliCod_Leave(sender, e); //escrever o nome do cliente na tela
                cbTpgto.SelectedValue = modelo.TpaCod;
                cbNParcelas.Text = modelo.VenNParcelas.ToString();
                if (modelo.VenAvista == 1)
                {
                    cbVendaAVista.Checked = true;
                }
                else
                {
                    cbVendaAVista.Checked = false;
                }
                txtTotalVenda.Text = modelo.VenTotal.ToString();
                this.totalVenda = modelo.VenTotal; //armazenar o valor total da venda
                
                //inserindo itens da venda
                BLLItensVenda bllItens = new BLLItensVenda(cx);
                DataTable tabela = bllItens.Localizar(modelo.VenCod);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtde = tabela.Rows[i]["itv_qtde"].ToString();
                    string ivunit = tabela.Rows[i]["itv_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itv_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itv_valor"]);
                    String[] it = new String[] { icod, inome, iqtde, ivunit, TotalLocal.ToString() }; //criar vetor de string
                    this.dgvItens.Rows.Add(it); //adicionar vetor no datagrid
                }
                alteraBotoes(3);
                lbMsg.Visible = false;
                if (modelo.VenStatus != "ativa")
                {
                    //lbMsg.Text = "Venda Cancelada";
                    lbMsg.Visible = true;
                    btExcluir.Enabled = false;
                }
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            
            //MÉTODO PARA CANCELAR A VENDA

            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLVenda bll = new BLLVenda(cx);
            DialogResult d = MessageBox.Show("Deseja cancelar a venda?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                if (bll.CancelarVenda(Convert.ToInt32(txtVenCod.Text)) == true)
                {
                    MessageBox.Show("Venda cancelada com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível cancelar a venda. \n Contate seu desenvolvedor.");
                }
            }
        }      
    }
}
