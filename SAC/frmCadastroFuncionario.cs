using BLL;
using DAO;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SAC
{
    public partial class frmCadastroFuncionario : SAC.frmModeloDeForm
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        public string foto = "";

        //metodo para formatar campo cpf/cnpj
        public enum Campo
        {
            CPF = 1,
            CEP = 2,
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

        //Metodo Limpa Tela
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtMatricula.Clear();
            txtSexo.Clear();
            txtEstadoCivil.Clear();
            txtNumFilhos.Clear();
            txtNomeConjuge.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtFormacao.Clear();
            txtFuncao.Clear();
            txtDemissao.Clear();
            txtSalarioBase.Clear();
            txtSalarioExtra.Clear();
            txtAjudaCusto.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtOrgaoEmissor.Clear();
            txtTituloEleitor.Clear();
            txtZona.Clear();
            txtSecao.Clear();
            txtReservista.Clear();
            txtCnh.Clear();
            txtCategoria.Clear();
            txtNumeroCtps.Clear();
            txtNumeroPis.Clear();
            txtSerieCtps.Clear();
            txtNomeBanco.Clear();
            txtAgencia.Clear();
            txtConta.Clear();
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //limpar tela
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            //combo do beneficio
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLBeneficio bll = new BLLBeneficio(cx);
            cbBeneficio.DataSource = bll.Localizar("");
            cbBeneficio.DisplayMember = "ben_nome";
            cbBeneficio.ValueMember = "ben_cod";
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btLoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
        }

        private void btRmFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                    BLLFuncionario bll = new BLLFuncionario(cx);
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

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (Validacao.ValidaCep(txtCep.Text) == false)
            {
                MessageBox.Show("CEP inválido");
                txtBairro.Clear();
                txtEstado.Clear();
                txtCidade.Clear();
                txtEndereco.Clear();
            }
            else
            {
                if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
                {
                    txtBairro.Text = BuscaEndereco.bairro;
                    txtEstado.Text = BuscaEndereco.estado;
                    txtCidade.Text = BuscaEndereco.cidade;
                    txtEndereco.Text = BuscaEndereco.endereco;
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

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;

            //cpf
                if (Validacao.IsCpf(txtCpf.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CPF;
                Formatar(edit, txtCpf);
            }
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloFuncionario modelo = new ModeloFuncionario();                
                modelo.FunMatricula = txtMatricula.Text;
                modelo.FunNome = txtNome.Text;
                modelo.FunDataNascimento = dtNascimento.Value;
                modelo.FunSexo = txtSexo.Text;
                modelo.FunEstadoCivil = txtEstadoCivil.Text;
                modelo.FunNumFilhos = Convert.ToInt32(txtNumFilhos.Text);
                modelo.FunNomeConjuge = txtNomeConjuge.Text;
                modelo.FunTelefone = txtTelefone.Text;
                modelo.FunCelular = txtCelular.Text;
                modelo.FunFormacao = txtFormacao.Text;
                modelo.FunFuncaoExercida = txtFuncao.Text;
                modelo.FunDemissao = txtDemissao.Text;
                modelo.FunSalarioBase = Convert.ToDouble(txtSalarioBase.Text);
                modelo.FunSalarioExtra = Convert.ToDouble(txtSalarioExtra.Text);
                modelo.FunAjudaCusto = Convert.ToDouble(txtAjudaCusto.Text);
                modelo.FunCep = txtCep.Text;
                modelo.FunEndereco = txtEndereco.Text;
                modelo.FunBairro = txtBairro.Text;
                modelo.FunEndNumero = txtNumero.Text;
                modelo.FunCidade = txtCidade.Text;
                modelo.FunEstado = txtEstado.Text;
                modelo.FunCpf = txtCpf.Text;
                modelo.FunRg = txtRg.Text;
                modelo.FunOrgaoEmissor = txtOrgaoEmissor.Text;
                modelo.FunRgEmissao = dtEmissaoRg.Value;
                modelo.FunTituloEleitor = txtTituloEleitor.Text;
                modelo.FunZonaEleitor = txtZona.Text;
                modelo.FunSecaoEleitor = txtSecao.Text;
                modelo.FunEmissaoEleitor = dtEmissaoTitulo.Value;
                modelo.FunReservista = txtReservista.Text;
                modelo.FunCnh = txtCnh.Text;
                modelo.FunEmissaoCnh = dtEmissaoCnh.Value;
                modelo.FunValidadeCnh = dtValidadeCnh.Value;
                modelo.FunCategoriaCnh = txtCategoria.Text;
                modelo.FunNumCtps = txtNumeroCtps.Text;
                modelo.FunNumPis = txtNumeroPis.Text;
                modelo.FunSerieCtps = txtSerieCtps.Text;
                modelo.FunDataCtps = dtEmissaoCtps.Value;
                modelo.FunBancoNome = txtNomeBanco.Text;
                modelo.FunBancoAgencia = txtAgencia.Text;
                modelo.FunBancoConta = txtConta.Text;
                modelo.FunBancoData = dtAberturaConta.Value;
                modelo.BenCod = Convert.ToInt32(cbBeneficio.SelectedValue);

                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLFuncionario bll = new BLLFuncionario(cx);
                if(this.operacao == "inserir")
                {
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.FunCod.ToString());
                }
                else
                {
                    modelo.FunCod = Convert.ToInt32(txtCodigo.Text);
                    if (this.foto == "Foto Original")
                    {
                        ModeloFuncionario mt = bll.CarregaModeloFuncionario(modelo.FunCod);
                        modelo.FunFoto = mt.FunFoto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
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

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario f = new frmConsultaFuncionario();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLFuncionario bll = new BLLFuncionario(cx);
                ModeloFuncionario modelo = bll.CarregaModeloFuncionario(f.codigo);
                txtCodigo.Text = modelo.FunCod.ToString();
                txtNome.Text = modelo.FunNome.ToString();
                txtMatricula.Text = modelo.FunMatricula.ToString();
                txtCpf.Text = modelo.FunCpf.ToString();
                txtRg.Text = modelo.FunRg.ToString();
                txtOrgaoEmissor.Text = modelo.FunOrgaoEmissor.ToString();
                dtEmissaoRg.Value = modelo.FunRgEmissao;
                dtNascimento.Value = modelo.FunDataNascimento;
                txtSexo.Text = modelo.FunSexo.ToString();
                txtEstadoCivil.Text = modelo.FunEstadoCivil.ToString();
                txtNumFilhos.Text = modelo.FunNumFilhos.ToString();
                txtNomeConjuge.Text = modelo.FunNomeConjuge.ToString();
                txtTelefone.Text = modelo.FunTelefone.ToString();
                txtCelular.Text = modelo.FunCelular.ToString();
                txtFormacao.Text = modelo.FunFormacao.ToString();
                txtTituloEleitor.Text = modelo.FunTituloEleitor.ToString();
                txtZona.Text = modelo.FunZonaEleitor.ToString();
                txtSecao.Text = modelo.FunSecaoEleitor.ToString();
                dtEmissaoTitulo.Value = modelo.FunEmissaoEleitor;
                txtReservista.Text = modelo.FunReservista.ToString();
                txtCnh.Text = modelo.FunCnh.ToString();
                dtEmissaoCnh.Value = modelo.FunEmissaoCnh;
                dtValidadeCnh.Value = modelo.FunValidadeCnh;
                txtCategoria.Text = modelo.FunCategoriaCnh.ToString();
                txtNumeroCtps.Text = modelo.FunNumCtps.ToString();
                txtSerieCtps.Text = modelo.FunSerieCtps.ToString();
                txtNumeroPis.Text = modelo.FunNumPis.ToString();
                dtEmissaoCtps.Value = modelo.FunDataCtps;
                txtFuncao.Text = modelo.FunFuncaoExercida.ToString();
                dtAdmissao.Value = modelo.FunAdmissao;
                txtDemissao.Text = modelo.FunDemissao.ToString();
                txtSalarioBase.Text = modelo.FunSalarioBase.ToString();
                txtSalarioExtra.Text = modelo.FunSalarioExtra.ToString();
                txtAjudaCusto.Text = modelo.FunAjudaCusto.ToString();
                txtCep.Text = modelo.FunCep.ToString();
                txtEndereco.Text = modelo.FunEndereco.ToString();
                txtBairro.Text = modelo.FunBairro.ToString();
                txtNumero.Text = modelo.FunEndNumero.ToString();
                txtCidade.Text = modelo.FunCidade.ToString();
                txtEstado.Text = modelo.FunEstado.ToString();
                txtNomeBanco.Text = modelo.FunBancoNome.ToString();
                txtAgencia.Text = modelo.FunBancoAgencia.ToString();
                txtConta.Text = modelo.FunBancoConta.ToString();
                cbBeneficio.SelectedValue = modelo.BenCod;

                //mostrar a imagem novamente quando localizar o cadastro
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.FunFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch { }
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

    }
}

