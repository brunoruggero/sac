using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Modelo;
using System.Data;
using Ferramentas;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLFornecedor
    {
        private DAOConexao conexao;

        public BLLFornecedor(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ do Fornecedor é obrigatório");
            }

           //cnpj
           if (Validacao.IsCnpj(modelo.ForCnpj) == false)
           {
                    throw new Exception("CNPJ inválido");
           }
           

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do Fornecedor é obrigatório");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do Fornecedor é obrigatório");
            }

            if (modelo.ForCelular.Trim().Length == 0)
            {
                throw new Exception("O celular do Fornecedor é obrigatório");
            }

            //validação do e-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Informe um e-mail válido.");
            }

            //valida cep
            //if (Validacao.ValidaCep(modelo.ForCep) == false)
            //{
            //    throw new Exception("CEP inválido");
            //}

            DAOFornecedor DALobj = new DAOFornecedor(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do Fornecedor é obrigatório");
            }

            //verificar CPF/CNPJ

            //cnpj
            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("CNPJ inválido");
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do Fornecedor é obrigatório");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do Fornecedor é obrigatório");
            }

            if (modelo.ForCelular.Trim().Length == 0)
            {
                throw new Exception("O celular do Fornecedor é obrigatório");
            }

            //validação do e-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Informe um e-mail válido.");
            }

            DAOFornecedor DALobj = new DAOFornecedor(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAOFornecedor DALobj = new DAOFornecedor(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DAOFornecedor DALobj = new DAOFornecedor(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DAOFornecedor DALobj = new DAOFornecedor(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCNPJ(String valor)
        {
            DAOFornecedor DALobj = new DAOFornecedor(conexao);
            return DALobj.LocalizarPorCNPJ(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DAOFornecedor DALobj = new DAOFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(codigo);
        }

        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            DAOFornecedor DALobj = new DAOFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(cnpj);
        }
    }
}
