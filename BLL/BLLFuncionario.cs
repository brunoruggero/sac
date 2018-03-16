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
    public class BLLFuncionario
    {

        private DAOConexao conexao;

        public BLLFuncionario(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFuncionario obj)
        {
            if (obj.FunMatricula.Trim().Length == 0)
            {
                throw new Exception("A Matricula é obrigatória.");
            }

            if (obj.FunNome.Trim().Length == 0)
            {
                throw new Exception("O nome do funcionário é obrigatório.");
            }

            if (obj.FunSalarioBase <= 0)
            {
                throw new Exception("O Salário Base é obrigatório");
            }

            //if (obj.FunFuncaoExercida.Trim().Length == 0)
            //{
            //    throw new Exception("A função é obrigatória.");
            //}
                           
            DAOFuncionario DALobj = new DAOFuncionario(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DAOFuncionario DALobj = new DAOFuncionario(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloFuncionario obj)
        {
            if (obj.FunMatricula.Trim().Length == 0)
            {
                throw new Exception("A Matricula é obrigatória.");
            }

            if (obj.FunNome.Trim().Length == 0)
            {
                throw new Exception("O nome do funcionário é obrigatório.");
            }

            if (obj.FunSalarioBase <= 0)
            {
                throw new Exception("O Salário Base é obrigatório");
            }

            if (obj.FunFuncaoExercida.Trim().Length == 0)
            {
                throw new Exception("A função é obrigatória.");
            }

            DAOFuncionario DALobj = new DAOFuncionario(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DAOFuncionario DALobj = new DAOFuncionario(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloFuncionario CarregaModeloFuncionario(int codigo)
        {
            DAOFuncionario DALobj = new DAOFuncionario(conexao);
            return DALobj.CarregaModeloFuncionario(codigo);
        }
    }
}
