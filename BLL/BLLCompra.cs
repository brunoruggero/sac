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
    public class BLLCompra
    {
        private DAOConexao conexao;

        public BLLCompra(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            //if (modelo.ComData != DateTime.Now)
            //{
            //    throw new Exception("Data da compra não corresponde a data atual.");
            //}

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("Número de parcelas deve ser maior que 0.");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("Código do fornecedor deve ser informado");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("Valor de compra deve ser informado");
            }

            DAOCompra DALobj = new DAOCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCompra modelo)
        {
            //if (modelo.ComData != DateTime.Now)
            //{
            //    throw new Exception("Data da compra não corresponde a data atual.");
            //}

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código de compra dever ser maior que 0.");
            }

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("Número de parcelas deve ser maior que 0.");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("Código do fornecedor deve ser informado");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("Valor de compra deve ser informado");
            }

            DAOCompra DALobj = new DAOCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAOCompra DALobj = new DAOCompra(conexao);
            DALobj.Excluir(codigo);
        }

        //localizar pelo código do fornecedor
        public DataTable Localizar(int codigo)
        {
            DAOCompra DALobj = new DAOCompra(conexao);
            return DALobj.Localizar(codigo);
        }

        //localizar pelo nome do fornecedor
        public DataTable Localizar(String nome)
        {
            DAOCompra DALobj = new DAOCompra(conexao);
            return DALobj.Localizar(nome);
        }

        //localizar todos os dados da tabela
        public DataTable LocalizarTodas()
        {
            DAOCompra DALobj = new DAOCompra(conexao);
            return DALobj.LocalizarTodas();
        }

        //localizar pelas parcelas em aberto
        public DataTable LocalizarParcelasAberto()
        {
            DAOCompra DALobj = new DAOCompra(conexao);
            return DALobj.LocalizarParcelasAberto();
        }
       
        //localizar pela data inicial e data final
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DAOCompra DALobj = new DAOCompra(conexao);
            return DALobj.Localizar(dtinicial, dtfinal);
        }

        //localizar a quantidade de parcelas não pagas
        public int QtdeParcelasNaoPagas(int Codigo)
        {
            DAOCompra DALobj = new DAOCompra(conexao);
            return DALobj.QtdeParcelasNaoPagas(Codigo);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DAOCompra DALobj = new DAOCompra(conexao);
            return DALobj.CarregaModeloCompra(codigo);
        }
    }
}

