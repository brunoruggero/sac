using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAO;
using System.Data;

namespace BLL
{
   public class BLLUnidadeMedida
    {
        private DAOConexao conexao;

        public BLLUnidadeMedida(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeMedida modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }

            DAOUnidadeMedida DALobj = new DAOUnidadeMedida(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloUnidadeMedida modelo)
        {
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }

            DAOUnidadeMedida DALobj = new DAOUnidadeMedida(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DAOUnidadeMedida DALobj = new DAOUnidadeMedida(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DAOUnidadeMedida DALobj = new DAOUnidadeMedida(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaUnidadeDeMedida(String valor) //0 - não existe || numero > 0 existe
        {
            DAOUnidadeMedida DALobj = new DAOUnidadeMedida(conexao);
            return DALobj.VerificaUnidadeDeMedida(valor);
        }

        public ModeloUnidadeMedida CarregaModeloUnidadeMedida(int codigo)
        {
            DAOUnidadeMedida DALobj = new DAOUnidadeMedida(conexao);
            return DALobj.CarregaModeloUnidadeDeMedida(codigo);
        }
    }
}
