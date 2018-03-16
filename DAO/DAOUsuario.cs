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
    public class DAOUsuario
    {

        private DAOConexao conexao;

        public DAOUsuario(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Usuario (usu_nome, usu_usuario, usu_senha, usu_foto, regra_nivel) " +
            "values (@nome,@usuario,@senha,@foto,@regranivel); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", obj.UsuNome);
            cmd.Parameters.AddWithValue("@usuario", obj.UsuUsuario);
            cmd.Parameters.AddWithValue("@senha", obj.UsuSenha);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.UsuFoto == null)
            {
                //cmd.Parameters.AddWithValue("@pro_foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@pro_foto", obj.pro_foto);
                cmd.Parameters["@foto"].Value = obj.UsuFoto;
            }
            cmd.Parameters.AddWithValue("@regranivel", obj.RegraNivel);
            conexao.Conectar();
            obj.UsuCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Usuario where usu_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloUsuario obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Usuario SET usu_nome = (@nome), usu_usuario = (@usuario), " +
                "usu_senha = (@senha), usu_foto = (@foto), regra_nivel = (@regranivel) WHERE usu_cod = (@codigo) ";
            cmd.Parameters.AddWithValue("@nome", obj.UsuNome);
            cmd.Parameters.AddWithValue("@usuario", obj.UsuUsuario);
            cmd.Parameters.AddWithValue("@senha", obj.UsuSenha);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.UsuFoto == null)
            {
                //cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@foto", obj.pro_foto);
                cmd.Parameters["@foto"].Value = obj.UsuFoto;
            }
            cmd.Parameters.AddWithValue("@regranivel", obj.RegraNivel);
            cmd.Parameters.AddWithValue("@codigo", obj.UsuCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloUsuario obj, Boolean transacao)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Usuario SET usu_nome = (@nome), usu_usuario = (@usuario), " +
                "usu_senha = (@senha), usu_foto = (@foto), regra_nivel = (@regranivel) WHERE usu_cod = (@codigo) ";
            cmd.Parameters.AddWithValue("@nome", obj.UsuNome);
            cmd.Parameters.AddWithValue("@usuario", obj.UsuUsuario);
            cmd.Parameters.AddWithValue("@senha", obj.UsuSenha); ;
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.UsuFoto == null)
            {
                //cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@foto", obj.pro_foto);
                cmd.Parameters["@foto"].Value = obj.UsuFoto;
            }
            cmd.Parameters.AddWithValue("@regranivel", obj.RegraNivel);
            cmd.Parameters.AddWithValue("@codigo", obj.UsuCod);
            if (transacao)
            {
                cmd.Transaction = conexao.ObejtoTransacao;
                cmd.ExecuteNonQuery();
            }
            else
            {
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from usuario where usu_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Usuario where usu_cod =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UsuCod = Convert.ToInt32(registro["usu_cod"]);
                modelo.UsuNome = Convert.ToString(registro["usu_nome"]);
                modelo.UsuUsuario = Convert.ToString(registro["usu_usuario"]);
                modelo.UsuSenha = Convert.ToString(registro["usu_senha"]);
                try
                {
                    modelo.UsuFoto = (byte[])registro["usu_foto"];

                }
                catch { }
                modelo.RegraNivel = Convert.ToString(registro["regra_nivel"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo, Boolean transacao)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Usuario where usu_cod =" + codigo.ToString();
            if (transacao == false)
            {
                conexao.Conectar();
            }
            else
            {
                cmd.Transaction = conexao.ObejtoTransacao;
            }
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UsuCod = Convert.ToInt32(registro["usu_cod"]);
                modelo.UsuNome = Convert.ToString(registro["usu_nome"]);
                modelo.UsuUsuario = Convert.ToString(registro["usu_usuario"]);
                modelo.UsuSenha = Convert.ToString(registro["usu_senha"]);
                try
                {
                    modelo.UsuFoto = (byte[])registro["usu_foto"];

                }
                catch { }
                modelo.RegraNivel = Convert.ToString(registro["regra_nivel"]);
            }
            registro.Close();
            if (transacao == false)
            {
                conexao.Desconectar();
            }

            return modelo;
        }

    }
}
