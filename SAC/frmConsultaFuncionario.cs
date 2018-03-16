using BLL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAC
{
    public partial class frmConsultaFuncionario : Form
    {
        public frmConsultaFuncionario()
        {
            InitializeComponent();
        }

        public int codigo = 0;

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DAOConexao cx = new DAOConexao(DAOBanco.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Matricula";
            dgvDados.Columns[1].Width = 70;
            dgvDados.Columns[2].HeaderText = "Nome Funcionário";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "CPF";
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "RG";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "Orgão Emissor";
            dgvDados.Columns[5].Width = 50;
            dgvDados.Columns[6].HeaderText = "RG - Emissão";
            dgvDados.Columns[6].Width = 100;
            dgvDados.Columns[7].HeaderText = "Data Nascimento";
            dgvDados.Columns[7].Width = 100;
            dgvDados.Columns[8].HeaderText = "Sexo";
            dgvDados.Columns[8].Width = 100;
            dgvDados.Columns[9].HeaderText = "Estado Civil";
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[10].HeaderText = "Filhos";
            dgvDados.Columns[10].Width = 100;
            dgvDados.Columns[11].HeaderText = "Cônjuge";
            dgvDados.Columns[11].Width = 100;
            dgvDados.Columns[12].HeaderText = "Telefone";
            dgvDados.Columns[12].Width = 100;
            dgvDados.Columns[13].HeaderText = "Celular";
            dgvDados.Columns[13].Width = 100;
            dgvDados.Columns[14].HeaderText = "Formação";
            dgvDados.Columns[14].Width = 100;
            dgvDados.Columns[15].HeaderText = "Função";
            dgvDados.Columns[15].Width = 100;
            dgvDados.Columns[16].HeaderText = "Título Eleitor";
            dgvDados.Columns[16].Width = 100;
            dgvDados.Columns[17].HeaderText = "Zona";
            dgvDados.Columns[17].Width = 100;
            dgvDados.Columns[18].HeaderText = "Seção";
            dgvDados.Columns[18].Width = 100;
            dgvDados.Columns[19].HeaderText = "Título - Emissão";
            dgvDados.Columns[19].Width = 100;
            dgvDados.Columns[20].HeaderText = "Reservista";
            dgvDados.Columns[20].Width = 100;
            dgvDados.Columns[21].HeaderText = "CNH";
            dgvDados.Columns[21].Width = 100;
            dgvDados.Columns[22].HeaderText = "CNH - Emissão";
            dgvDados.Columns[22].Width = 100;
            dgvDados.Columns[23].HeaderText = "CNH - Validade";
            dgvDados.Columns[23].Width = 100;
            dgvDados.Columns[24].HeaderText = "CNH - Categoria";
            dgvDados.Columns[24].Width = 100;
            dgvDados.Columns[25].HeaderText = "Número CTPS";
            dgvDados.Columns[25].Width = 100;
            dgvDados.Columns[26].HeaderText = "Série CTPS";
            dgvDados.Columns[26].Width = 100;
            dgvDados.Columns[27].HeaderText = "CTPS - Emissão";
            dgvDados.Columns[27].Width = 100;
            dgvDados.Columns[28].HeaderText = "Número PIS";
            dgvDados.Columns[28].Width = 100;
            dgvDados.Columns[29].HeaderText = "Data Admissão";
            dgvDados.Columns[29].Width = 100;
            dgvDados.Columns[30].HeaderText = "Data Demissão";
            dgvDados.Columns[30].Width = 100;
            dgvDados.Columns[31].HeaderText = "Salário Base";
            dgvDados.Columns[31].Width = 100;
            dgvDados.Columns[32].HeaderText = "Salário Extra";
            dgvDados.Columns[32].Width = 100;
            dgvDados.Columns[33].HeaderText = "Ajuda Custo";
            dgvDados.Columns[33].Width = 100;
            dgvDados.Columns[34].HeaderText = "CEP";
            dgvDados.Columns[34].Width = 100;
            dgvDados.Columns[35].HeaderText = "Endereço";
            dgvDados.Columns[35].Width = 100;
            dgvDados.Columns[36].HeaderText = "Bairro";
            dgvDados.Columns[36].Width = 100;
            dgvDados.Columns[37].HeaderText = "Número";
            dgvDados.Columns[37].Width = 100;
            dgvDados.Columns[38].HeaderText = "Cidade";
            dgvDados.Columns[38].Width = 100;
            dgvDados.Columns[39].HeaderText = "Estado";
            dgvDados.Columns[39].Width = 100;
            dgvDados.Columns[40].HeaderText = "Nome Banco";
            dgvDados.Columns[40].Width = 100;
            dgvDados.Columns[41].HeaderText = "Agência";
            dgvDados.Columns[41].Width = 100;
            dgvDados.Columns[42].HeaderText = "Conta";
            dgvDados.Columns[42].Width = 100;
            dgvDados.Columns[43].HeaderText = "Data Abertura";
            dgvDados.Columns[43].Width = 100;
            dgvDados.Columns[44].HeaderText = "Cógido Benefício";
            dgvDados.Columns[44].Width = 100;
            dgvDados.Columns[45].HeaderText = "Nome Benefício";
            dgvDados.Columns[45].Width = 100;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
