using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAOTipoPagamento
    {
        private DAOConexao conexao;

        public DAOTipoPagamento(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoPagamento modelo)
        {
            //MySqlCommand cmd = new MySqlCommand();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into tipopagamento(tpa_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.TpaNome);
            conexao.Conectar();
            modelo.TpaCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloTipoPagamento modelo)
        {
            // MySqlCommand cmd = new MySqlCommand();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update tipopagamento set tpa_nome = @nome where tpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.TpaNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.TpaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            //MySqlCommand cmd = new MySqlCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from tipopagamento where tpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            // MySqlDataAdapter da = new MySqlDataAdapter("Select * from categoria where cat_nome like '%" +
            //     valor + "%'", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("Select * from tipopagamento where tpa_nome like '%" +
                 valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            ModeloTipoPagamento modelo = new ModeloTipoPagamento();
            //MySqlCommand cmd = new MySqlCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from tipopagamento where tpa_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            //MySqlDataReader registro = cmd.ExecuteReader();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.TpaNome = Convert.ToString(registro["tpa_nome"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
