using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloBeneficio
    {

        public ModeloBeneficio()
        {
            this.BenCod = 0;
            this.BenNome = "";
        }

        public ModeloBeneficio(int bencod, String nome)
        {
            this.BenCod = bencod;
            this.BenNome = nome;
        }


        private int ben_cod;

        public int BenCod
        {
            get { return this.ben_cod; }
            set { this.ben_cod = value; }
        }

        private String ben_nome;

        public String BenNome
        {
            get { return this.ben_nome; }
            set { this.ben_nome = value; }
        }
    }
}
