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
    public partial class frmCadastroNivelAcesso : SAC.frmModeloDeForm
    {
        public frmCadastroNivelAcesso()
        {
            InitializeComponent();
        }

        //Metodo para limpar a tela
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNivelAcesso.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaNivelAcesso f = new frmConsultaNivelAcesso();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                ModeloNivelAcesso modelo = bll.CarregaModeloNivelAcesso(f.codigo);
                txtCodigo.Text = modelo.RegraCod.ToString();
                txtNivelAcesso.Text = modelo.RegraNome;
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
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                    BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //limpar tela
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloNivelAcesso modelo = new ModeloNivelAcesso();
                modelo.RegraNome = txtNivelAcesso.Text;
                //obj para gravar os dados no banco
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar um nivel de acesso
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.RegraCod.ToString());

                }
                else
                {
                    //alterar um nivel de acesso
                    modelo.RegraCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void frmCadastroNivelAcesso_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
    }
}
