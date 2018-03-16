using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOConexao
    {        
        private String _stringconexao;
        private SqlConnection _conexao;
        
        //garantir a integridade dos dados
        private SqlTransaction _transaction;

        public DAOConexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }
        
        public String StringConexao
        {
            get { return this._stringconexao; }
            set { this._stringconexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public SqlTransaction ObejtoTransacao
        {
            get { return this._transaction; }
            set { this._transaction = value; }
        }

        //pegar o obejto de conexão e iniciar a transação e salvar na _transaction
        public void IniciarTransacao()
        {
            this._transaction = _conexao.BeginTransaction();
        }

        //termina a transação -> ao efetuar o commit efetua a gravação no banco de dados
        public void TerminarTransacao()
        {
            this._transaction.Commit();
        }

        //desfaz todas a operação
        public void CancelarTransacao()
        {
            this._transaction.Rollback();
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    
    }    
}
