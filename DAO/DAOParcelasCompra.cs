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
    public class DAOParcelasCompra
    {
        private DAOConexao conexao;

        public DAOParcelasCompra(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "insert into parcelascompra(pco_cod, com_cod, pco_datavecto, pco_valor) values (@pco_cod, @com_cod, @pco_datavecto, @pco_valor);";

            cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@pco_valor", modelo.PcoValor);
            cmd.Parameters.Add("@pco_datavecto", System.Data.SqlDbType.Date);
           
            if (modelo.PcoDataVecto == null)
            {
                cmd.Parameters["@pco_datavecto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pco_datavecto"].Value = modelo.PcoDataVecto;
            }

           // conexao.Conectar();
            cmd.ExecuteNonQuery();
           // conexao.Desconectar();
        }

        public void Alterar(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "update parcelascompra set pco_valor = @pco_valor, pco_datapagto = @pco_datapagto, pco_datavecto = @pco_datavecto " +
                "where pco_cod = @pco_cod and com_cod = @com_cod;";

            cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@pco_valor", modelo.PcoValor);
            cmd.Parameters.Add("@pco_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters.Add("@pco_datavecto", System.Data.SqlDbType.Date);

            if (modelo.PcoDataPagto == null)
            {
                cmd.Parameters["@pco_datapagto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pco_datapagto"].Value = modelo.PcoDataPagto;
            }

            cmd.Parameters["@pco_datavecto"].Value = modelo.PcoDataVecto;

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Excluir(ModeloParcelasCompra modelo)
        {
            //MySqlCommand cmd = new MySqlCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "delete from parcelascompra where pco_cod = @pco_cod and com_cod = @com_cod;";
            cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void ExcluirTodasParcelas(int comcod)
        {
            //MySqlCommand cmd = new MySqlCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObejtoTransacao;
            cmd.CommandText = "delete from parcelascompra where com_cod = @com_cod;";
            cmd.Parameters.AddWithValue("@com_cod", comcod);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from parcelascompra where com_cod = " + comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelasCompra CarregaModeloParcelasCompra(int PcoCod, int ComCod)
        {
            ModeloParcelasCompra modelo = new ModeloParcelasCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelascompra where pco_cod = @pco_cod and com_cod = @com_cod;";
            cmd.Parameters.AddWithValue("@pco_cod", PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", ComCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PcoCod = PcoCod;
                modelo.ComCod = ComCod;
                modelo.PcoDataPagto = Convert.ToDateTime(registro["pco_datapagto"]);
                modelo.PcoDataVecto = Convert.ToDateTime(registro["pco_datavecto"]);
                modelo.PcoValor = Convert.ToDouble(registro["pco_valor"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        //metodo para efetuar o pagamento da parcela
        public void EfetuaPagamentoParcela(int ComCod, int PcoCod, DateTime dtpagto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update parcelascompra set pco_datapagto = @pco_datapagto where pco_cod = @pco_cod and com_cod = @com_cod;";

            cmd.Parameters.AddWithValue("@pco_cod", PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", ComCod);
            cmd.Parameters.Add("@pco_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters["@pco_datapagto"].Value = dtpagto;
            
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
