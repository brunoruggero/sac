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
    public class BLLCliente
    {
        private DAOConexao conexao;

        public BLLCliente(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ do cliente é obrigatório");
            }

            //verificar CPF/CNPJ
            if (modelo.CliTipo == "Física")
            {
                //cpf
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("CPF inválido");
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("CNPJ inválido");
                }
            }

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatório");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }

            if (modelo.CliCelular.Trim().Length == 0)
            {
                throw new Exception("O celular do cliente é obrigatório");
            }
            
            //validação do e-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("Informe um e-mail válido.");
            }

            //valida cep
            //if (Validacao.ValidaCep(modelo.CliCep) == false)
            //{
            //    throw new Exception("CEP inválido");
            //}

            DAOCliente DALobj = new DAOCliente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ do cliente é obrigatório");
            }

            //verificar CPF/CNPJ
            if (modelo.CliTipo == "Física")
            {
                //cpf
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("CPF inválido");
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("CNPJ inválido");
                }
            }

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatório");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }

            if (modelo.CliCelular.Trim().Length == 0)
            {
                throw new Exception("O celular do cliente é obrigatório");
            }

            //validação do e-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("Informe um e-mail válido.");
            }
            
            DAOCliente DALobj = new DAOCliente(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAOCliente DALobj = new DAOCliente(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DAOCliente DALobj = new DAOCliente(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DAOCliente DALobj = new DAOCliente(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCPFCNPJ(String valor)
        {
            DAOCliente DALobj = new DAOCliente(conexao);
            return DALobj.LocalizarPorCPFCNPJ(valor);
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DAOCliente DALobj = new DAOCliente(conexao);
            return DALobj.CarregaModeloCliente(codigo);
        }

        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            DAOCliente DALobj = new DAOCliente(conexao);
            return DALobj.CarregaModeloCliente(cpfcnpj);
        }
    }
}
