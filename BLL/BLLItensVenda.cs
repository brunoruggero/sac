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
    public class BLLItensVenda
    {
        private DAOConexao conexao;

        public BLLItensVenda(DAOConexao cx)
        {
            this.conexao = cx;
        }
        
        public void Incluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatorio");
            }

            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatorio");
            }

            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor do item deve ser mais que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatorio");
            }

            DAOItensVenda DALobj = new DAOItensVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatorio");
            }

            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatorio");
            }

            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor do item deve ser mais que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatorio");
            }

            DAOItensVenda DALobj = new DAOItensVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatorio");
            }

            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatorio");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatorio");
            }

            DAOItensVenda DALobj = new DAOItensVenda(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirTodosItens(int vencod)
        {
            DAOItensVenda DALobj = new DAOItensVenda(conexao);
            DALobj.ExcluirTodosItens(vencod);
        }

        public DataTable Localizar(int vencod)
        {
            DAOItensVenda DALobj = new DAOItensVenda(conexao);
            return DALobj.Localizar(vencod);
        }

        public ModeloItensVenda CarregaModeloItensVenda(int ItvCod, int VenCod, int ProCod)
        {
            DAOItensVenda DALobj = new DAOItensVenda(conexao);
            return DALobj.CarregaModeloItensVenda(ItvCod, VenCod, ProCod);
        }
        
    }
}
