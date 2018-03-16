using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOFuncionario
    {
        private DAOConexao conexao;

        public DAOFuncionario(DAOConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFuncionario obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into funcionario (fun_matricula, fun_nome, fun_cpf, fun_rg, fun_orgaoemissor, fun_rgemissao, fun_datanascimento, fun_sexo, fun_estadocivil, fun_numfilhos, " +
            "fun_nomeconjuge, fun_telefone, fun_celular, fun_formacao, fun_tituloeleitor, fun_zonaeleitor, fun_secaoeleitor, fun_emissaoeleitor, fun_reservista, fun_cnh, " +
            "fun_emissaocnh, fun_validadecnh, fun_categoriacnh, fun_numctps, fun_seriectps, fun_datactps, fun_numpis, fun_funcaoexercida, fun_admissao, fun_demissao, fun_salariobase, " +
            "fun_salarioextra, fun_ajudacusto, fun_cep, fun_endereco, fun_bairro, fun_endnumero, fun_cidade, fun_estado, fun_banconome, fun_bancoagencia, fun_bancoconta, fun_bancodata, " +
            "ben_cod, fun_foto) values (@matricula, @nome, @cpf, @rg, @orgaoemissor, @rgemissao, @datanascimento, @sexo, @estadocivil, " +
            "@numfilhos, @nomeconjuge, @telefone, @celular, @formacao, @tituloeleitor, @zonaeleitor, @secaoeleitor, @emissaoeleitor," +
            "@reservista, @cnh, @emissaocnh, @validadecnh, @categoriacnh, @numctps, @seriectps, @datactps, @numpis, @funcaoexercida, @admissao," +
            "@demissao, @salariobase, @salarioextra, @ajudacusto, @cep, @endereco, @bairro, @endnumero, @cidade, @estado, @banconome," +
            "@bancoagencia, @bancoconta, @bancodata, @bencod, @foto); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@matricula", obj.FunMatricula);
            cmd.Parameters.AddWithValue("@nome", obj.FunNome);
            cmd.Parameters.AddWithValue("@cpf", obj.FunCpf);
            cmd.Parameters.AddWithValue("@rg", obj.FunRg);
            cmd.Parameters.AddWithValue("@orgaoemissor", obj.FunOrgaoEmissor);

            cmd.Parameters.Add("@rgemissao", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@rgemissao"].Value = obj.FunRgEmissao;

            cmd.Parameters.Add("@datanascimento", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@datanascimento"].Value = obj.FunDataNascimento;

            cmd.Parameters.AddWithValue("@sexo", obj.FunSexo);
            cmd.Parameters.AddWithValue("@estadocivil", obj.FunEstadoCivil);
            cmd.Parameters.AddWithValue("@numfilhos", obj.FunNumFilhos);
            cmd.Parameters.AddWithValue("@nomeconjuge", obj.FunNomeConjuge);
            cmd.Parameters.AddWithValue("@telefone", obj.FunTelefone);
            cmd.Parameters.AddWithValue("@celular", obj.FunCelular);
            cmd.Parameters.AddWithValue("@formacao", obj.FunFormacao);
            cmd.Parameters.AddWithValue("@tituloeleitor", obj.FunTituloEleitor);
            cmd.Parameters.AddWithValue("@zonaeleitor", obj.FunZonaEleitor);
            cmd.Parameters.AddWithValue("@secaoeleitor", obj.FunSecaoEleitor);

            cmd.Parameters.Add("@emissaoeleitor", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@emissaoeleitor"].Value = obj.FunEmissaoEleitor;

            cmd.Parameters.AddWithValue("@reservista", obj.FunReservista);
            cmd.Parameters.AddWithValue("@cnh", obj.FunCnh);

            cmd.Parameters.Add("@emissaocnh", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@emissaocnh"].Value = obj.FunEmissaoCnh;

            cmd.Parameters.Add("@validadecnh", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@validadecnh"].Value = obj.FunValidadeCnh;

            cmd.Parameters.AddWithValue("@categoriacnh", obj.FunCategoriaCnh);
            cmd.Parameters.AddWithValue("@numctps", obj.FunNumCtps);
            cmd.Parameters.AddWithValue("@seriectps", obj.FunSerieCtps);

            cmd.Parameters.Add("@datactps", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@datactps"].Value = obj.FunDataCtps;

            cmd.Parameters.AddWithValue("@numpis", obj.FunNumPis);
            cmd.Parameters.AddWithValue("@funcaoexercida", obj.FunFuncaoExercida);
            
            cmd.Parameters.Add("@admissao", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@admissao"].Value = obj.FunAdmissao;

            cmd.Parameters.AddWithValue("@demissao", obj.FunDemissao);
            cmd.Parameters.AddWithValue("@salariobase", obj.FunSalarioBase);
            cmd.Parameters.AddWithValue("@salarioextra", obj.FunSalarioExtra);
            cmd.Parameters.AddWithValue("@ajudacusto", obj.FunAjudaCusto);
            cmd.Parameters.AddWithValue("@cep", obj.FunCep);
            cmd.Parameters.AddWithValue("@endereco", obj.FunEndereco);
            cmd.Parameters.AddWithValue("@bairro", obj.FunBairro);
            cmd.Parameters.AddWithValue("@endnumero", obj.FunEndNumero);
            cmd.Parameters.AddWithValue("@cidade", obj.FunCidade);
            cmd.Parameters.AddWithValue("@estado", obj.FunEstado);
            cmd.Parameters.AddWithValue("@banconome", obj.FunBancoNome);
            cmd.Parameters.AddWithValue("@bancoagencia", obj.FunBancoAgencia);
            cmd.Parameters.AddWithValue("@bancoconta", obj.FunBancoConta);

            cmd.Parameters.Add("@bancodata", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@bancodata"].Value = obj.FunBancoData;

            cmd.Parameters.AddWithValue("@bencod", obj.BenCod);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.FunFoto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = obj.FunFoto;
            }
            conexao.Conectar();
            obj.FunCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from funcionario where fun_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloFuncionario obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE funcionario SET (fun_matricula = @matricula, fun_nome = @nome, fun_cpf = @cpf, fun_rg = @rg, fun_orgaoemissor = @orgaoemissor, fun_rgemissao = @rgemissao," +
                "fun_datanascimento = @datanascimento, fun_sexo = @sexo, fun_estadocivil = @estadocivil, fun_numfilhos = @numfilhos, fun_nomeconjuge = @nomeconjuge," +
                "fun_telefone = @telefone, fun_celular = @celular, fun_formacao = @formacao, fun_tituloeleitor = @tituloeleitor, fun_zonaeleitor = @zonaeleitor," +
                "fun_secaoeleitor = @secaoeleitor, fun_emissaoeleitor =  @emissaoeleitor, fun_reservista = @reservista, fun_cnh = @cnh, fun_emissaocnh = @emissaocnh," +
                "fun_validadecnh = @validadecnh, fun_categoriacnh = @categoriacnh, fun_numctps = @numctps, fun_seriectps = @seriectps, fun_datactps = @datactps, fun_numpis = @numpis," +
                "fun_funcaoexercida = @funcaoexercida, fun_admissao = @admissao, fun_demissao = @demissao, fun_salariobase = @salariobase," +
                "fun_salarioextra = @salarioextra, fun_ajudacusto = @ajudacusto, fun_cep = @cep, fun_endereco = @endereco, fun_bairro = @bairro, fun_endnumero = @endnumero," +
                "fun_cidade = @cidade, fun_estado = @estado, fun_banconome = @banconome, fun_bancoagencia = @bancoagencia, fun_bancoconta = @bancoconta, fun_bancodata = @bancodata, ben_cod = @bencod," +
                "fun_foto = @foto WHERE fun_cod = @codigo)";

            cmd.Parameters.AddWithValue("@matricula", obj.FunMatricula);
            cmd.Parameters.AddWithValue("@nome", obj.FunNome);
            cmd.Parameters.AddWithValue("@cpf", obj.FunCpf);
            cmd.Parameters.AddWithValue("@rg", obj.FunRg);
            cmd.Parameters.AddWithValue("@orgaoemissor", obj.FunOrgaoEmissor);

            cmd.Parameters.Add("@rgemissao", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@rgemissao"].Value = obj.FunRgEmissao;

            cmd.Parameters.Add("@datanascimento", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@datanascimento"].Value = obj.FunDataNascimento;

            cmd.Parameters.AddWithValue("@sexo", obj.FunSexo);
            cmd.Parameters.AddWithValue("@estadocivil", obj.FunEstadoCivil);
            cmd.Parameters.AddWithValue("@numfilhos", obj.FunNumFilhos);
            cmd.Parameters.AddWithValue("@nomeconjuge", obj.FunNomeConjuge);
            cmd.Parameters.AddWithValue("@telefone", obj.FunTelefone);
            cmd.Parameters.AddWithValue("@celular", obj.FunCelular);
            cmd.Parameters.AddWithValue("@formacao", obj.FunFormacao);
            cmd.Parameters.AddWithValue("@tituloeleitor", obj.FunTituloEleitor);
            cmd.Parameters.AddWithValue("@zonaeleitor", obj.FunZonaEleitor);
            cmd.Parameters.AddWithValue("@secaoeleitor", obj.FunSecaoEleitor);

            cmd.Parameters.Add("@emissaoeleitor", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@emissaoeleitor"].Value = obj.FunEmissaoEleitor;

            cmd.Parameters.AddWithValue("@reservista", obj.FunReservista);
            cmd.Parameters.AddWithValue("@cnh", obj.FunCnh);

            cmd.Parameters.Add("@emissaocnh", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@emissaocnh"].Value = obj.FunEmissaoCnh;

            cmd.Parameters.Add("@validadecnh", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@validadecnh"].Value = obj.FunValidadeCnh;

            cmd.Parameters.AddWithValue("@categoriacnh", obj.FunCategoriaCnh);
            cmd.Parameters.AddWithValue("@numctps", obj.FunNumCtps);
            cmd.Parameters.AddWithValue("@seriectps", obj.FunSerieCtps);

            cmd.Parameters.Add("@datactps", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@datactps"].Value = obj.FunDataCtps;

            cmd.Parameters.AddWithValue("@numpis", obj.FunNumPis);
            cmd.Parameters.AddWithValue("@funcaoexercida", obj.FunFuncaoExercida);

            cmd.Parameters.Add("@admissao", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@admissao"].Value = obj.FunAdmissao;

            cmd.Parameters.AddWithValue("@demissao", obj.FunDemissao);
            cmd.Parameters.AddWithValue("@salariobase", obj.FunSalarioBase);
            cmd.Parameters.AddWithValue("@salarioextra", obj.FunSalarioExtra);
            cmd.Parameters.AddWithValue("@ajudacusto", obj.FunAjudaCusto);
            cmd.Parameters.AddWithValue("@cep", obj.FunCep);
            cmd.Parameters.AddWithValue("@endereco", obj.FunEndereco);
            cmd.Parameters.AddWithValue("@bairro", obj.FunBairro);
            cmd.Parameters.AddWithValue("@endnumero", obj.FunEndNumero);
            cmd.Parameters.AddWithValue("@cidade", obj.FunCidade);
            cmd.Parameters.AddWithValue("@estado", obj.FunEstado);
            cmd.Parameters.AddWithValue("@banconome", obj.FunBancoNome);
            cmd.Parameters.AddWithValue("@bancoagencia", obj.FunBancoAgencia);
            cmd.Parameters.AddWithValue("@bancoconta", obj.FunBancoConta);

            cmd.Parameters.Add("@bancodata", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@bancodata"].Value = obj.FunBancoData;

            cmd.Parameters.AddWithValue("@bencod", obj.BenCod);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.FunFoto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = obj.FunFoto;
            }
            cmd.Parameters.AddWithValue("@codigo", obj.FunCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloFuncionario obj, Boolean transacao)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE funcionario SET (fun_nome = @nome, fun_matricula = @matricula, fun_cpf = @cpf, fun_rg = @rg, fun_orgaoemissor = @orgaoemissor, fun_rgemissao = @rgemissao," +
                "fun_datanascimento = @datanascimento, fun_sexo = @sexo, fun_estadocivil = @estadocivil, fun_numfilhos = @numfilhos, fun_nomeconjuge = @nomeconjuge," +
                "fun_telefone = @telefone, fun_celular = @celular, fun_formacao = @formacao, fun_tituloeleitor = @tituloeleitor, fun_zonaeleitor = @zonaeleitor," +
                "fun_secaoeleitor = @secaoeleitor, fun_emissaoeleitor =  @emissaoeleitor, fun_reservista = @reservista, fun_cnh = @cnh, fun_emissaocnh = @emissaocnh," +
                "fun_validadecnh = @validadecnh, fun_categoriacnh = @categoriacnh, fun_numctps = @numctps, fun_seriectps = @seriectps, fun_datactps = @datactps, fun_numpis = @numpis," +
                "fun_funcaoexercida = @funcaoexercida, fun_admissao = @admissao, fun_demissao = @demissao, fun_salariobase = @salariobase," +
                "fun_salarioextra = @salarioextra, fun_ajudacusto = @ajudacusto, fun_cep = @cep, fun_endereco = @endereco, fun_bairro = @bairro, fun_endnumero = @endnumero," +
                "fun_cidade = @cidade, fun_estado = @estado, fun_banconome = @banconome, fun_bancoagencia = @bancoagencia, fun_bancoconta = @bancoconta, fun_bancodata = @bancodata, ben_cod = @bencod," +
                "fun_foto = @foto WHERE fun_cod = @codigo)";

            cmd.Parameters.AddWithValue("@nome", obj.FunNome);
            cmd.Parameters.AddWithValue("@matricula", obj.FunMatricula);
            cmd.Parameters.AddWithValue("@cpf", obj.FunCpf);
            cmd.Parameters.AddWithValue("@rg", obj.FunRg);
            cmd.Parameters.AddWithValue("@orgaoemissor", obj.FunOrgaoEmissor);

            cmd.Parameters.Add("@rgemissao", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@rgemissao"].Value = obj.FunRgEmissao;

            cmd.Parameters.Add("@datanascimento", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@datanascimento"].Value = obj.FunDataNascimento;

            cmd.Parameters.AddWithValue("@sexo", obj.FunSexo);
            cmd.Parameters.AddWithValue("@estadocivil", obj.FunEstadoCivil);
            cmd.Parameters.AddWithValue("@numfilhos", obj.FunNumFilhos);
            cmd.Parameters.AddWithValue("@nomeconjuge", obj.FunNomeConjuge);
            cmd.Parameters.AddWithValue("@telefone", obj.FunTelefone);
            cmd.Parameters.AddWithValue("@celular", obj.FunCelular);
            cmd.Parameters.AddWithValue("@formacao", obj.FunFormacao);
            cmd.Parameters.AddWithValue("@tituloeleitor", obj.FunTituloEleitor);
            cmd.Parameters.AddWithValue("@zonaeleitor", obj.FunZonaEleitor);
            cmd.Parameters.AddWithValue("@secaoeleitor", obj.FunSecaoEleitor);

            cmd.Parameters.Add("@emissaoeleitor", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@emissaoeleitor"].Value = obj.FunEmissaoEleitor;

            cmd.Parameters.AddWithValue("@reservista", obj.FunReservista);
            cmd.Parameters.AddWithValue("@cnh", obj.FunCnh);

            cmd.Parameters.Add("@emissaocnh", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@emissaocnh"].Value = obj.FunEmissaoCnh;

            cmd.Parameters.Add("@validadecnh", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@validadecnh"].Value = obj.FunValidadeCnh;

            cmd.Parameters.AddWithValue("@categoriacnh", obj.FunCategoriaCnh);
            cmd.Parameters.AddWithValue("@numctps", obj.FunNumCtps);
            cmd.Parameters.AddWithValue("@seriectps", obj.FunSerieCtps);
            cmd.Parameters.Add("@datactps", System.Data.SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@numpis", obj.FunNumPis);
            cmd.Parameters.AddWithValue("@funcaoexercida", obj.FunFuncaoExercida);

            cmd.Parameters.Add("@admissao", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@admissao"].Value = obj.FunAdmissao;

            cmd.Parameters.AddWithValue("@demissao", obj.FunDemissao);
            cmd.Parameters.AddWithValue("@salariobase", obj.FunSalarioBase);
            cmd.Parameters.AddWithValue("@salarioextra", obj.FunSalarioExtra);
            cmd.Parameters.AddWithValue("@ajudacusto", obj.FunAjudaCusto);
            cmd.Parameters.AddWithValue("@cep", obj.FunCep);
            cmd.Parameters.AddWithValue("@endereco", obj.FunEndereco);
            cmd.Parameters.AddWithValue("@bairro", obj.FunBairro);
            cmd.Parameters.AddWithValue("@endnumero", obj.FunEndNumero);
            cmd.Parameters.AddWithValue("@cidade", obj.FunCidade);
            cmd.Parameters.AddWithValue("@estado", obj.FunEstado);
            cmd.Parameters.AddWithValue("@banconome", obj.FunBancoNome);
            cmd.Parameters.AddWithValue("@bancoagencia", obj.FunBancoAgencia);
            cmd.Parameters.AddWithValue("@bancoconta", obj.FunBancoConta);
            cmd.Parameters.Add("@bancodata", System.Data.SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@bencod", obj.BenCod);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (obj.FunFoto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = obj.FunFoto;
            }
            cmd.Parameters.AddWithValue("@codigo", obj.FunCod);
            if (transacao)
            {
                cmd.Transaction = conexao.ObejtoTransacao;
                cmd.ExecuteNonQuery();
            }
            else
            {
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select f.fun_cod, f.fun_matricula, f.fun_nome, f.fun_cpf, f.fun_rg, f.fun_orgaoemissor, f.fun_rgemissao, f.fun_datanascimento, f.fun_sexo, f.fun_estadocivil, f.fun_numfilhos, " +
            " f.fun_nomeconjuge, f.fun_telefone, f.fun_celular, f.fun_formacao, f.fun_funcaoexercida, f.fun_tituloeleitor, f.fun_zonaeleitor, f.fun_secaoeleitor, f.fun_emissaoeleitor, f.fun_reservista, " +
            " f.fun_cnh, f.fun_emissaocnh, f.fun_validadecnh, f.fun_categoriacnh, f.fun_numctps, f.fun_seriectps, f.fun_datactps, f.fun_numpis, f.fun_admissao, f.fun_demissao, " +
            " f.fun_salariobase, f.fun_salarioextra, f.fun_ajudacusto, f.fun_cep, f.fun_endereco, f.fun_bairro, f.fun_endnumero, f.fun_cidade, f.fun_estado, f.fun_banconome, " +
            " f.fun_bancoagencia, f.fun_bancoconta, f.fun_bancodata, f.ben_cod, be.ben_nome" +
            " from funcionario f inner join beneficio be on f.ben_cod = be.ben_cod WHERE f.fun_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFuncionario CarregaModeloFuncionario(int codigo)
        {
            ModeloFuncionario modelo = new ModeloFuncionario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from funcionario where fun_cod =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FunCod = Convert.ToInt32(registro["fun_cod"]);
                modelo.FunNome = Convert.ToString(registro["fun_nome"]);
                modelo.FunMatricula = Convert.ToString(registro["fun_matricula"]);
                modelo.FunCpf = Convert.ToString(registro["fun_cpf"]);
                modelo.FunRg = Convert.ToString(registro["fun_rg"]);
                modelo.FunOrgaoEmissor = Convert.ToString(registro["fun_orgaoemissor"]);
                modelo.FunRgEmissao = Convert.ToDateTime(registro["fun_rgemissao"]);
                modelo.FunDataNascimento = Convert.ToDateTime(registro["fun_datanascimento"]);
                modelo.FunSexo = Convert.ToString(registro["fun_sexo"]);
                modelo.FunEstadoCivil = Convert.ToString(registro["fun_estadocivil"]);
                modelo.FunNumFilhos = Convert.ToInt32(registro["fun_numfilhos"]);
                modelo.FunNomeConjuge = Convert.ToString(registro["fun_nomeconjuge"]);
                modelo.FunTelefone = Convert.ToString(registro["fun_telefone"]);
                modelo.FunCelular = Convert.ToString(registro["fun_celular"]);
                modelo.FunFormacao = Convert.ToString(registro["fun_formacao"]);
                modelo.FunTituloEleitor = Convert.ToString(registro["fun_tituloeleitor"]);
                modelo.FunZonaEleitor = Convert.ToString(registro["fun_zonaeleitor"]);
                modelo.FunSecaoEleitor = Convert.ToString(registro["fun_secaoeleitor"]);
                modelo.FunEmissaoEleitor = Convert.ToDateTime(registro["fun_emissaoeleitor"]);
                modelo.FunReservista = Convert.ToString(registro["fun_reservista"]);
                modelo.FunCnh = Convert.ToString(registro["fun_cnh"]);
                modelo.FunEmissaoCnh = Convert.ToDateTime(registro["fun_emissaocnh"]);
                modelo.FunValidadeCnh = Convert.ToDateTime(registro["fun_validadecnh"]);
                modelo.FunCategoriaCnh = Convert.ToString(registro["fun_categoriacnh"]);
                modelo.FunNumCtps = Convert.ToString(registro["fun_numctps"]);
                modelo.FunSerieCtps = Convert.ToString(registro["fun_seriectps"]);
                modelo.FunDataCtps = Convert.ToDateTime(registro["fun_datactps"]);
                modelo.FunNumPis = Convert.ToString(registro["fun_numpis"]);
                modelo.FunFuncaoExercida = Convert.ToString(registro["fun_funcaoexercida"]);
                modelo.FunAdmissao = Convert.ToDateTime(registro["fun_admissao"]);
                modelo.FunDemissao = Convert.ToString(registro["fun_demissao"]);
                modelo.FunSalarioBase = Convert.ToDouble(registro["fun_salariobase"]);
                modelo.FunSalarioExtra = Convert.ToDouble(registro["fun_salarioextra"]);
                modelo.FunAjudaCusto = Convert.ToDouble(registro["fun_ajudacusto"]);
                modelo.FunCep = Convert.ToString(registro["fun_cep"]);
                modelo.FunEndereco = Convert.ToString(registro["fun_endereco"]);
                modelo.FunBairro = Convert.ToString(registro["fun_bairro"]);
                modelo.FunEndNumero = Convert.ToString(registro["fun_endnumero"]);
                modelo.FunCidade = Convert.ToString(registro["fun_cidade"]);
                modelo.FunEstado = Convert.ToString(registro["fun_estado"]);
                modelo.FunBancoNome = Convert.ToString(registro["fun_banconome"]);
                modelo.FunBancoAgencia = Convert.ToString(registro["fun_bancoagencia"]);
                modelo.FunBancoConta = Convert.ToString(registro["fun_bancoconta"]);
                modelo.FunBancoData = Convert.ToDateTime(registro["fun_bancodata"]);
                try
                {
                    modelo.FunFoto = (byte[])registro["fun_foto"];

                }
                catch { }
                modelo.BenCod = Convert.ToInt32(registro["ben_cod"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;

        }

        public ModeloFuncionario CarregaModeloFuncionario(int codigo, Boolean transacao)
        {
            ModeloFuncionario modelo = new ModeloFuncionario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from funcionario where fun_cod =" + codigo.ToString();
            if (transacao == false)
            {
                conexao.Conectar();
            }
            else
            {
                cmd.Transaction = conexao.ObejtoTransacao;
            }
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FunCod = Convert.ToInt32(registro["fun_cod"]);
                modelo.FunNome = Convert.ToString(registro["fun_nome"]);
                modelo.FunMatricula = Convert.ToString(registro["fun_matricula"]);
                modelo.FunCpf = Convert.ToString(registro["fun_cpf"]);
                modelo.FunRg = Convert.ToString(registro["fun_rg"]);
                modelo.FunOrgaoEmissor = Convert.ToString(registro["fun_orgaoemissor"]);
                modelo.FunRgEmissao = Convert.ToDateTime(registro["fun_rgemissao"]);
                modelo.FunDataNascimento = Convert.ToDateTime(registro["fun_datanascimento"]);
                modelo.FunSexo = Convert.ToString(registro["fun_sexo"]);
                modelo.FunEstadoCivil = Convert.ToString(registro["fun_estadocivil"]);
                modelo.FunNumFilhos = Convert.ToInt32(registro["fun_numfilhos"]);
                modelo.FunNomeConjuge = Convert.ToString(registro["fun_nomeconjuge"]);
                modelo.FunTelefone = Convert.ToString(registro["fun_telefone"]);
                modelo.FunCelular = Convert.ToString(registro["fun_celular"]);
                modelo.FunFormacao = Convert.ToString(registro["fun_formacao"]);
                modelo.FunTituloEleitor = Convert.ToString(registro["fun_tituloeleitor"]);
                modelo.FunZonaEleitor = Convert.ToString(registro["fun_zonaeleitor"]);
                modelo.FunSecaoEleitor = Convert.ToString(registro["fun_secaoeleitor"]);
                modelo.FunEmissaoEleitor = Convert.ToDateTime(registro["fun_emissaoeleitor"]);
                modelo.FunReservista = Convert.ToString(registro["fun_reservista"]);
                modelo.FunCnh = Convert.ToString(registro["fun_cnh"]);
                modelo.FunEmissaoCnh = Convert.ToDateTime(registro["fun_emissaocnh"]);
                modelo.FunValidadeCnh = Convert.ToDateTime(registro["fun_validadecnh"]);
                modelo.FunCategoriaCnh = Convert.ToString(registro["fun_categoriacnh"]);
                modelo.FunNumCtps = Convert.ToString(registro["fun_numctps"]);
                modelo.FunSerieCtps = Convert.ToString(registro["fun_seriectps"]);
                modelo.FunDataCtps = Convert.ToDateTime(registro["fun_datactps"]);
                modelo.FunNumPis = Convert.ToString(registro["fun_numpis"]);
                modelo.FunFuncaoExercida = Convert.ToString(registro["fun_funcaoexercida"]);
                modelo.FunAdmissao = Convert.ToDateTime(registro["fun_admissao"]);
                modelo.FunDemissao = Convert.ToString(registro["fun_demissao "]);
                modelo.FunSalarioBase = Convert.ToDouble(registro["fun_salariobase"]);
                modelo.FunSalarioExtra = Convert.ToDouble(registro["fun_salarioextra"]);
                modelo.FunAjudaCusto = Convert.ToDouble(registro["fun_ajudacusto"]);
                modelo.FunCep = Convert.ToString(registro["fun_cep"]);
                modelo.FunEndereco = Convert.ToString(registro["fun_endereco"]);
                modelo.FunBairro = Convert.ToString(registro["fun_bairro"]);
                modelo.FunEndNumero = Convert.ToString(registro["fun_endnumero"]);
                modelo.FunCidade = Convert.ToString(registro["fun_cidade"]);
                modelo.FunEstado = Convert.ToString(registro["fun_estado"]);
                modelo.FunBancoNome = Convert.ToString(registro["fun_banconome"]);
                modelo.FunBancoAgencia = Convert.ToString(registro["fun_bancoagencia"]);
                modelo.FunBancoConta = Convert.ToString(registro["fun_bancoconta"]);
                modelo.FunBancoData = Convert.ToDateTime(registro["fun_bancodata"]);
                try
                {
                    modelo.FunFoto = (byte[])registro["fun_foto"];

                }
                catch { }
                modelo.BenCod = Convert.ToInt32(registro["ben_cod"]);
            }
            registro.Close();
            if (transacao == false)
            {
                conexao.Desconectar();
            }

            return modelo;

        }
    }
}
