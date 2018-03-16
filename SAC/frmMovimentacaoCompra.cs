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
    public partial class frmMovimentacaoCompra : SAC.frmModeloDeForm
    {
        public double totalCompra = 0; //variavel global

        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalCompra = 0;
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txtComCod.Text = modelo.ComCod.ToString();
                txtNFiscal.Text = modelo.ComNFiscal.ToString();
                dtDataCompra.Value = modelo.ComData;
                txtForCod.Text = modelo.ForCod.ToString();
                txtForCod_Leave(sender, e); //escrever o nome do fornecedor na tela
                cbTpgto.SelectedValue = modelo.TpaCod;
                cbNParcelas.Text = modelo.ComNParcelas.ToString();
                txtTotalCompra.Text = modelo.ComTotal.ToString();
                this.totalCompra = modelo.ComTotal; //armazenar o valor total da compra

                //iserindo itens da compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                DataTable tabela = bllItens.Localizar(modelo.ComCod);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtde = tabela.Rows[i]["itc_qtde"].ToString();
                    string ivunit = tabela.Rows[i]["itc_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itc_valor"]);
                    String[] it = new String[] { icod, inome, iqtde, ivunit, TotalLocal.ToString() }; //criar vetor de string
                    this.dgvItens.Rows.Add(it); //adicionar vetor no datagrid
                }
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {            
            int codigo = Convert.ToInt32(txtComCod.Text);
            int qtde = Convert.ToInt32(cbNParcelas.Text);

            //conexao e bll da compra
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLCompra bblc = new BLLCompra(cx);

            //determina a quantidade de parcelas pagas
            qtde -= bblc.QtdeParcelasNaoPagas(codigo);

            if (qtde == 0)//parcela foi paga
            {
                this.operacao = "alterar";
                this.alteraBotoes(2);
            }
            else
            {
                MessageBox.Show("Impossível alterar o registro. \n Registro possui parcelas pagas.");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
           try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    int codigo = Convert.ToInt32(txtComCod.Text);
                    int qtde = Convert.ToInt32(cbNParcelas.Text);

                    //conexao e bll da compra
                    DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                    BLLCompra bblc = new BLLCompra(cx);
                    
                    //determina a quantidade de parcelas pagas
                    qtde -= bblc.QtdeParcelasNaoPagas(codigo);

                    if(qtde == 0)//parcela foi paga
                    {
                        cx.Conectar();
                        cx.IniciarTransacao();
                        try
                        {
                            //exlcuir as parcelas da compra
                            BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                            bllp.ExcluirTodasParcelas(codigo);

                            //excluir itens da compra
                            BLLItensCompra blli = new BLLItensCompra(cx);
                            blli.ExcluirTodosItens(codigo);

                            //excluir compra
                            bblc.Excluir(codigo);
                            MessageBox.Show("Registro excluído.");
                            cx.TerminarTransacao();
                            cx.Desconectar();
                            this.LimpaTela();
                            this.alteraBotoes(1);
                        }
                        catch(Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                            cx.CancelarTransacao();
                            cx.Desconectar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossível excluir o registro. \n Registro possui parcelas pagas.");
                    }

                    
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
           
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtNFiscal.Text =="") //validação do número da nota fiscal
            {
                MessageBox.Show("Informe o número da nota fiscal.");
                return;
            }

            if(txtForCod.Text == "") //validação do fornecedor
            {
                MessageBox.Show("Informe o fornecedor da compra.");
                return;
            }

            if(this.totalCompra <= 0) //validação dos itens
            {
                MessageBox.Show("Informe os produtos da compra.");
                return;
            }

            dgvParcelas.Rows.Clear();
            int parcelas = Convert.ToInt32(cbNParcelas.Text);
            // Double totalLocal = Convert.ToDouble(txtTotalCompra.Text);
            Double totalLocal = this.totalCompra;
            double valor = totalLocal / parcelas;
            DateTime dt = new DateTime();
            dt = dtDataIni.Value;
            lbTotal.Text = this.totalCompra.ToString();
            for(int i = 1; i <= parcelas; i++)
            {
                String[] k = new String[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                this.dgvParcelas.Rows.Add(k);
                if(dt.Month != 12)
                {
                    dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                }
                else
                {
                    dt = new DateTime(dt.Year + 1, 1, dt.Day);
                }
            }
            pnFinalizaCompra.Visible = true;

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //limpar tela
            this.LimpaTela();
            this.alteraBotoes(1);
            this.totalCompra = 0;
        }

        public void LimpaTela()
        {
            txtComCod.Clear();
            txtNFiscal.Clear();
            txtForCod.Clear();
            txtProCod.Clear();
            lbProduto.Text = "Informe o código do Produto";
            txtQtde.Clear();
            txtValor.Clear();
            txtTotalCompra.Clear();
            dgvItens.Rows.Clear();
        }

        private void btLocFor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                txtForCod_Leave(sender, e);
            }

        }

        private void txtForCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod.Text));
                
                if (modelo.ForCod <= 0)
                {
                    lbFornecedor.Text = modelo.ForNome;
                    lbFornecedor.Text = "Informe o código do Fornecedor.";
                }
                else
                {
                    lbFornecedor.Text = modelo.ForNome;
                }
            }
            catch
            {
                txtForCod.Clear();
                lbFornecedor.Text = "Informe o código do Fornecedor.";
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

        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lbProduto.Text = modelo.ProNome;
                txtQtde.Text = "1";
                txtValor.Text = modelo.ProValorPago.ToString();
            }
            catch
            {
                txtProCod.Clear();
                lbProduto.Text = "Informe o código do Produto.";
            }
        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);//metodo para calcular o total dos produtos
                    this.totalCompra = this.totalCompra + TotalLocal;//metodo para somar o total da compra
                    String[] i = new String[] { txtProCod.Text, lbProduto.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() }; //metodo para criar o vetor de string
                    this.dgvItens.Rows.Add(i);//adicionar o vetor no datagrid

                    txtProCod.Clear();
                    lbProduto.Text = "Informe o código do Produto";
                    txtQtde.Clear();
                    txtValor.Clear();

                    txtTotalCompra.Text = this.totalCompra.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referentes ao valor e quantidade do produto.");
            }
        }

        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTpgto.DataSource = bll.Localizar("");
            cbTpgto.DisplayMember = "tpa_nome";
            cbTpgto.ValueMember = "tpa_cod";
            cbNParcelas.SelectedIndex = 0;
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalCompra.Text = this.totalCompra.ToString();
            }
        }

        private void btCancelarParcela_Click(object sender, EventArgs e)
        {
            pnFinalizaCompra.Visible = false;
        }

        private void btSalvarParcela_Click(object sender, EventArgs e)
        {

            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //leitura dos dados
                ModeloCompra modeloCompra = new ModeloCompra();
                modeloCompra.ComData = dtDataCompra.Value;
                modeloCompra.ComNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloCompra.ComNParcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloCompra.ComStatus = "ativa";
                modeloCompra.ComTotal = this.totalCompra;
                modeloCompra.ForCod = Convert.ToInt32(txtForCod.Text);
                modeloCompra.TpaCod = Convert.ToInt32(cbTpgto.SelectedValue);

                //obj para gravar os dados no banco
                //DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);

                ModeloItensCompra mitens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                ModeloParcelasCompra mparcelas = new ModeloParcelasCompra();
                BLLParcelasCompra bparcelas = new BLLParcelasCompra(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma compra
                    bll.Incluir(modeloCompra);

                    //cadastrar os itens da compra
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                    }

                    //inserir os itens nas parcelas da compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }

                    //cadastras as parcelas da compra
                    MessageBox.Show("Compra efetuada: Código " + modeloCompra.ComCod.ToString());

                }
                else
                {
                    //alterar uma compra
                    modeloCompra.ComCod = Convert.ToInt32(txtComCod.Text);
                    bll.Alterar(modeloCompra);
                    bitens.ExcluirTodosItens(modeloCompra.ComCod);
                    //cadastrar os itens da compra
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                    }
                    bparcelas.ExcluirTodasParcelas(modeloCompra.ComCod);
                    //inserir os itens nas parcelas da compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }

                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                pnFinalizaCompra.Visible = false;
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

        private void txtNFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
