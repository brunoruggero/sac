using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAONivelAcesso
    {
        private DAOConexao conexao;

        public DAONivelAcesso(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloNivelAcesso modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into nivelacesso(regra_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.RegraNome);
            conexao.Conectar();
            modelo.RegraCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloNivelAcesso modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update nivelacesso set regra_nome = @nome where regra_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.RegraNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.RegraCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from nivelacesso where regra_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from nivelacesso where regra_nome like '%" +
                 valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloNivelAcesso CarregaModeloNivelAcesso(int codigo)
        {
            ModeloNivelAcesso modelo = new ModeloNivelAcesso();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from nivelacesso where regra_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.RegraCod = Convert.ToInt32(registro["regra_cod"]);
                modelo.RegraNome = Convert.ToString(registro["regra_nome"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
