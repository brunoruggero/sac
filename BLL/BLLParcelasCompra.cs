using DAO;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLParcelasCompra
    {

        private DAOConexao conexao;

        public BLLParcelasCompra(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("Código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("Código da compra é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("Valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;

            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DAOParcelasCompra DALobj = new DAOParcelasCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("Código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("Código da compra é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("Valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;

            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DAOParcelasCompra DALobj = new DAOParcelasCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("Código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("Código da compra é obrigatório");
            }

            DAOParcelasCompra DALobj = new DAOParcelasCompra(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirTodasParcelas(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("Código da compra é obrigatório");
            }

            DAOParcelasCompra DALobj = new DAOParcelasCompra(conexao);
            DALobj.ExcluirTodasParcelas(comcod);
        }

        public DataTable Localizar(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("Código da compra é obrigatório");
            }

            DAOParcelasCompra DALobj = new DAOParcelasCompra(conexao);
            return DALobj.Localizar(comcod);
        }

        public ModeloParcelasCompra CarregaModeloParcelasCompra(int PcoCod, int ComCod)
        {
            if (PcoCod <= 0)
            {
                throw new Exception("Código da parcela é obrigatório");
            }

            if (ComCod <= 0)
            {
                throw new Exception("Código da compra é obrigatório");
            }

            DAOParcelasCompra DALobj = new DAOParcelasCompra(conexao);
            return DALobj.CarregaModeloParcelasCompra(PcoCod, ComCod);
        }

        //metodo para efetuar o pagamento da parcela
        public void EfetuaPagamentoParcela(int ComCod, int PcoCod, DateTime dtpagto)
        {
            /*
            DateTime data = DateTime.Now;
            if (dtpagto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            */
            if (dtpagto != null)
            {
                DAOParcelasCompra DALobj = new DAOParcelasCompra(conexao);
                DALobj.EfetuaPagamentoParcela(ComCod, PcoCod, dtpagto);
            }
            else
            {
                throw new Exception("Data de pagamento obrigatória");
            }
        }
    }
}
