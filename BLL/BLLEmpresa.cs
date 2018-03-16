using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DAO;
using System.Data;

namespace BLL
{
    public class BLLEmpresa
    {

        private DAOConexao conexao;

        public BLLEmpresa(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloEmpresa modelo)
        {
            if (modelo.EmpNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Empresa é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            if (modelo.EmpCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ da Empresa é obrigatório");
            }

            //cnpj
            if (Validacao.IsCnpj(modelo.EmpCnpj) == false)
            {
                throw new Exception("CNPJ inválido");
            }

            if (modelo.EmpFone.Trim().Length == 0)
            {
                throw new Exception("O telefone da Empresa é obrigatório");
            }

            //validação do e-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.EmpEmail))
            {
                throw new Exception("Informe um e-mail válido.");
            }

            //valida cep
            //if (Validacao.ValidaCep(modelo.ForCep) == false)
            //{
            //    throw new Exception("CEP inválido");
            //}

            DAOEmpresa DALobj = new DAOEmpresa(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloEmpresa modelo)
        {
            if (modelo.EmpNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Empresa é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            if (modelo.EmpCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ da Empresa é obrigatório");
            }

            //cnpj
            if (Validacao.IsCnpj(modelo.EmpCnpj) == false)
            {
                throw new Exception("CNPJ inválido");
            }

            if (modelo.EmpFone.Trim().Length == 0)
            {
                throw new Exception("O telefone da Empresa é obrigatório");
            }

            //validação do e-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.EmpEmail))
            {
                throw new Exception("Informe um e-mail válido.");
            }

            //valida cep
            //if (Validacao.ValidaCep(modelo.ForCep) == false)
            //{
            //    throw new Exception("CEP inválido");
            //}

            DAOEmpresa DALobj = new DAOEmpresa(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAOEmpresa DALobj = new DAOEmpresa(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DAOEmpresa DALobj = new DAOEmpresa(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloEmpresa CarregaModeloEmpresa(int codigo)
        {
            DAOEmpresa DALobj = new DAOEmpresa(conexao);
            return DALobj.CarregaModeloEmpresa(codigo);
        }        
    }
}
