using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFuncionario
    {

        public ModeloFuncionario()
        {
            this.FunCod = 0;
            this.FunNome = "";
            this.FunMatricula = "";
            this.FunCpf = "";
            this.FunRg = "";
            this.FunOrgaoEmissor = "";
            this.FunRgEmissao = DateTime.Now;
            this.FunDataNascimento = DateTime.Now;
            this.FunSexo = "";
            this.FunEstadoCivil = "";
            this.FunNumFilhos = 0;
            this.FunNomeConjuge = "";
            this.FunTelefone = "";
            this.FunCelular = "";
            this.FunFormacao = "";
            this.FunTituloEleitor = "";
            this.FunZonaEleitor = "";
            this.FunSecaoEleitor = "";
            this.FunEmissaoEleitor = DateTime.Now;
            this.FunReservista = "";
            this.FunCnh = "";
            this.FunEmissaoCnh = DateTime.Now;
            this.FunValidadeCnh = DateTime.Now;
            this.FunCategoriaCnh = "";
            this.FunNumCtps = "";
            this.FunSerieCtps = "";
            this.FunDataCtps = DateTime.Now;
            this.FunNumPis = "";
            this.FunFuncaoExercida = "";
            this.FunAdmissao = DateTime.Now;
            this.FunDemissao = "";
            this.FunSalarioBase = 0;
            this.FunSalarioExtra = 0;
            this.FunAjudaCusto = 0;
            this.FunCep = "";
            this.FunEndereco = "";
            this.FunBairro = "";
            this.FunEndNumero = "";
            this.FunCidade = "";
            this.FunEstado = "";
            this.FunBancoNome = "";
            this.FunBancoAgencia = "";
            this.FunBancoConta = "";
            this.FunBancoData = DateTime.Now;
            this.BenCod = 0;
        }

        public ModeloFuncionario(int fun_cod, String fun_nome, String fun_matricula, String fun_cpf, String fun_rg, String fun_orgaoemissor, DateTime fun_rgemissao,
            DateTime fun_datanascimento, String fun_sexo, String fun_estadocivil, int fun_numfilhos, String fun_nomeconjuge, String fun_telefone, String fun_celular, 
            String fun_formacao, String fun_tituloeleitor, String fun_zonaeleitor, String fun_secaoeleitor, DateTime fun_emissaoeleitor, String fun_reservista, String fun_cnh, 
            DateTime fun_emissaocnh, DateTime fun_validadecnh, String fun_categoriacnh, String fun_numctps, String fun_seriectps, DateTime fun_datacpts, String fun_numpis, String fun_funcaoexercida,
            DateTime fun_admissao, String fun_demissao, Double fun_salariobase, Double fun_salarioextra, Double fun_ajudacusto, String fun_cep, String fun_endereco, 
            String fun_bairro, String fun_endnumero, String fun_cidade, String fun_estado, String fun_banconome, String fun_bancoagencia, String fun_bancoconta, DateTime fun_bancodata, int ben_cod, 
            String fun_foto)
        {
            this.FunCod = fun_cod;
            this.FunNome = fun_nome;
            this.FunMatricula = fun_matricula;
            this.FunCpf = fun_cpf;
            this.FunRg = fun_rg;
            this.FunOrgaoEmissor = fun_orgaoemissor;
            this.FunRgEmissao = fun_rgemissao;
            this.FunDataNascimento = fun_datanascimento;
            this.FunSexo = fun_sexo;
            this.FunEstadoCivil = fun_estadocivil;
            this.FunNumFilhos = fun_numfilhos;
            this.FunNomeConjuge = fun_nomeconjuge;
            this.FunTelefone = fun_telefone;
            this.FunCelular = fun_celular;
            this.FunFormacao = fun_formacao;
            this.FunTituloEleitor = fun_tituloeleitor;
            this.FunZonaEleitor = fun_zonaeleitor;
            this.FunSecaoEleitor = fun_secaoeleitor;
            this.FunEmissaoEleitor = fun_emissaoeleitor;
            this.FunReservista = fun_reservista;
            this.FunCnh = fun_cnh;
            this.FunEmissaoCnh = fun_emissaocnh;
            this.FunValidadeCnh = fun_validadecnh;
            this.FunCategoriaCnh = fun_categoriacnh;
            this.FunNumCtps = fun_numctps;
            this.FunSerieCtps = fun_seriectps;
            this.FunDataCtps = fun_datacpts;
            this.FunNumPis = fun_numpis;
            this.FunFuncaoExercida = fun_funcaoexercida;
            this.FunAdmissao = fun_admissao;
            this.FunDemissao = fun_demissao;
            this.FunSalarioBase = fun_salariobase;
            this.FunSalarioExtra = fun_salarioextra;
            this.FunAjudaCusto = fun_ajudacusto;
            this.FunCep = fun_cep;
            this.FunEndereco = fun_endereco;
            this.FunBairro = fun_bairro;
            this.FunEndNumero = fun_endnumero;
            this.FunCidade = fun_cidade;
            this.FunEstado = fun_estado;
            this.FunBancoNome = fun_banconome;
            this.FunBancoAgencia = fun_bancoagencia;
            this.FunBancoConta = fun_bancoconta;
            this.FunBancoData = fun_bancodata;
            this.BenCod = ben_cod;
            this.CarregaImagem(fun_foto);
        }

        public ModeloFuncionario(int fun_cod, String fun_nome, String fun_matricula, String fun_cpf, String fun_rg, String fun_orgaoemissor, DateTime fun_rgemissao, DateTime fun_datanascimento,
            String fun_sexo, String fun_estadocivil, int fun_numfilhos, String fun_nomeconjuge, String fun_telefone, String fun_celular, String fun_formacao, String fun_tituloeleitor,
            String fun_zonaeleitor, String fun_secaoeleitor, DateTime fun_emissaoeleitor, String fun_reservista, String fun_cnh, DateTime fun_emissaocnh, DateTime fun_validadecnh,
            String fun_categoriacnh, String fun_numctps, String fun_seriectps, DateTime fun_datactps, String fun_numpis, String fun_funcaoexercida, DateTime fun_admissao, String fun_demissao,
            Double fun_salariobase, Double fun_salarioextra, Double fun_ajudacusto, String fun_cep, String fun_endereco, String fun_bairro, String fun_endnumero, String fun_cidade,
            String fun_estado, String fun_banconome, String fun_bancoagencia, String fun_bancoconta, DateTime fun_bancodata, int ben_cod, byte[] fun_foto)
        {
            this.FunCod = fun_cod;
            this.FunNome = fun_nome;
            this.FunMatricula = fun_matricula;
            this.FunCpf = fun_cpf;
            this.FunRg = fun_rg;
            this.FunOrgaoEmissor = fun_orgaoemissor;
            this.FunRgEmissao = fun_rgemissao;
            this.FunDataNascimento = fun_datanascimento;
            this.FunSexo = fun_sexo;
            this.FunEstadoCivil = fun_estadocivil;
            this.FunNumFilhos = fun_numfilhos;
            this.FunNomeConjuge = fun_nomeconjuge;
            this.FunTelefone = fun_telefone;
            this.FunCelular = fun_celular;
            this.FunFormacao = fun_formacao;
            this.FunTituloEleitor = fun_tituloeleitor;
            this.FunZonaEleitor = fun_zonaeleitor;
            this.FunSecaoEleitor = fun_secaoeleitor;
            this.FunEmissaoEleitor = fun_emissaoeleitor;
            this.FunReservista = fun_reservista;
            this.FunCnh = fun_cnh;
            this.FunEmissaoCnh = fun_emissaocnh;
            this.FunValidadeCnh = fun_validadecnh;
            this.FunCategoriaCnh = fun_categoriacnh;
            this.FunNumCtps = fun_numctps;
            this.FunSerieCtps = fun_seriectps;
            this.FunDataCtps = fun_datactps;
            this.FunNumPis = fun_numpis;
            this.FunFuncaoExercida = fun_funcaoexercida;
            this.FunAdmissao = fun_admissao;
            this.FunDemissao = fun_demissao;
            this.FunSalarioBase = fun_salariobase;
            this.FunSalarioExtra = fun_salarioextra;
            this.FunAjudaCusto = fun_ajudacusto;
            this.FunCep = fun_cep;
            this.FunEndereco = fun_endereco;
            this.FunBairro = fun_bairro;
            this.FunEndNumero = fun_endnumero;
            this.FunCidade = fun_cidade;
            this.FunEstado = fun_estado;
            this.FunBancoNome = fun_banconome;
            this.FunBancoAgencia = fun_bancoagencia;
            this.FunBancoConta = fun_bancoconta;
            this.FunBancoData = fun_bancodata;
            this.BenCod = ben_cod;
        }

        private int fun_cod;
        public int FunCod
        {
            get { return this.fun_cod; }
            set { this.fun_cod = value; }
        }

        private String fun_nome;
        public String FunNome
        {
            get { return this.fun_nome; }
            set
            {
                this.fun_nome = value;
            }
        }

        private String fun_matricula;
        public String FunMatricula
        {
            get { return this.fun_matricula; }
            set { this.fun_matricula = value; }
        }

        private String fun_cpf;
        public String FunCpf
        {
            get { return this.fun_cpf; }
            set { this.fun_cpf = value; }
        }

        private String fun_rg;
        public String FunRg
        {
            get { return this.fun_rg; }
            set { this.fun_rg = value; }
        }

        private String fun_orgaoemissor;
        public String FunOrgaoEmissor
        {
            get { return this.fun_orgaoemissor; }
            set { this.fun_orgaoemissor = value; }
        }

        private DateTime fun_rgemissao;
        public DateTime FunRgEmissao
        {
            get { return this.fun_rgemissao; }
            set { this.fun_rgemissao = value; }
        }

        private DateTime fun_datanascimento;
        public DateTime FunDataNascimento
        {
            get { return this.fun_datanascimento; }
            set { this.fun_datanascimento = value; }
        }

        private String fun_sexo;
        public String FunSexo
        {
            get { return this.fun_sexo; }
            set { this.fun_sexo = value; }
        }

        private String fun_estadocivil;
        public String FunEstadoCivil
        {
            get { return this.fun_estadocivil; }
            set { this.fun_estadocivil = value; }
        }

        private int fun_numfilhos;
        public int FunNumFilhos
        {
            get { return this.fun_numfilhos; }
            set { this.fun_numfilhos = value; }
        }

        private String fun_nomeconjuge;
        public String FunNomeConjuge
        {
            get { return this.fun_nomeconjuge; }
            set { this.fun_nomeconjuge = value; }
        }

        private String fun_telefone;
        public String FunTelefone
        {
            get { return this.fun_telefone; }
            set { this.fun_telefone = value; }
        }

        private String fun_celular;
        public String FunCelular
        {
            get { return this.fun_celular; }
            set { this.fun_celular = value; }
        }

        private String fun_formacao;
        public String FunFormacao
        {
            get { return this.fun_formacao; }
            set { this.fun_formacao = value; }
        }

        private String fun_tituloeleitor;
        public String FunTituloEleitor
        {
            get { return this.fun_tituloeleitor; }
            set { this.fun_tituloeleitor = value; }
        }

        private String fun_zonaeleitor;
        public String FunZonaEleitor
        {
            get { return this.fun_zonaeleitor; }
            set { this.fun_zonaeleitor = value; }
        }

        private String fun_secaoeleitor;
        public String FunSecaoEleitor
        {
            get { return this.fun_secaoeleitor; }
            set { this.fun_secaoeleitor = value; }
        }

        private DateTime fun_emissaoeleitor;
        public DateTime FunEmissaoEleitor
        {
            get { return this.fun_emissaoeleitor; }
            set { this.fun_emissaoeleitor = value; }
        }

        private String fun_reservista;
        public String FunReservista
        {
            get { return this.fun_reservista; }
            set { this.fun_reservista = value; }
        }

        private String fun_cnh;
        public String FunCnh
        {
            get { return this.fun_cnh; }
            set { this.fun_cnh = value; }
        }

        private DateTime fun_emissaocnh;
        public DateTime FunEmissaoCnh
        {
            get { return this.fun_emissaocnh; }
            set { this.fun_emissaocnh = value; }
        }

        private DateTime fun_validadecnh;
        public DateTime FunValidadeCnh
        {
            get { return this.fun_validadecnh; }
            set { this.fun_validadecnh = value; }
        }

        private String fun_categoriacnh;
        public String FunCategoriaCnh
        {
            get { return this.fun_categoriacnh; }
            set { this.fun_categoriacnh = value; }
        }

        private String fun_numctps;
        public String FunNumCtps
        {
            get { return this.fun_numctps; }
            set { this.fun_numctps = value; }
        }

        private String fun_seriectps;
        public String FunSerieCtps
        {
            get { return this.fun_seriectps; }
            set { this.fun_seriectps = value; }
        }

        private DateTime fun_datactps;
        public DateTime FunDataCtps
        {
            get { return this.fun_datactps; }
            set { this.fun_datactps = value; }
        }

        private String fun_numpis;
        public String FunNumPis
        {
            get { return this.fun_numpis; }
            set { this.fun_numpis = value; }
        }

        private String fun_funcaoexercida;
        public String FunFuncaoExercida
        {
            get { return this.fun_funcaoexercida; }
            set { this.fun_funcaoexercida = value; }
        }

        private DateTime fun_admissao;
        public DateTime FunAdmissao
        {
            get { return this.fun_admissao; }
            set { this.fun_admissao = value; }
        }

        private String fun_demissao;
        public String FunDemissao
        {
            get { return this.fun_demissao; }
            set { this.fun_demissao = value; }
        }

        private Double fun_salariobase;
        public Double FunSalarioBase
        {
            get { return this.fun_salariobase; }
            set { this.fun_salariobase = value; }
        }

        private Double fun_salarioextra;
        public Double FunSalarioExtra
        {
            get { return this.fun_salarioextra; }
            set { this.fun_salarioextra = value; }
        }

        private Double fun_ajudacusto;
        public Double FunAjudaCusto
        {
            get { return this.fun_ajudacusto; }
            set { this.fun_ajudacusto = value; }
        }

        private String fun_cep;
        public String FunCep
        {
            get { return this.fun_cep; }
            set { this.fun_cep = value; }
        }

        private String fun_endereco;
        public String FunEndereco
        {
            get { return this.fun_endereco; }
            set { this.fun_endereco = value; }
        }

        private String fun_bairro;
        public String FunBairro
        {
            get { return this.fun_bairro; }
            set { this.fun_bairro = value; }
        }

        private String fun_endnumero;
        public String FunEndNumero
        {
            get { return this.fun_endnumero; }
            set { this.fun_endnumero = value; }
        }

        private String fun_cidade;
        public String FunCidade
        {
            get { return this.fun_cidade; }
            set { this.fun_cidade = value; }
        }

        private String fun_estado;
        public String FunEstado
        {
            get { return this.fun_estado; }
            set { this.fun_estado = value; }
        }

        private String fun_banconome;
        public String FunBancoNome
        {
            get { return this.fun_banconome; }
            set { this.fun_banconome = value; }
        }

        private String fun_bancoagencia;
        public String FunBancoAgencia
        {
            get { return this.fun_bancoagencia; }
            set { this.fun_bancoagencia = value; }
        }

        private String fun_bancoconta;
        public String FunBancoConta
        {
            get { return this.fun_bancoconta; }
            set { this.fun_bancoconta = value; }
        }

        private DateTime fun_bancodata;
        public DateTime FunBancoData
        {
            get { return this.fun_bancodata; }
            set { this.fun_bancodata = value; }
        }

        private int ben_cod;
        public int BenCod
        {
            get { return this.ben_cod; }
            set { this.ben_cod = value; }
        }

        private byte[] fun_foto;
        public byte[] FunFoto
        {
            get { return this.fun_foto; }
            set { this.fun_foto = value; }
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
                this.FunFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.FunFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
