using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Modelo;
using DAO;

namespace SAC
{
    public partial class frmCadastrounidadeMedida : SAC.frmModeloDeForm
    {
        public frmCadastrounidadeMedida()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        public void LimpaTela()
        {
            txtCod.Clear();
            txtUnidadeMedida.Clear();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                    BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txtCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    //MessageBox.Show("mensage");
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloUnidadeMedida modelo = new ModeloUnidadeMedida();
                modelo.UmedNome = txtUnidadeMedida.Text;
                //obj para gravar os dados no banco
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.UmedCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.UmedCod = Convert.ToInt32(txtCod.Text);
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(f.codigo);
                txtCod.Text = modelo.UmedCod.ToString();
                txtUnidadeMedida.Text = modelo.UmedNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void txtUnidadeMedida_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int r = 0;
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                r = bll.VerificaUnidadeDeMedida(txtUnidadeMedida.Text);
                if (r > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro com esse valor. Deseja alterar o registro?", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(r);
                        txtCod.Text = modelo.UmedCod.ToString();
                        txtUnidadeMedida.Text = modelo.UmedNome;
                        // alteraBotoes(3);
                    }
                }
            }
        }
    }
}
