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
    public class DAOItensVenda
    {
        private DAOConexao conexao;

        public DAOItensVenda(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "insert into itensvenda(itv_cod, itv_qtde, itv_valor, ven_cod, pro_cod) values (@itv_cod, @itv_qtde, @itv_valor, @ven_cod, @pro_cod);";
            cmd.Parameters.AddWithValue("@itv_cod", modelo.ItvCod);
            cmd.Parameters.AddWithValue("@itv_qtde", modelo.ItvQtde);
            cmd.Parameters.AddWithValue("@itv_valor", modelo.ItvValor);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
            cmd.ExecuteNonQuery();
        }

        public void Alterar(ModeloItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "update itensvenda set itv_qtde = @itv_qtde, itv_valor = @itv_valor " +
                "where itv_cod = @itv_cod and ven_cod = @ven_cod and pro_cod = @pro_cod;";
            cmd.Parameters.AddWithValue("@itv_cod", modelo.ItvCod);
            cmd.Parameters.AddWithValue("@itv_qtde", modelo.ItvQtde);
            cmd.Parameters.AddWithValue("@itv_valor", modelo.ItvValor);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(ModeloItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "delete from itensvenda where itv_cod = @itv_cod and ven_cod = @ven_cod and pro_cod = @pro_cod;";
            cmd.Parameters.AddWithValue("@itv_cod", modelo.ItvCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
            cmd.ExecuteNonQuery();
        }

        public void ExcluirTodosItens(int venCod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "delete from itensvenda where ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@ven_cod", venCod);
            cmd.ExecuteNonQuery();
        }

        //localizar todos os itens da venda
        public DataTable Localizar(int venCod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select i.ven_cod,i.itv_cod,i.pro_cod,p.pro_nome,i.itv_qtde,i.itv_valor" +
                " from itensvenda i inner join produto p on p.pro_cod = i.pro_cod where i.ven_cod = " + venCod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItensVenda CarregaModeloItensVenda(int ItvCod, int VenCod, int ProCod)
        {
            ModeloItensVenda modelo = new ModeloItensVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from itensvenda where itv_cod = @itv_cod and ven_cod = @ven_cod and pro_cod = @pro_cod;";
            cmd.Parameters.AddWithValue("@itv_cod", ItvCod);
            cmd.Parameters.AddWithValue("@ven_cod", VenCod);
            cmd.Parameters.AddWithValue("@pro_cod", ProCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItvCod = ItvCod;
                modelo.ProCod = ProCod;
                modelo.VenCod = VenCod;
                modelo.ItvQtde = Convert.ToDouble(registro["itv_qtde"]);
                modelo.ItvValor = Convert.ToDouble(registro["itv_valor"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

    }
}
