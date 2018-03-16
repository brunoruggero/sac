using BLL;
using DAO;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAC
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrounidadeMedida f = new frmCadastrounidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobreSistema f = new frmSobreSistema();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void configuraçãoDoBancoDeDaodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguraBancoDados f = new frmConfiguraBancoDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           try
            {
                StreamReader arquivo = new StreamReader("ConfiguraBanco.txt");
                DAOBanco.servidor = arquivo.ReadLine();
                DAOBanco.banco = arquivo.ReadLine();
                DAOBanco.usuario = arquivo.ReadLine();
                DAOBanco.senha = arquivo.ReadLine();
                arquivo.Close();

                //testar conexão
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DAOBanco.StringDeConexao;
                conexao.Open();
                conexao.Close();
            }
            catch(SqlException errob)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados \n" +
                    "Acesse as configurações do banco de dados e informe os parâmetros de conexão.");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            //informa data e hora
            string data = DateTime.Now.ToLongDateString();
            data = data.Substring(0, 1).ToUpper() + data.Substring(1, data.Length - 1);
            lbData.Text = data;

            //informa o nome da empresa cadastrada
            SqlConnection cx = new SqlConnection(Properties.Settings.Default.sacBancoConnectionString);
            string sql = "select emp_nome from empresa";
            SqlCommand cmd = new SqlCommand(sql, cx);
            cx.Open();
            string valor = cmd.ExecuteScalar().ToString();
            lbEmpresa.Text = valor;
            cx.Close();

        }

        private void backupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBanco f = new frmBackupBanco();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento f = new frmCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento f = new frmConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoCompra f = new frmMovimentacaoCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamentoCompra f = new frmPagamentoCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoVenda f = new frmMovimentacaoVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void recebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecebeVenda f = new frmRecebeVenda();
            f.ShowDialog();
            f.Dispose();
        }

        public void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario f = new frmUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarEmpresa f = new frmCadastrarEmpresa();
            f.ShowDialog();
            f.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario f = new frmCadastroFuncionario();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario f = new frmConsultaFuncionario();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroDeBenefíciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroBeneficio f = new frmCadastroBeneficio();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaDeBenefíciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBeneficio f = new frmConsultaBeneficio();
            f.ShowDialog();
            f.Dispose();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fazer Logoff?", "Logoff do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin f = new frmLogin();
                f.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsbProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsbFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsbCompra_Click(object sender, EventArgs e)
        {
            frmMovimentacaoCompra f = new frmMovimentacaoCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsbVenda_Click(object sender, EventArgs e)
        {
            frmMovimentacaoVenda f = new frmMovimentacaoVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsbFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario f = new frmCadastroFuncionario();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsbPagar_Click(object sender, EventArgs e)
        {
            frmPagamentoCompra f = new frmPagamentoCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void tsbReceber_Click(object sender, EventArgs e)
        {
            frmRecebeVenda f = new frmRecebeVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Fechar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
