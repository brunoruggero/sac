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
    public class BLLNivelAcesso
    {
        private DAOConexao conexao;

        public BLLNivelAcesso(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloNivelAcesso modelo)
        {
            if (modelo.RegraNome.Trim().Length == 0)
            {
                throw new Exception("O nome do nível de acesso é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DAONivelAcesso DALobj = new DAONivelAcesso(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloNivelAcesso modelo)
        {
            if (modelo.RegraCod <= 0)
            {
                throw new Exception("O código do nível de acesso é obrigatório");
            }
            if (modelo.RegraNome.Trim().Length == 0)
            {
                throw new Exception("O nome do nível de acesso é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DAONivelAcesso DALobj = new DAONivelAcesso(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAONivelAcesso DALobj = new DAONivelAcesso(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DAONivelAcesso DALobj = new DAONivelAcesso(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloNivelAcesso CarregaModeloNivelAcesso(int codigo)
        {
            DAONivelAcesso DALobj = new DAONivelAcesso(conexao);
            return DALobj.CarregaModeloNivelAcesso(codigo);
        }


    }
}
