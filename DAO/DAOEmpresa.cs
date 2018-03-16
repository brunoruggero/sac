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
    public class DAOEmpresa
    {

        private DAOConexao conexao;

        public DAOEmpresa(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloEmpresa obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "insert into Empresa(Emp_nome, Emp_cnpj, Emp_ie, Emp_rsocial, Emp_cep, Emp_endereco, Emp_bairro," +
                "Emp_fone, Emp_cel, Emp_email, Emp_endnumero, Emp_cidade, Emp_estado) values (@Emp_nome, @Emp_cnpj, @Emp_ie, @Emp_rsocial," +
                "@Emp_cep, @Emp_endereco, @Emp_bairro, @Emp_fone, @Emp_cel, @Emp_email, @Emp_endnumero, @Emp_cidade, @Emp_estado); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@Emp_nome", obj.EmpNome);
            cmd.Parameters.AddWithValue("@Emp_cnpj", obj.EmpCnpj);
            cmd.Parameters.AddWithValue("@Emp_ie", obj.EmpIe);
            cmd.Parameters.AddWithValue("@Emp_rsocial", obj.EmpRSocial);
            cmd.Parameters.AddWithValue("@Emp_cep", obj.EmpCep);
            cmd.Parameters.AddWithValue("@Emp_endereco", obj.EmpEndereco);
            cmd.Parameters.AddWithValue("@Emp_bairro", obj.EmpBairro);
            cmd.Parameters.AddWithValue("@Emp_fone", obj.EmpFone);
            cmd.Parameters.AddWithValue("@Emp_cel", obj.EmpCelular);
            cmd.Parameters.AddWithValue("@Emp_email", obj.EmpEmail);
            cmd.Parameters.AddWithValue("@Emp_endnumero", obj.EmpEndNumero);
            cmd.Parameters.AddWithValue("@Emp_cidade", obj.EmpCidade);
            cmd.Parameters.AddWithValue("@Emp_estado", obj.EmpEstado);

            conexao.Conectar();
            obj.EmpCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloEmpresa obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "update Empresa set Emp_nome = @Emp_nome, Emp_cnpj = @Emp_cnpj,  Emp_ie = @Emp_ie, Emp_rsocial = @Emp_rsocial," +
                "Emp_cep = @Emp_cep, Emp_endereco = @Emp_endereco, Emp_bairro = @Emp_bairro, Emp_fone = @Emp_fone, Emp_cel = @Emp_cel," +
                "Emp_email = @Emp_email, Emp_endnumero = @Emp_endnumero, Emp_cidade = @Emp_cidade, Emp_estado = @Emp_estado where Emp_cod = @codigo;";

            cmd.Parameters.AddWithValue("@Emp_nome", obj.EmpNome);
            cmd.Parameters.AddWithValue("@Emp_cnpj", obj.EmpCnpj);
            cmd.Parameters.AddWithValue("@Emp_ie", obj.EmpIe);
            cmd.Parameters.AddWithValue("@Emp_rsocial", obj.EmpRSocial);
            cmd.Parameters.AddWithValue("@Emp_cep", obj.EmpCep);
            cmd.Parameters.AddWithValue("@Emp_endereco", obj.EmpEndereco);
            cmd.Parameters.AddWithValue("@Emp_bairro", obj.EmpBairro);
            cmd.Parameters.AddWithValue("@Emp_fone", obj.EmpFone);
            cmd.Parameters.AddWithValue("@Emp_cel", obj.EmpCelular);
            cmd.Parameters.AddWithValue("@Emp_email", obj.EmpEmail);
            cmd.Parameters.AddWithValue("@Emp_endnumero", obj.EmpEndNumero);
            cmd.Parameters.AddWithValue("@Emp_cidade", obj.EmpCidade);
            cmd.Parameters.AddWithValue("@Emp_estado", obj.EmpEstado);
            cmd.Parameters.AddWithValue("@codigo", obj.EmpCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "delete from Empresa where Emp_cod = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Empresa where Emp_nome like '%" +
                 valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloEmpresa CarregaModeloEmpresa(int codigo)
        {
            ModeloEmpresa modelo = new ModeloEmpresa();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "select * from Empresa where Emp_cod = @codigo";

            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.EmpCod = Convert.ToInt32(registro["Emp_cod"]);
                modelo.EmpNome = Convert.ToString(registro["Emp_nome"]);
                modelo.EmpCnpj = Convert.ToString(registro["Emp_cnpj"]);
                modelo.EmpIe = Convert.ToString(registro["Emp_ie"]);
                modelo.EmpRSocial = Convert.ToString(registro["Emp_rsocial"]);
                modelo.EmpCep = Convert.ToString(registro["Emp_cep"]);
                modelo.EmpEndereco = Convert.ToString(registro["Emp_endereco"]);
                modelo.EmpBairro = Convert.ToString(registro["Emp_bairro"]);
                modelo.EmpFone = Convert.ToString(registro["Emp_fone"]);
                modelo.EmpCelular = Convert.ToString(registro["Emp_cel"]);
                modelo.EmpEmail = Convert.ToString(registro["Emp_email"]);
                modelo.EmpEndNumero = Convert.ToString(registro["Emp_endnumero"]);
                modelo.EmpCidade = Convert.ToString(registro["Emp_cidade"]);
                modelo.EmpEstado = Convert.ToString(registro["Emp_estado"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

    }
}
