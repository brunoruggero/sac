using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAO;
using BLL;

namespace SAC
{
    public partial class frmCadastroTipoPagamento : SAC.frmModeloDeForm
    {
        public frmCadastroTipoPagamento()
        {
            InitializeComponent();
        }

        //Metodo para limpar a tela
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void frmCadastroTipoPagamento_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //limpar tela
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            frmConsultaTipoPagamento f = new frmConsultaTipoPagamento();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                ModeloTipoPagamento modelo = bll.CarregaModeloTipoPagamento(f.codigo);
                txtCodigo.Text = modelo.TpaCod.ToString();
                txtNome.Text = modelo.TpaNome;
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
                    BLLTipoPagamento bll = new BLLTipoPagamento(cx);
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloTipoPagamento modelo = new ModeloTipoPagamento();
                modelo.TpaNome = txtNome.Text;
                //obj para gravar os dados no banco
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.TpaCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.TpaCod = Convert.ToInt32(txtCodigo.Text);
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
    }
}
