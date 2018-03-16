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
    public class BLLTipoPagamento
    {
        private DAOConexao conexao;

        public BLLTipoPagamento(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo do pagamento é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DAOTipoPagamento DALobj = new DAOTipoPagamento(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório");
            }
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DAOTipoPagamento DALobj = new DAOTipoPagamento(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAOTipoPagamento DALobj = new DAOTipoPagamento(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DAOTipoPagamento DALobj = new DAOTipoPagamento(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            DAOTipoPagamento DALobj = new DAOTipoPagamento(conexao);
            return DALobj.CarregaModeloTipoPagamento(codigo);
        }
    }
}
