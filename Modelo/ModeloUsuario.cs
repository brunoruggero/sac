using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        public ModeloUsuario()
        {
            this.UsuCod = 0;
            this.UsuNome = "";
            this.UsuUsuario = "";
            this.UsuSenha = "";
            //null
            //this.RegraCod = 0;
            this.RegraNivel = "";
        }

        public ModeloUsuario(int usu_cod, String usu_nome, String usu_usuario, String usu_senha,
          String usu_foto, /*int regra_cod*/ String regra_nivel)
        {
            this.UsuCod = usu_cod;
            this.UsuNome = usu_nome;
            this.UsuUsuario = usu_usuario;
            this.UsuSenha = usu_senha;
            this.CarregaImagem(usu_foto);
            //this.RegraCod = regra_cod;
            this.RegraNivel = regra_nivel;
        }

        public ModeloUsuario(int usu_cod, String usu_nome, String usu_usuario, String usu_senha,
            Byte[] usu_foto, /*int regra_cod*/ String regra_nivel)
        {
            this.UsuCod = usu_cod;
            this.UsuNome = usu_nome;
            this.UsuUsuario = usu_usuario;
            this.UsuSenha = usu_senha;
            this.UsuFoto = usu_foto;
            //this.RegraCod = regra_cod;
            this.RegraNivel = regra_nivel;
        }

        private int _usu_cod;
        public int UsuCod
        {
            get
            {
                return this._usu_cod;
            }
            set
            {
                this._usu_cod = value;
            }
        }

        private String _usu_nome;
        public String UsuNome
        {
            get
            {
                return this._usu_nome;
            }
            set
            {
                this._usu_nome = value;
            }
        }

        private String _usu_usuario;
        public String UsuUsuario
        {
            get
            {
                return this._usu_usuario;
            }
            set
            {
                this._usu_usuario = value;
            }
        }

        private String _usu_senha;
        public String UsuSenha
        {
            get
            {
                return this._usu_senha;
            }
            set
            {
                this._usu_senha = value;
            }
        }

        private byte[] _usu_foto;
        public byte[] UsuFoto
        {
            get { return this._usu_foto; }
            set { this._usu_foto = value; }
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.UsuFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.UsuFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /*private int _regra_cod;
        public int RegraCod
        {
            get
            {
                return this._regra_cod;
            }
            set
            {
                this._regra_cod = value;
            }
        }*/

        private String _regra_nivel;
        public String RegraNivel
        {
            get
            {
                return this._regra_nivel;
            }
            set
            {
                this._regra_nivel = value;
            }
        }
    }
}
