using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using PIM_4_PERIODO.Model;
using System.Windows.Forms;

namespace PIM_4_PERIODO.Dao
{
    class Consultar
    {
        private bool Login_Existe = false;
        public Conexao Conexão = new Conexao();

        DataTable TableAbastecimento = new DataTable();
        DataTable TableAtendimento = new DataTable();
        DataTable TableCombustivel = new DataTable();
        DataTable TableDepartamento = new DataTable();
        DataTable TableDestino = new DataTable();
        DataTable TableManutenção = new DataTable();
        DataTable TableMulta = new DataTable();
        DataTable TableNotificação = new DataTable();
        DataTable TableOficina = new DataTable();
        DataTable TableOleo = new DataTable();
        DataTable TablePosto = new DataTable();
        DataTable TableSalario = new DataTable();
        DataTable TableUsuario = new DataTable();
        DataTable TableVeiculo = new DataTable();


        public bool Entra_Sistema(Login Login)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM USUARIO WHERE USERNAME = @usuario OR SENHA = @senha", Conexão.Pega_Conexão());

                    command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = Login.Usuario;
                    command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Login.Senha;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    //Verifica se há uma lina no banco com esse Usuário.
                    if (table.Rows.Count > 0)
                    {
                        Login_Existe = true;
                    }

                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Consulta");
            }

            return Login_Existe;
        }
        public DataTable Abastecimento(Abastecimento Abastecimento)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {

                    string ConsultaAbastecimento = "SELECT * FROM ABASTECIMENTO WHERE KM_NO_ABASTECIMENTO = @KM_NO_ABASTECIMENTO OR LITROS = @LITROS OR VALOR = @VALOR OR ID_POSTO = @ID_POSTO OR ID_VEICULO = @ID_VEICULO OR DATAS = @DATAS;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaAbastecimento;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@KM_NO_ABASTECIMENTO", MySqlDbType.VarChar).Value = Abastecimento.Km_No_Abastecimento;
                    command.Parameters.Add("@LITROS", MySqlDbType.VarChar).Value = Abastecimento.Litros;
                    command.Parameters.Add("@VALOR", MySqlDbType.VarChar).Value = Abastecimento.Valor;
                    command.Parameters.Add("@ID_POSTO", MySqlDbType.VarChar).Value = Abastecimento.ID_Posto;
                    command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Abastecimento.ID_Veiculo;
                    command.Parameters.Add("@DATAS", MySqlDbType.VarChar).Value = Abastecimento.Data;

                    adapter.SelectCommand = command;
                    adapter.Fill(TableAbastecimento);


                    Conexão.Desconectar();
                }
            }
            catch(MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Consulta");
            }

            return TableAbastecimento;
        }
        public DataTable Atendimento(Atendimento Atendimento)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaAtendimento = "SELECT * FROM ATENDIMENTO WHERE ID_VEICULO = @ID_VEICULO OR ID_MOTORISTA = @ID_MOTORISTA OR ID_DESTINO = @ID_DESTINO;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaAtendimento;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Atendimento.ID_Veiculo;
                    command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Atendimento.ID_Motorista;
                    command.Parameters.Add("@ID_DESTINO", MySqlDbType.VarChar).Value = Atendimento.ID_Destino;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableAtendimento);

                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return TableAtendimento;
        }
        public DataTable Combustivel(Combustivel Combustivel)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaCombustivel = "SELECT * FROM COMBUSTIVEL WHERE NOME = @NOME OR VALOR = @VALOR  OR DATAS = @DATAS);";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaCombustivel;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Combustivel.Nome;
                    command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Combustivel.Valor;
                    command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Combustivel.Data;

                    adapter.SelectCommand = command;
                    adapter.Fill(TableCombustivel);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableCombustivel;
        }
        public DataTable Departamento(Departamento Depatamento)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaDepartamento = "SELECT * FROM DEPARTAMENTO WHERE NIVELACESSO = @NIVELACESSO OR NOME = @NOME;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaDepartamento;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@NIVELACESSO", MySqlDbType.Int32).Value = Depatamento.NivelAcesso;
                    command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Depatamento.Nome;

                    adapter.SelectCommand = command;
                    adapter.Fill(TableDepartamento);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableDepartamento;
        }
        public DataTable Destino(Destino Destino)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaDestino = "SELECT * FROM DESTINO WHERE ID_VEICULO = @ID_VEICULO OR ID_MOTORISTA = @ID_MOTORISTA OR LOCAL_CHEGADA = @LOCAL_CHEGADA OR LOCAL_SAIDA = @LOCAL_SAIDA OR DATAS_CHEGADA = @DATAS_CHEGADA OR DATAS_SAIDA = @DATAS_SAIDA;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaDestino;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Destino.ID_Veiculo;
                    command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Destino.ID_Motorista;
                    command.Parameters.Add("@LOCAL_CHEGADA", MySqlDbType.VarChar).Value = Destino.Local_Chegada;
                    command.Parameters.Add("@LOCAL_SAIDA", MySqlDbType.VarChar).Value = Destino.Local_Saida;
                    command.Parameters.Add("@DATAS_CHEGADA", MySqlDbType.VarChar).Value = Destino.Data_Chegada;
                    command.Parameters.Add("@DATAS_SAIDA", MySqlDbType.VarChar).Value = Destino.Data_Saida;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableDestino);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableDestino;
        }
        public DataTable Manutenção(Manutenção Manutenção)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaManutenção = "SELECT * FROM MANUTENCAO WHERE NUM_OS = @NUM_OS OR ID_OFICINA = @ID_OFICINA OR DATAS_ENTRADA = @DATAS_ENTRADA OR DATAS_SAIDA = @DATAS_SAIDA OR MOTIVO = @MOTIVO OR VALOR = @VALOR OR ID_VEICULO = @ID_VEICULO;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaManutenção;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@NUM_OS", MySqlDbType.Int32).Value = Manutenção.NumeroOS;
                    command.Parameters.Add("@ID_OFICINA", MySqlDbType.Int32).Value = Manutenção.ID_Oficina;
                    command.Parameters.Add("@DATAS_ENTRADA", MySqlDbType.Date).Value = Manutenção.Data_Entrada;
                    command.Parameters.Add("@DATAS_SAIDA", MySqlDbType.Date).Value = Manutenção.Data_Saida;
                    command.Parameters.Add("@MOTIVO", MySqlDbType.VarChar).Value = Manutenção.Motivo;
                    command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Manutenção.Valor;
                    command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Manutenção.ID_Veiculo;

                    adapter.SelectCommand = command;
                    adapter.Fill(TableManutenção);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableManutenção;
        }
        public DataTable Multa(Multa Multa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaMulta = "SELECT * FROM MULTA WHERE NUM_INFRACAO = @NUM_INFRACAO OR TIPO_INFRACAO = @TIPO_INFRACAO OR ID_MOTORISTA = @ID_MOTORISTA OR ID_VEICULO = @ID_VEICULO OR VALOR = @VALOR OR DATAS = @DATAS OR ENDERECO = @ENDERECO;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaMulta;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@NUM_INFRACAO", MySqlDbType.Int32).Value = Multa.Infração;
                    command.Parameters.Add("@TIPO_INFRACAO", MySqlDbType.VarChar).Value = Multa.Tipo;
                    command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.Int32).Value = Multa.Motorista;
                    command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Multa.Veiculo;
                    command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Multa.Valor;
                    command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Multa.Data;
                    command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Multa.Endereço;

                    adapter.SelectCommand = command;
                    adapter.Fill(TableMulta);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableMulta;
        }
        public DataTable Notificação(Notificação Notificação)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaNotificação = "SELECT * FROM NOTIFICACAO WHERE ID_DEPARTAMENTO = @ID_DEPARTAMENTO OR TITULO = @TITULO OR IMAGEM = @IMAGEM OR DESCRICAO = @DESCRICAO;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaNotificação;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value = Notificação.ID_Departamento;
                    command.Parameters.Add("@TITULO", MySqlDbType.VarChar).Value = Notificação.Titulo;
                    command.Parameters.Add("@IMAGEM", MySqlDbType.VarChar).Value = Notificação.Imagem;
                    command.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar).Value = Notificação.Descrição;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableNotificação);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableNotificação;
        }
        public DataTable Oficina(Oficina Oficina)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaOficina = "SELECT * FROM OFICINA WHERE NOME = @NOME OR CNPJ = @CNPJ OR RAZAO_SOCIAL = @RAZAO_SOCIAL OR TELEFONE = @TELEFONE OR CELULAR = @CELULAR OR SITE = @SITE OR ENDERECO = @ENDERECO;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaOficina;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oficina.Nome;
                    command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Oficina.CNPJ;
                    command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Oficina.RazaoSocial;
                    command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Oficina.Telefone;
                    command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Oficina.Celular;
                    command.Parameters.Add("@SITE", MySqlDbType.VarChar).Value = Oficina.Site;
                    command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Oficina.Endereço;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableOficina);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableOficina;
        }
        public DataTable Oleo(Oleo Oleo)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaOleo = "SELECT * FROM OLEO WHERE NOME = @NOME OR MARCA =  @MARCA OR LITROS = @LITROS;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaOleo;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oleo.Nome;
                    command.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = Oleo.Marca;
                    command.Parameters.Add("@LITROS", MySqlDbType.Float).Value = Oleo.Litros;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableOleo);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableOleo;
        }
        public DataTable Posto(Posto Posto)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaPosto = "SELECT * FROM POSTO WHERE NOME = @NOME OR CNPJ = @CNPJ OR RAZAO_SOCIAL = @RAZAO_SOCIAL OR TELEFONE = @TELEFONE OR CELULAR = @CELULAR OR SITE = @SITE OR ENDERECO = @ENDERECO;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaPosto;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Posto.Nome;
                    command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Posto.CNPJ;
                    command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Posto.RazaoSocial;
                    command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Posto.Telefone;
                    command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Posto.Celular;
                    command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Posto.Endereço;
                    adapter.SelectCommand = command;
                    adapter.Fill(TablePosto);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TablePosto;
        }
        public DataTable Salario(Salario Salario)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaSalario = "SELECT * FROM SALARIO WHERE VALOR = @VALOR;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaSalario;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Salario.Valor;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableSalario);
                    Conexão.Desconectar();
                }

            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableSalario;
        }
        public DataTable Usuario(Usuario Usuario)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaUsuario = "SELECT * FROM USUARIO WHERE USERNAME = @USERNAME OR DEPARTAMENTO = @DEPARTAMENTO OR NOME =  @NOME, EMAIL = @EMAIL OR CPF = @CPF OR TELEFONE = @TELEFONE OR CELULAR = @CELULAR OR ENDERECO = @ENDERECO OR CNH = @CNH OR VALIDADE_CNH = @VALIDADE_CNH OR CATEGORIA_CNH = @CATEGORIA_CNH OR CATEGORIA_CNH = @CATEGORIA_CNH OR DATAS_ADIMISSAO = @DATAS_ADIMISSAO;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaUsuario;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@USERNAME", MySqlDbType.VarChar).Value = Usuario.Username;
                    command.Parameters.Add("@SENHA", MySqlDbType.VarChar).Value = Usuario.Senha;
                    command.Parameters.Add("@DEPARTAMENTO", MySqlDbType.Int32).Value = Usuario.Departamento;
                    command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Usuario.Nome;
                    command.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = Usuario.Email;
                    command.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = Usuario.CPF;
                    command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Usuario.Telefone;
                    command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Usuario.Celular;
                    command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Usuario.Endereço;
                    command.Parameters.Add("@CNH", MySqlDbType.Int32).Value = Usuario.CNH;
                    command.Parameters.Add("@VALIDADE_CNH", MySqlDbType.Date).Value = Usuario.Validade_CNH;
                    command.Parameters.Add("@CATEGORIA_CNH", MySqlDbType.VarChar).Value = Usuario.Categoria_CNH;
                    command.Parameters.Add("@DATAS_ADIMISSAO", MySqlDbType.Date).Value = Usuario.Categoria_CNH;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableUsuario);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableUsuario;
        }
        public DataTable Veiculo(Veiculo Veiculo)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaVeiculo = "SELECT * FROM VEICULO WHERE PLACA = @PLACA OR MODELO = @MODELO OR TIPO = @TIPO OR MARCA = @MARCA OR ANO = @ANO OR RENAVAM = @RENAVAM OR CHSSI_NUM = @CHSSI_NUM OR KM_POR_LITRO = @KM_POR_LITRO OR KM_TROCA_OLEO = @KM_TROCA_OLEO OR KM_REVISAO = @KM_REVISAO OR KM_PNEU = @KM_PNEU OR CAPACIDADE_TANQUE = @CAPACIDADE_TANQUE OR ID_COMBUSTIVEL = @ID_COMBUSTIVEL;";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaVeiculo;
                    command.Connection = Conexão.Pega_Conexão();
                    command.Parameters.Add("@PLACA", MySqlDbType.VarChar).Value = Veiculo.Placa;
                    command.Parameters.Add("@MODELO", MySqlDbType.VarChar).Value = Veiculo.Modelo;
                    command.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = Veiculo.Tipo;
                    command.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = Veiculo.Marca;
                    command.Parameters.Add("@ANO", MySqlDbType.Date).Value = Veiculo.Ano;
                    command.Parameters.Add("@RENAVAM", MySqlDbType.Int32).Value = Veiculo.Renavam;
                    command.Parameters.Add("@CHSSI_NUM", MySqlDbType.VarChar).Value = Veiculo.Chassi;
                    command.Parameters.Add("@KM_POR_LITRO", MySqlDbType.Float).Value = Veiculo.KM_Litro;
                    command.Parameters.Add("@KM_TROCA_OLEO", MySqlDbType.Float).Value = Veiculo.KM_TrocaOleo;
                    command.Parameters.Add("@KM_REVISAO", MySqlDbType.Float).Value = Veiculo.KM_Revisao;
                    command.Parameters.Add("@KM_PNEU", MySqlDbType.Float).Value = Veiculo.KM_TrocaPneu;
                    command.Parameters.Add("@CAPACIDADE_TANQUE", MySqlDbType.Float).Value = Veiculo.Capacidade_Tanque;
                    command.Parameters.Add("@ID_COMBUSTIVEL", MySqlDbType.Int32).Value = Veiculo.ID_Combustivel;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableVeiculo);
                    Conexão.Desconectar();
                }

            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableVeiculo;
        }

    }
}
