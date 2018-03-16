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
    public class BLLCategoria
    {
        private DAOConexao conexao;

        public BLLCategoria(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DAOCategoria DALobj = new DAOCategoria(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DAOCategoria DALobj = new DAOCategoria(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAOCategoria DALobj = new DAOCategoria(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DAOCategoria DALobj = new DAOCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DAOCategoria DALobj = new DAOCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }
    }
}

