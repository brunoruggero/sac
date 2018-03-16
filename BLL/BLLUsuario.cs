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
    public class BLLUsuario
    {
        
        private DAOConexao conexao;

        public BLLUsuario(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario obj)
        {
            if (obj.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório");
            }

            if (obj.UsuUsuario.Trim().Length == 0)
            {
                throw new Exception("O nome de login é obrigatória");
            }

            if (obj.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A senha é obrigatória");
            }

            if (obj.RegraNivel.Trim().Length == 0)
            {
                throw new Exception("O nível de acesso é obrigatório");
            }

            DAOUsuario DALobj = new DAOUsuario(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DAOUsuario DALobj = new DAOUsuario(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloUsuario obj)
        {
            if (obj.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório");
            }

            if (obj.UsuUsuario.Trim().Length == 0)
            {
                throw new Exception("O nome de login é obrigatória");
            }

            if (obj.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A senha é obrigatória");
            }

            if (obj.RegraNivel.Trim().Length == 0)
            {
                throw new Exception("O nível de acesso é obrigatório");
            }

            DAOUsuario DALobj = new DAOUsuario(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DAOUsuario DALobj = new DAOUsuario(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DAOUsuario DALobj = new DAOUsuario(conexao);
            return DALobj.CarregaModeloUsuario(codigo);
        }
    }
}
