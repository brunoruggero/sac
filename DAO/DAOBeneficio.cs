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
    public class DAOBeneficio
    {
        private DAOConexao conexao;

        public DAOBeneficio(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloBeneficio modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into beneficio(ben_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.BenNome);
            conexao.Conectar();
            modelo.BenCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloBeneficio modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update beneficio set ben_nome = @nome where ben_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.BenNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.BenCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from beneficio where ben_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from beneficio where ben_nome like '%" +
                 valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloBeneficio CarregaModeloBeneficio(int codigo)
        {
            ModeloBeneficio modelo = new ModeloBeneficio();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from beneficio where ben_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.BenCod = Convert.ToInt32(registro["ben_cod"]);
                modelo.BenNome = Convert.ToString(registro["ben_nome"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

    }
}
