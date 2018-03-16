using DAO;
using Ferramentas;
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
    public partial class frmBackupBanco : Form
    {
        public frmBackupBanco()
        {
            InitializeComponent();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog abrir = new SaveFileDialog();
                abrir.Filter = "Backup Files|*.bak";
                abrir.ShowDialog();
                if (abrir.FileName != "")
                {
                    String nomeBanco = DAOBanco.banco;
                    String localBackup = abrir.FileName;
                    String conexao = @"Data Source=" + DAOBanco.servidor + ";Initial Catalog=master;User=" + DAOBanco.usuario + ";Password=" + DAOBanco.senha;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, abrir.FileName);
                    MessageBox.Show("Backup realizado com sucesso!");

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btRestaura_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Filter = "Backup Files|*.bak";
                abrir.ShowDialog();
                if (abrir.FileName != "")
                {
                    String nomeBanco = DAOBanco.banco;
                    String localBackup = abrir.FileName;
                    String conexao = @"Data Source=" + DAOBanco.servidor + ";Initial Catalog=master;User=" + DAOBanco.usuario + ";Password=" + DAOBanco.senha;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, abrir.FileName);
                    MessageBox.Show("Backup restaurado com sucesso!");

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
