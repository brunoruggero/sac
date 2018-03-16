using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAO;
using System.Data;

namespace BLL
{
    public class BLLSubCategoria
    {

        private DAOConexao conexao;

        public BLLSubCategoria(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }


            DAOSubCategoria DALobj = new DAOSubCategoria(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório");
            }
            DAOSubCategoria DALobj = new DAOSubCategoria(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAOSubCategoria DALobj = new DAOSubCategoria(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DAOSubCategoria DALobj = new DAOSubCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorCategoria(int categoria)
        {
            DAOSubCategoria DALobj = new DAOSubCategoria(conexao);
            return DALobj.LocalizarPorCategoria(categoria);
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            DAOSubCategoria DALobj = new DAOSubCategoria(conexao);
            return DALobj.CarregaModeloSubCategoria(codigo);
        }

    }
}
