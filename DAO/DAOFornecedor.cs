using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
   public class DAOFornecedor
    {

        private DAOConexao conexao;

        public DAOFornecedor(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor obj)
        {
            //MySqlCommand cmd = new MySqlCommand();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "insert into Fornecedor(For_nome, For_cnpj, For_ie, For_rsocial, For_cep, For_endereco, For_bairro," +
                "For_fone, For_cel, For_email, For_endnumero, For_cidade, For_estado) values (@For_nome, @For_cnpj, @For_ie, @For_rsocial," +
                "@For_cep, @For_endereco, @For_bairro, @For_fone, @For_cel, @For_email, @For_endnumero, @For_cidade, @For_estado); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@For_nome", obj.ForNome);
            cmd.Parameters.AddWithValue("@For_cnpj", obj.ForCnpj);
            cmd.Parameters.AddWithValue("@For_ie", obj.ForIe);
            cmd.Parameters.AddWithValue("@For_rsocial", obj.ForRSocial);
            cmd.Parameters.AddWithValue("@For_cep", obj.ForCep);
            cmd.Parameters.AddWithValue("@For_endereco", obj.ForEndereco);
            cmd.Parameters.AddWithValue("@For_bairro", obj.ForBairro);
            cmd.Parameters.AddWithValue("@For_fone", obj.ForFone);
            cmd.Parameters.AddWithValue("@For_cel", obj.ForCelular);
            cmd.Parameters.AddWithValue("@For_email", obj.ForEmail);
            cmd.Parameters.AddWithValue("@For_endnumero", obj.ForEndNumero);
            cmd.Parameters.AddWithValue("@For_cidade", obj.ForCidade);
            cmd.Parameters.AddWithValue("@For_estado", obj.ForEstado);

            conexao.Conectar();
            obj.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFornecedor obj)
        {
            // MySqlCommand cmd = new MySqlCommand();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "update Fornecedor set For_nome = @For_nome, For_cnpj = @For_cnpj,  For_ie = @For_ie, For_rsocial = @For_rsocial," +
                "For_cep = @For_cep, For_endereco = @For_endereco, For_bairro = @For_bairro, For_fone = @For_fone, For_cel = @For_cel," +
                "For_email = @For_email, For_endnumero = @For_endnumero, For_cidade = @For_cidade, For_estado = @For_estado where For_cod = @codigo;";

            cmd.Parameters.AddWithValue("@For_nome", obj.ForNome);
            cmd.Parameters.AddWithValue("@For_cnpj", obj.ForCnpj);
            cmd.Parameters.AddWithValue("@For_ie", obj.ForIe);
            cmd.Parameters.AddWithValue("@For_rsocial", obj.ForRSocial);
            cmd.Parameters.AddWithValue("@For_cep", obj.ForCep);
            cmd.Parameters.AddWithValue("@For_endereco", obj.ForEndereco);
            cmd.Parameters.AddWithValue("@For_bairro", obj.ForBairro);
            cmd.Parameters.AddWithValue("@For_fone", obj.ForFone);
            cmd.Parameters.AddWithValue("@For_cel", obj.ForCelular);
            cmd.Parameters.AddWithValue("@For_email", obj.ForEmail);
            cmd.Parameters.AddWithValue("@For_endnumero", obj.ForEndNumero);
            cmd.Parameters.AddWithValue("@For_cidade", obj.ForCidade);
            cmd.Parameters.AddWithValue("@For_estado", obj.ForEstado);
            cmd.Parameters.AddWithValue("@codigo", obj.ForCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            //MySqlCommand cmd = new MySqlCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "delete from Fornecedor where For_cod = @codigo;";

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
            SqlDataAdapter da = new SqlDataAdapter("Select * from Fornecedor where For_nome like '%" +
                 valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(String valor)
        {
            return Localizar(valor);
        }

        public DataTable LocalizarPorCNPJ(String valor)
        {
            DataTable tabela = new DataTable();
            // MySqlDataAdapter da = new MySqlDataAdapter("Select * from categoria where cat_nome like '%" +
            //     valor + "%'", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Fornecedor where For_cnpj like '%" +
                 valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            //MySqlCommand cmd = new MySqlCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "select * from Fornecedor where For_cod = @codigo";

            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();

            //MySqlDataReader registro = cmd.ExecuteReader();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["For_cod"]);
                modelo.ForNome = Convert.ToString(registro["For_nome"]);
                modelo.ForCnpj = Convert.ToString(registro["For_cnpj"]);
                modelo.ForIe = Convert.ToString(registro["For_ie"]);
                modelo.ForRSocial = Convert.ToString(registro["For_rsocial"]);
                modelo.ForCep = Convert.ToString(registro["For_cep"]);
                modelo.ForEndereco = Convert.ToString(registro["For_endereco"]);
                modelo.ForBairro = Convert.ToString(registro["For_bairro"]);
                modelo.ForFone = Convert.ToString(registro["For_fone"]);
                modelo.ForCelular = Convert.ToString(registro["For_cel"]);
                modelo.ForEmail = Convert.ToString(registro["For_email"]);
                modelo.ForEndNumero = Convert.ToString(registro["For_endnumero"]);
                modelo.ForCidade = Convert.ToString(registro["For_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["For_estado"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            //MySqlCommand cmd = new MySqlCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Fornecedor where For_cnpj = @cnpj";
            cmd.Parameters.AddWithValue("@cpfcnpj", cnpj);
            conexao.Conectar();
            //MySqlDataReader registro = cmd.ExecuteReader();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["For_cod"]);
                modelo.ForNome = Convert.ToString(registro["For_nome"]);
                modelo.ForCnpj = Convert.ToString(registro["For_cpfcnpj"]);
                modelo.ForIe = Convert.ToString(registro["For_rgie"]);
                modelo.ForRSocial = Convert.ToString(registro["For_rsocial"]);
                modelo.ForCep = Convert.ToString(registro["For_cep"]);
                modelo.ForEndereco = Convert.ToString(registro["For_endereco"]);
                modelo.ForBairro = Convert.ToString(registro["For_bairro"]);
                modelo.ForFone = Convert.ToString(registro["For_fone"]);
                modelo.ForCelular = Convert.ToString(registro["For_cel"]);
                modelo.ForEmail = Convert.ToString(registro["For_email"]);
                modelo.ForEndNumero = Convert.ToString(registro["For_endnumero"]);
                modelo.ForCidade = Convert.ToString(registro["For_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["For_estado"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

    }
}
