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
   public class BLLItensCompra
    {
        private DAOConexao conexao;

        public BLLItensCompra(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensCompra modelo)
        {
           if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatorio");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatorio");
            }

            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.ItcValor <= 0)
            {
                throw new Exception("O valor do item deve ser mais que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatorio");
            }

            DAOItensCompra DALobj = new DAOItensCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatorio");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatorio");
            }

            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }

            if (modelo.ItcValor <= 0)
            {
                throw new Exception("O valor do item deve ser mais que zero");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatorio");
            }

            DAOItensCompra DALobj = new DAOItensCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatorio");
            }

            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatorio");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatorio");
            }

            DAOItensCompra DALobj = new DAOItensCompra(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirTodosItens(int comcod)
        {
            DAOItensCompra DALobj = new DAOItensCompra(conexao);
            DALobj.ExcluirTodosItens(comcod);
        }

        public DataTable Localizar(int comcod)
        {
            DAOItensCompra DALobj = new DAOItensCompra(conexao);
            return DALobj.Localizar(comcod);
        }

        public ModeloItensCompra CarregaModeloItensCompra(int ItcCod, int ComCod, int ProCod)
        {
            DAOItensCompra DALobj = new DAOItensCompra(conexao);
            return DALobj.CarregaModeloItensCompra(ItcCod, ComCod, ProCod);
        }

   }
}
