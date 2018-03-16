using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloNivelAcesso
    {
        public ModeloNivelAcesso()
        {
            this.RegraCod = 0;
            this.RegraNome = "";
        }

        public ModeloNivelAcesso(int regracod, String regranome)
        {
            this.RegraCod = regracod;
            this.RegraNome = regranome;
        }


        private int regra_cod;

        public int RegraCod
        {
            get { return this.regra_cod; }
            set { this.regra_cod = value; }
        }

        private String regra_nome;

        public String RegraNome
        {
            get { return this.regra_nome; }
            set { this.regra_nome = value; }
        }

    }
}
