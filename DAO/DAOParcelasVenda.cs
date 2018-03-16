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
    public class DAOParcelasVenda
    {

        private DAOConexao conexao;

        public DAOParcelasVenda(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "insert into parcelasvenda(pve_cod, ven_cod, pve_datavecto, pve_valor) values (@pve_cod, @ven_cod, @pve_datavecto, @pve_valor);";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
            cmd.Parameters.Add("@pve_datavecto", System.Data.SqlDbType.Date);

            if (modelo.PveDataVecto == null)
            {
                cmd.Parameters["@pve_datavecto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pve_datavecto"].Value = modelo.PveDataVecto;
            }

            cmd.ExecuteNonQuery();
        }

        public void Alterar(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "update parcelasvenda set pve_valor = @pve_valor, pve_datapagto = @pve_datapagto, pve_datavecto = @pve_datavecto " +
                "where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
            cmd.Parameters.Add("@pve_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters.Add("@pve_datavecto", System.Data.SqlDbType.Date);

            if (modelo.PveDataPagto == null)
            {
                cmd.Parameters["@pve_datapagto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pve_datapagto"].Value = modelo.PveDataPagto;
            }

            cmd.Parameters["@pve_datavecto"].Value = modelo.PveDataVecto;

            cmd.ExecuteNonQuery();
        }

        public void Excluir(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "delete from parcelasvenda where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.ExecuteNonQuery();
        }

        public void ExcluirTodasParcelas(int vencod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "delete from parcelasvenda where ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@ven_cod", vencod);
            cmd.ExecuteNonQuery();
        }

        public DataTable Localizar(int vencod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from parcelasvenda where ven_cod = " + vencod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelasVenda CarregaModeloParcelasVenda(int PveCod, int VenCod)
        {
            ModeloParcelasVenda modelo = new ModeloParcelasVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelasvenda where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", VenCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PveCod = PveCod;
                modelo.VenCod = VenCod;
                modelo.PveDataPagto = Convert.ToDateTime(registro["pve_datapagto"]);
                modelo.PveDataVecto = Convert.ToDateTime(registro["pve_datavecto"]);
                modelo.PveValor = Convert.ToDouble(registro["pve_valor"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        //metodo para efetuar o recebimento da parcela
        public void EfetuaRecebeParcela(int VenCod, int PveCod, DateTime dtRecebimento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update parcelasvenda set pve_datapagto = @pve_datapagto where pve_cod = @pve_cod and ven_cod = @ven_cod;";

            cmd.Parameters.AddWithValue("@pve_cod", PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", VenCod);
            cmd.Parameters.Add("@pve_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters["@pve_datapagto"].Value = dtRecebimento;

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
