using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLParcelasVenda
    {
        private DAOConexao conexao;

        public BLLParcelasVenda(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("Código da parcela é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("Código da venda é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("Valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;

            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DAOParcelasVenda DALobj = new DAOParcelasVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("Código da parcela é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("Código da venda é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("Valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;

            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DAOParcelasVenda DALobj = new DAOParcelasVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("Código da parcela é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("Código da venda é obrigatório");
            }

            DAOParcelasVenda DALobj = new DAOParcelasVenda(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirTodasParcelas(int vencod)
        {
            if (vencod <= 0)
            {
                throw new Exception("Código da venda é obrigatório");
            }

            DAOParcelasVenda DALobj = new DAOParcelasVenda(conexao);
            DALobj.ExcluirTodasParcelas(vencod);
        }

        public DataTable Localizar(int vencod)
        {
            if (vencod <= 0)
            {
                throw new Exception("Código da venda é obrigatório");
            }

            DAOParcelasVenda DALobj = new DAOParcelasVenda(conexao);
            return DALobj.Localizar(vencod);
        }

        public ModeloParcelasVenda CarregaModeloParcelasVenda(int PveCod, int VenCod)
        {
            if (PveCod <= 0)
            {
                throw new Exception("Código da parcela é obrigatório");
            }

            if (VenCod <= 0)
            {
                throw new Exception("Código da venda é obrigatório");
            }

            DAOParcelasVenda DALobj = new DAOParcelasVenda(conexao);
            return DALobj.CarregaModeloParcelasVenda(PveCod, VenCod);
        }

        //metodo para efetuar o pagamento da parcela
        public void EfetuaRecebeParcela(int VenCod, int PveCod, DateTime dtRecebimento)
        {
            if (dtRecebimento != null)
            {
                DAOParcelasVenda DALobj = new DAOParcelasVenda(conexao);
                DALobj.EfetuaRecebeParcela(VenCod, PveCod, dtRecebimento);
            }
            else
            {
                throw new Exception("Data de recebimento obrigatória");
            }
        }
    }
}
