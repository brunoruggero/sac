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
    public class BLLBeneficio
    {

        private DAOConexao conexao;

        public BLLBeneficio(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloBeneficio modelo)
        {
            if (modelo.BenNome.Trim().Length == 0)
            {
                throw new Exception("O nome do benefício é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DAOBeneficio DALobj = new DAOBeneficio(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloBeneficio modelo)
        {
            if (modelo.BenCod <= 0)
            {
                throw new Exception("O código do benefício é obrigatório");
            }
            if (modelo.BenNome.Trim().Length == 0)
            {
                throw new Exception("O nome do benefício é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DAOBeneficio DALobj = new DAOBeneficio(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAOBeneficio DALobj = new DAOBeneficio(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DAOBeneficio DALobj = new DAOBeneficio(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloBeneficio CarregaModeloBeneficio(int codigo)
        {
            DAOBeneficio DALobj = new DAOBeneficio(conexao);
            return DALobj.CarregaModeloBeneficio(codigo);
        }

    }
}
