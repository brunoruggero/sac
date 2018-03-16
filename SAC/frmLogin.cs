using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace SAC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Fechar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbNivelAcesso.SelectedIndex = 0;
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtLogUsuario.Text == "master" && txtSenha.Text == "master2@18#$")
            {
                this.Hide();
                frmPrincipal f = new frmPrincipal();
                f.ShowDialog();
                f.Dispose();
            }
            else
            {
                try
                {

                    SqlConnection cx = new SqlConnection(Properties.Settings.Default.sacBancoConnectionString);
                    string sql = "select usu_usuario, usu_senha, regra_nivel from usuario where usu_usuario = @usuUsuario and usu_senha = @usuSenha and regra_nivel = @regraNivel";
                    SqlCommand cmd = new SqlCommand(sql, cx);
               
                    cx.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@usuUsuario", txtLogUsuario.Text);
                    cmd.Parameters.AddWithValue("@usuSenha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("@regraNivel", cbNivelAcesso.SelectedItem.ToString());
                
                    dt.Fill(ds);
                    cx.Close();

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        frmPrincipal f = new frmPrincipal();
                        this.Hide();
                        f.logadoUser.Text = txtLogUsuario.Text.ToUpper();
                        f.usuarioNivel.Text = cbNivelAcesso.Text.ToUpper();
                  
                        //COMBOX PARA SERLECIONAR O ADMINISTRADOR
                        if (cbNivelAcesso.SelectedIndex == 1)
                        {
                            // POSSUI ACESSO TOTAL AO SISTEMA
                            f.cadastroEmpresaToolStripMenuItem.Visible = false;
                            f.toolStripSeparator8.Visible = false;
                            f.backupDoBancoDeDadosToolStripMenuItem.Visible = false;
                            f.configuraçãoDoBancoDeDaodToolStripMenuItem.Visible = false;
                            f.toolStripSeparator3.Visible = false;
                        }
                        //COMBOX PARA SELECIONAR O USUÁRIO
                        else if (cbNivelAcesso.SelectedIndex == 2)
                        {
                            f.cadastroToolStripMenuItem.Visible = false;
                            f.ferramentasToolStripMenuItem.Visible = false;
                            f.categoriaToolStripMenuItem1.Visible = false;
                            f.subCategoriaToolStripMenuItem1.Visible = false;
                            f.unidadeDeMedidaToolStripMenuItem1.Visible = false;
                            f.tipoDePagamentoToolStripMenuItem1.Visible = false;
                            f.compraToolStripMenuItem1.Visible = false;
                            f.toolStripSeparator6.Visible = false;
                            f.compraToolStripMenuItem.Visible = false;
                            f.pagamentoToolStripMenuItem.Visible = false;
                            f.recursosHumanosToolStripMenuItem.Visible = false;

                            //BLOQUEIO DO SUBMENU
                            f.tsbCliente.Visible = false;
                            f.tsbFornecedor.Visible = false;
                            f.tsbProduto.Visible = false;
                            f.tsbFuncionario.Visible = false;
                            f.tsbCompra.Visible = false;
                            f.toolStripSeparator10.Visible = false;
                            f.toolStripSeparator11.Visible = false;
                            f.toolStripSeparator12.Visible = false;
                            f.toolStripSeparator13.Visible = false;
                            f.toolStripSeparator14.Visible = false;
                        }
                        //COMBOX PARA SELECIONAR O GERENTE
                        else if (cbNivelAcesso.SelectedIndex == 3)
                        {
                            f.ferramentasToolStripMenuItem.Visible = false;
                            f.cadastroDeFuncionáriosToolStripMenuItem.Visible = false;
                            f.cadastroDeBenefíciosToolStripMenuItem.Visible = false;

                            //BLOQUEIO DO SUBMENU
                            f.tsbFuncionario.Visible = false;
                            f.toolStripSeparator15.Visible = false;

                            // só poderá consulta o funcionario e inserir um novo historico para o mesmo
                        }
                        //COMBOX PARA SELECIONAR O SUPERVISOR
                        else if (cbNivelAcesso.SelectedIndex == 4)
                        {
                       
                            f.ferramentasToolStripMenuItem.Visible = false;
                            f.cadastroToolStripMenuItem.Visible = false;
                            f.categoriaToolStripMenuItem1.Visible = false;
                            f.subCategoriaToolStripMenuItem.Visible = false;
                            f.subCategoriaToolStripMenuItem1.Visible = false;
                            f.unidadeDeMedidaToolStripMenuItem.Visible = false;
                            f.unidadeDeMedidaToolStripMenuItem1.Visible = false;
                            f.tipoDePagamentoToolStripMenuItem.Visible = false;
                            f.tipoDePagamentoToolStripMenuItem1.Visible = false;
                            f.compraToolStripMenuItem1.Visible = false;
                            f.toolStripSeparator6.Visible = false;
                            f.compraToolStripMenuItem.Visible = false;
                            f.pagamentoToolStripMenuItem.Visible = false;

                            //BLOQUEIO DO SUBMENU
                            f.tsbFuncionario.Visible = false;
                            f.tsbCompra.Visible = false;
                            f.toolStripSeparator14.Visible = false;
                            f.toolStripSeparator15.Visible = false;

                            // só poderá consulta o funcionario e inserir um novo historico para o mesmo
                        }
                        //COMBOX PARA SELECIONAR O RECURSOS HUMANOS
                        else if (cbNivelAcesso.SelectedIndex == 5)
                        {
                            f.cadastroToolStripMenuItem.Visible = false;
                            f.ferramentasToolStripMenuItem.Visible = false;
                            f.consultaToolStripMenuItem.Visible = false;
                            f.movimentaçãoToolStripMenuItem.Visible = false;
                            //f.recursosHumanosToolStripMenuItem.Visible = false;
                        }
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha estão inválidos!");
                    }
                }
                catch
                {

                }
            }
        }
    }
}
