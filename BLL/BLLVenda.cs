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
    public class BLLVenda
    {
        private DAOConexao conexao;

        public BLLVenda(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo)
        {
            if (modelo.VenNParcelas <= 0)
            {
                throw new Exception("Número de parcelas deve ser maior que 0.");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("Código do cliente deve ser informado");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("Valor de venda deve ser informado");
            }

            if(modelo.VenNFiscal <= 0)
            {
                throw new Exception("Número da nota fiscal deve ser informado");
            }

            DAOVenda DALobj = new DAOVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VenNParcelas <= 0)
            {
                throw new Exception("Número de parcelas deve ser maior que 0.");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("Código do cliente deve ser informado");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("Valor de venda deve ser informado");
            }

            if (modelo.VenNFiscal <= 0)
            {
                throw new Exception("Número da nota fiscal deve ser informado");
            }

            DAOVenda DALobj = new DAOVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("Número deve ser maior que 0.");
            }

            DAOVenda DALobj = new DAOVenda(conexao);
            DALobj.Excluir(codigo);
        }

        //cancelar venda
        public Boolean CancelarVenda(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("Número deve ser maior que 0.");
            }

            DAOVenda DALobj = new DAOVenda(conexao);
            return DALobj.CancelarVenda(codigo);
        }

        //localizar pelo código do cliente
        public DataTable Localizar(int codigo)
        {
            DAOVenda DALobj = new DAOVenda(conexao);
            return DALobj.Localizar(codigo);
        }

        //localizar pelo nome do cliente
        public DataTable Localizar(String nome)
        {
            DAOVenda DALobj = new DAOVenda(conexao);
            return DALobj.Localizar(nome);
        }

        //localizar todos os dados da tabela
        public DataTable LocalizarTodas()
        {
            DAOVenda DALobj = new DAOVenda(conexao);
            return DALobj.LocalizarTodas();
        }

        //localizar pelas parcelas em aberto
        public DataTable LocalizarParcelasAberto()
        {
            DAOVenda DALobj = new DAOVenda(conexao);
            return DALobj.LocalizarParcelasAberto();
        }

        //localizar pela data inicial e data final
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DAOVenda DALobj = new DAOVenda(conexao);
            return DALobj.Localizar(dtinicial, dtfinal);
        }

        //localizar a quantidade de parcelas não pagas
        public int QtdeParcelasNaoPagas(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("Número deve ser maior que 0.");
            }
            DAOVenda DALobj = new DAOVenda(conexao);
            return DALobj.QtdeParcelasNaoPagas(codigo);
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("Número deve ser maior que 0.");
            }
            DAOVenda DALobj = new DAOVenda(conexao);
            return DALobj.CarregaModeloVenda(codigo);
        }
    }
}
