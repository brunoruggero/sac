using BLL;
using DAO;
using Ferramentas;
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
    public partial class frmCadastrarEmpresa : SAC.frmModeloDeForm
    {
        public frmCadastrarEmpresa()
        {
            InitializeComponent();
        }

        //metodo para formatar o cpf, cnpj e o cep
        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                case Campo.CEP:
                    txtTexto.MaxLength = 9;
                    if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }

        //metodo para limpar tela
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtRSocial.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCNPJ.Clear();
            txtIE.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtTelefone.Clear();
            txtEstado.Clear();
            txtEmail.Clear();
            lbValorIncorreto.Visible = false;

        }

        //metodo para formatar campo cpf/cnpj
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
            CEP = 3,
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            /*
             
             frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txtCodigo.Text = modelo.ForCod.ToString();
                txtNome.Text = modelo.ForNome;
                txtRSocial.Text = modelo.ForRSocial;
                txtCNPJ.Text = modelo.ForCnpj;
                txtIE.Text = modelo.ForIe;
                txtCep.Text = modelo.ForCep;
                txtEstado.Text = modelo.ForEstado;
                txtCidade.Text = modelo.ForCidade;
                txtRua.Text = modelo.ForEndereco;
                txtNumero.Text = modelo.ForEndNumero;
                txtBairro.Text = modelo.ForBairro;
                txtEmail.Text = modelo.ForEmail;
                txtTelefone.Text = modelo.ForFone;
                txtCelular.Text = modelo.ForCelular;

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
             
             
             
             
             */
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
                    BLLEmpresa bll = new BLLEmpresa(cx);
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
                ModeloEmpresa modelo = new ModeloEmpresa();
                modelo.EmpNome = txtNome.Text;
                modelo.EmpRSocial = txtRSocial.Text;
                modelo.EmpCnpj = txtCNPJ.Text;
                modelo.EmpIe = txtIE.Text;
                modelo.EmpCep = txtCep.Text;
                modelo.EmpEstado = txtEstado.Text;
                modelo.EmpCidade = txtCidade.Text;
                modelo.EmpEndereco = txtRua.Text;
                modelo.EmpEndNumero = txtNumero.Text;
                modelo.EmpBairro = txtBairro.Text;
                modelo.EmpFone = txtTelefone.Text;
                modelo.EmpCelular = txtCelular.Text;
                modelo.EmpEmail = txtEmail.Text;

                //obj para gravar os dados no banco
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLEmpresa bll = new BLLEmpresa(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.EmpCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.EmpCod = Convert.ToInt32(txtCodigo.Text);
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
            //limpar tela
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;

            //cnpj
            if (Validacao.IsCnpj(txtCNPJ.Text) == false)
            {
                lbValorIncorreto.Visible = true;
            }
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CNPJ;
                Formatar(edit, txtCNPJ);
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (Validacao.ValidaCep(txtCep.Text) == false)
            {
                MessageBox.Show("CEP inválido");
                txtBairro.Clear();
                txtEstado.Clear();
                txtCidade.Clear();
                txtRua.Clear();
            }
            else
            {
                if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
                {
                    txtBairro.Text = BuscaEndereco.bairro;
                    txtEstado.Text = BuscaEndereco.estado;
                    txtCidade.Text = BuscaEndereco.cidade;
                    txtRua.Text = BuscaEndereco.endereco;
                }
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CEP;
                Formatar(edit, txtCep);
            }
        }

        private void frmCadastrarEmpresa_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
    }
}
