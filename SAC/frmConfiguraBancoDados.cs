using DAO;
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
    public partial class frmConfiguraBancoDados : Form
    {
        public frmConfiguraBancoDados()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //metodo responsável para criação do arquivo de configuração do banco de dados.
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguraBanco.txt", false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBanco.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo atualizado com sucesso!");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void frmConfiguraBancoDados_Load(object sender, EventArgs e)
        {
            //metodo para leitura do arquivo com os dados do banco de dados
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguraBanco.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btTestar_Click(object sender, EventArgs e)
        {
            try
            {
               
                DAOBanco.servidor = txtServidor.Text;
                DAOBanco.banco = txtBanco.Text;
                DAOBanco.usuario = txtUsuario.Text;
                DAOBanco.senha = txtSenha.Text;
                
                //testar conexão
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DAOBanco.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conexão efetuada com sucesso!");
            }
            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados \n" +
                    "Verifique os dados informados!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
