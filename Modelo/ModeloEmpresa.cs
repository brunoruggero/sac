using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloEmpresa
    {

        //contrutores
        public ModeloEmpresa()
        {
            this.EmpCod = 0;
            this.EmpNome = "";
            this.EmpCnpj = "";
            this.EmpIe = "";
            this.EmpRSocial = "";
            this.EmpCep = "";
            this.EmpEndereco = "";
            this.EmpBairro = "";
            this.EmpFone = "";
            this.EmpCelular = "";
            this.EmpEmail = "";
            this.EmpEndNumero = "";
            this.EmpCidade = "";
            this.EmpEstado = "";
        }


        public ModeloEmpresa(int cod, string nome, string cnpj, string ie, string rsocial, string cep, string endereco,
            string bairro, string fone, string celular, string email, string endnumero, string cidade, string estado)
        {
            this.EmpCod = cod;
            this.EmpNome = nome;
            this.EmpCnpj = cnpj;
            this.EmpIe = ie;
            this.EmpRSocial = rsocial;
            this.EmpCep = cep;
            this.EmpEndereco = endereco;
            this.EmpBairro = bairro;
            this.EmpFone = fone;
            this.EmpCelular = celular;
            this.EmpEmail = email;
            this.EmpEndNumero = endnumero;
            this.EmpCidade = cidade;
            this.EmpEstado = estado;
        }


        //propriedades da classe
        private int Emp_cod;

        public int EmpCod
        {
            get { return this.Emp_cod; }
            set { this.Emp_cod = value; }
        }

        private string Emp_nome;

        public string EmpNome
        {
            get { return this.Emp_nome; }
            set { this.Emp_nome = value; }
        }

        private string Emp_cnpj;

        public string EmpCnpj
        {
            get { return this.Emp_cnpj; }
            set { this.Emp_cnpj = value; }
        }

        private string Emp_Ie;

        public string EmpIe
        {
            get { return this.Emp_Ie; }
            set { this.Emp_Ie = value; }
        }

        private string Emp_RSocial;

        public string EmpRSocial
        {
            get { return this.Emp_RSocial; }
            set { this.Emp_RSocial = value; }
        }

        private string Emp_cep;

        public string EmpCep
        {
            get { return this.Emp_cep; }
            set { this.Emp_cep = value; }
        }

        private string Emp_endereco;

        public string EmpEndereco
        {
            get { return this.Emp_endereco; }
            set { this.Emp_endereco = value; }
        }

        private string Emp_bairro;

        public string EmpBairro
        {
            get { return this.Emp_bairro; }
            set { this.Emp_bairro = value; }
        }

        private string Emp_fone;

        public string EmpFone
        {
            get { return this.Emp_fone; }
            set { this.Emp_fone = value; }
        }

        private string Emp_cel;

        public string EmpCelular
        {
            get { return this.Emp_cel; }
            set { this.Emp_cel = value; }
        }

        private string Emp_email;

        public string EmpEmail
        {
            get { return this.Emp_email; }
            set { this.Emp_email = value; }
        }

        private string Emp_endnumero;

        public string EmpEndNumero
        {
            get { return this.Emp_endnumero; }
            set { this.Emp_endnumero = value; }
        }

        private string Emp_cidade;

        public string EmpCidade
        {
            get { return this.Emp_cidade; }
            set { this.Emp_cidade = value; }
        }

        private string Emp_estado;

        public string EmpEstado
        {
            get { return this.Emp_estado; }
            set { this.Emp_estado = value; }
        }

    }
}
