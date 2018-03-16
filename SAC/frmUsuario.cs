using BLL;
using DAO;
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
    public partial class frmUsuario : SAC.frmModeloDeForm
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        public string foto = "";

        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            this.foto = "";
            pbFoto.Image = null;
            
        }


        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = bll.CarregaModeloUsuario(f.codigo);
                txtCodigo.Text = modelo.UsuCod.ToString();

                //colocar os dados na tela
                txtCodigo.Text = modelo.UsuCod.ToString();
                txtNome.Text = modelo.UsuNome;
                txtUsuario.Text = modelo.UsuUsuario;
                txtSenha.Text = modelo.UsuSenha;
                cbNivelAcesso.SelectedItem = modelo.RegraNivel;

                //mostrar a imagem novamente quando localizar o cadastro
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.UsuFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch {}
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
                    BLLUsuario bll = new BLLUsuario(cx);
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
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsuNome = txtNome.Text;
                modelo.UsuUsuario = txtUsuario.Text;
                modelo.UsuSenha = txtSenha.Text;
                modelo.RegraNivel = cbNivelAcesso.SelectedItem.ToString();


                //obj para gravar os dados no banco
                DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.UsuCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.UsuCod = Convert.ToInt32(txtCodigo.Text);
                    if (this.foto == "Foto Original")
                    {
                        ModeloUsuario mt = bll.CarregaModeloUsuario(modelo.UsuCod);
                        modelo.UsuFoto = mt.UsuFoto;
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            cbNivelAcesso.SelectedIndex = 0;
        }

        private void cbNivelAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
          
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
    }
}
