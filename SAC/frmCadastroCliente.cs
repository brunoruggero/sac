using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ferramentas;
using Modelo;
using BLL;

namespace SAC
{
    public partial class frmCadastroCliente : SAC.frmModeloDeForm
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        //metodo para formatar campo cpf/cnpj
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
            CEP = 3,
        }

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

        //Metodo para limpar a tela
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtRSocial.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCPFCNPJ.Clear();
            txtRGIE.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtTelefone.Clear();
            txtEstado.Clear();
            txtEmail.Clear();

            rbFisica.Checked = true;
            lbValorIncorreto.Visible = false;

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.CliCod.ToString();

                if (modelo.CliTipo == "Física")
                {
                    rbFisica.Checked = true;
                }
                else
                {
                    rbJuridica.Checked = true;
                }

                txtNome.Text = modelo.CliNome;
                txtRSocial.Text = modelo.CliRSocial;
                txtCPFCNPJ.Text = modelo.CliCpfCnpj;
                txtRGIE.Text = modelo.CliRgIe;
                txtCep.Text = modelo.CliCep;
                txtEstado.Text = modelo.CliEstado;
                txtCidade.Text = modelo.CliCidade;
                txtRua.Text = modelo.CliEndereco;
                txtNumero.Text = modelo.CliEndNumero;
                txtBairro.Text = modelo.CliBairro;
                txtEmail.Text = modelo.CliEmail;
                txtTelefone.Text = modelo.CliFone;
                txtCelular.Text = modelo.CliCelular;

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
                    BLLCliente bll = new BLLCliente(cx);
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
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliRSocial = txtRSocial.Text;
                modelo.CliCpfCnpj = txtCPFCNPJ.Text;
                modelo.CliRgIe = txtRGIE.Text;
                modelo.CliCep = txtCep.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEndereco = txtRua.Text;
                modelo.CliEndNumero = txtNumero.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliFone = txtTelefone.Text;
                modelo.CliCelular = txtCelular.Text;
                modelo.CliEmail = txtEmail.Text;
                if (rbFisica.Checked == true)
                {
                    modelo.CliTipo = "Física"; // fisica
                    modelo.CliRSocial = "";
                }
                else
                {
                    modelo.CliTipo = "Jurídica"; // juridico
                }

                //obj para gravar os dados no banco
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CliCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
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

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
            {
                lbRsocial.Visible = false;
                txtRSocial.Visible = false;
                lbCPFCNPJ.Text = "CPF";
                lbRGIE.Text = "RG";
            }
            else
            {
                lbRsocial.Visible = true;
                txtRSocial.Visible = true;
                lbCPFCNPJ.Text = "CNPJ";
                lbRGIE.Text = "IE";
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
        
        private void txtCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CPF;
                if (rbFisica.Checked == false) edit = Campo.CNPJ;
                Formatar(edit, txtCPFCNPJ);
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

        private void txtCPFCNPJ_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;

            if (rbFisica.Checked == true)
            {
                //cpf
                if (Validacao.IsCpf(txtCPFCNPJ.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCnpj(txtCPFCNPJ.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
        }
    }
}
