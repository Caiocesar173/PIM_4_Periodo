using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PIM_4_PERIODO.Model;



namespace PIM_4_PERIODO.Dao
{
    class Incluir
    {
        private Conexao Conexão = new Conexao();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        private bool Abastecimento_Incluido = false;
        private bool Combustivel_Incluido = false;
        private bool Departamento_Incluido = false;
        private bool Manutenção_Incluido = false;
        private bool Multa_Incluido = false;
        private bool Notificação_Incluido = false;
        private bool Oficina_Incluido = false;
        private bool Oleo_Incluido = false;
        private bool Posto_Incluido = false;
        private bool Salario_Incluido = false;
        private bool Usuario_Incluido = false;
        private bool Veiculo_Incluido = false;
        private bool Atendimento_Incluido = false;
        private bool Destino_Incluido = false;

        
        public bool Abastecimento(Abastecimento Abastecimento)
        {

            try
            {
                string ConsultaAbastecimento = "SELECT * FROM ABASTECIMENTO WHERE KM_NO_ABASTECIMENTO = @KM_NO_ABASTECIMENTO AND LITROS = @LITROS AND VALOR = @VALOR AND ID_POSTO = @ID_POSTO AND ID_VEICULO = @ID_VEICULO AND DATAS = @DATAS;";
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
                adapter.Fill(table);

                //Verifica se o Abastecimento Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertAbastecimento = "INSERT INTO ABASTECIMENTO(KM_NO_ABASTECIMENTO, LITROS, VALOR, ID_POSTO, ID_VEICULO, DATAS) VALUES (@KM_NO_ABASTECIMENTO, @LITROS, @VALOR, @ID_POSTO, @ID_VEICULO, @DATAS);";


                        command.CommandText = InsertAbastecimento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@KM_NO_ABASTECIMENTO", MySqlDbType.VarChar).Value = Abastecimento.Km_No_Abastecimento;
                        command.Parameters.Add("@LITROS", MySqlDbType.VarChar).Value = Abastecimento.Litros;
                        command.Parameters.Add("@VALOR", MySqlDbType.VarChar).Value = Abastecimento.Valor;
                        command.Parameters.Add("@ID_POSTO", MySqlDbType.VarChar).Value = Abastecimento.ID_Posto;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Abastecimento.ID_Veiculo;
                        command.Parameters.Add("@DATAS", MySqlDbType.VarChar).Value = Abastecimento.Data;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Abastecimento_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Abastecimento_Incluido;
                    }
                }
                else
                {

                    MessageBox.Show("Usuario já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Abastecimento_Incluido;

        }
        public bool Combustivel(Combustivel Combustivel)
        {
            try
            {
                string ConsultaCombustivel = "SELECT * FROM COMBUSTIVEL WHERE NOME = @NOME AND VALOR = @VALOR  AND DATAS = @DATAS);";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = ConsultaCombustivel;
                command.Connection = Conexão.Pega_Conexão();
                command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Combustivel.Nome;
                command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Combustivel.Valor;
                command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Combustivel.Data;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se o Combustivel Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertCombustivel = "INSERT INTO COMBUSTIVEL(NOME, VALOR, DATAS) VALUES (@NOME, @VALOR, @DATAS);";


                        command.CommandText = InsertCombustivel;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Combustivel.Nome;
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Combustivel.Valor;
                        command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Combustivel.Data;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Combustivel_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Combustivel_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Combustivel já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Combustivel_Incluido;
        }
        public bool Departamento(Departamento Depatamento)
        {
            try
            {
                string ConsultaDepartamento = "SELECT * FROM DEPARTAMENTO WHERE NIVELACESSO = @NIVELACESSO AND NOME = @NOME;";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = ConsultaDepartamento;
                command.Connection = Conexão.Pega_Conexão();
                command.Parameters.Add("@NIVELACESSO", MySqlDbType.Int32).Value = Depatamento.NivelAcesso;
                command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Depatamento.Nome;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se o Departamento Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertDepartamento = "INSERT INTO DEPARTAMENTO(NIVELACESSO, NOME) VALUES (@NIVELACESSO, @NOME);";


                        command.CommandText = InsertDepartamento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NIVELACESSO", MySqlDbType.Int32).Value = Depatamento.NivelAcesso;
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Depatamento.Nome;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Departamento_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Departamento_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Departamento já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Departamento_Incluido;
        }
        public bool Manutenção(Manutenção Manutenção)
        {
            try
            {
                string ConsultaManutenção = "SELECT * FROM MANUTENCAO WHERE NUM_OS = @NUM_OS AND ID_OFICINA = @ID_OFICINA AND DATAS_ENTRADA = @DATAS_ENTRADA AND DATAS_SAIDA = @DATAS_SAIDA AND MOTIVO = @MOTIVO AND VALOR = @VALOR AND ID_VEICULO = @ID_VEICULO;";
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
                adapter.Fill(table);

                //Verifica se o Manutenção Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertManutençãoo = "INSERT INTO MANUTENCAO(NUM_OS, ID_OFICINA, DATAS_ENTRADA, DATAS_SAIDA, MOTIVO, VALOR, ID_VEICULO) VALUES (@NUM_OS, @ID_OFICINA, @DATAS_ENTRADA, @DATAS_SAIDA, @MOTIVO, @VALOR, @ID_VEICULO);";


                        command.CommandText = InsertManutençãoo;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NUM_OS", MySqlDbType.Int32).Value = Manutenção.NumeroOS;
                        command.Parameters.Add("@ID_OFICINA", MySqlDbType.Int32).Value = Manutenção.ID_Oficina;
                        command.Parameters.Add("@DATAS_ENTRADA", MySqlDbType.Date).Value = Manutenção.Data_Entrada;
                        command.Parameters.Add("@DATAS_SAIDA", MySqlDbType.Date).Value = Manutenção.Data_Saida;
                        command.Parameters.Add("@MOTIVO", MySqlDbType.VarChar).Value = Manutenção.Motivo;
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Manutenção.Valor;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Manutenção.ID_Veiculo;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Manutenção_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Manutenção_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Manutenção já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Manutenção_Incluido;            
        }
        public bool Multa(Multa Multa)
        {
            try
            {
                string ConsultaMulta = "SELECT * FROM MULTA WHERE NUM_INFRACAO = @NUM_INFRACAO AND TIPO_INFRACAO = @TIPO_INFRACAO AND ID_MOTORISTA = @ID_MOTORISTA AND ID_VEICULO = @ID_VEICULO AND VALOR = @VALOR AND DATAS = @DATAS AND ENDERECO = @ENDERECO;";
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
                adapter.Fill(table);

                //Verifica se o Multa Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertMulta = "INSERT INTO MULTA(NUM_INFRACAO, TIPO_INFRACAO, ID_MOTORISTA, ID_VEICULO, VALOR, DATAS, ENDERECO) VALUES (@NUM_INFRACAO, @TIPO_INFRACAO, @ID_MOTORISTA, @ID_VEICULO, @VALOR, @DATAS, @ENDERECO);";


                        command.CommandText = InsertMulta;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NUM_INFRACAO", MySqlDbType.Int32).Value = Multa.Infração;
                        command.Parameters.Add("@TIPO_INFRACAO", MySqlDbType.VarChar).Value = Multa.Tipo;
                        command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.Int32).Value = Multa.Motorista;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Multa.Veiculo;
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Multa.Valor;
                        command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Multa.Data;
                        command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Multa.Endereço;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Multa_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Multa_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Multa já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Multa_Incluido;           
        }
        public bool Notificação(Notificação Notificação)
        {
            try
            {
                string ConsultaNotificação = "SELECT * FROM NOTIFICACAO WHERE ID_DEPARTAMENTO = @ID_DEPARTAMENTO AND TITULO = @TITULO AND IMAGEM = @IMAGEM AND DESCRICAO = @DESCRICAO;";
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
                adapter.Fill(table);

                //Verifica se o Notificação Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertNotificação = "INSERT INTO NOTIFICACAO(ID_DEPARTAMENTO, TITULO, IMAGEM, DESCRICAO) VALUES (@ID_DEPARTAMENTO, @TITULO, @IMAGEM, @DESCRICAO);";


                        command.CommandText = InsertNotificação;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value = Notificação.ID_Departamento;
                        command.Parameters.Add("@TITULO", MySqlDbType.VarChar).Value = Notificação.Titulo;
                        command.Parameters.Add("@IMAGEM", MySqlDbType.VarChar).Value = Notificação.Imagem;
                        command.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar).Value = Notificação.Descrição;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Notificação_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Notificação_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Notificação já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Notificação_Incluido; 
        }
        public bool Oficina(Oficina Oficina)
        {
            try
            {
                string ConsultaOficina = "SELECT * FROM OFICINA WHERE NOME = @NOME AND CNPJ = @CNPJ AND RAZAO_SOCIAL = @RAZAO_SOCIAL AND TELEFONE = @TELEFONE AND CELULAR = @CELULAR AND SITE = @SITE AND ENDERECO = @ENDERECO;";
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
                adapter.Fill(table);

                //Verifica se o Oficina Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertOficina = "INSERT INTO OFICINA(NOME, CNPJ, RAZAO_SOCIAL, TELEFONE, CELULAR, SITE, ENDERECO) VALUES (@NOME, @CNPJ, @RAZAO_SOCIAL, @TELEFONE, @CELULAR, @SITE, @ENDERECO);";


                        command.CommandText = InsertOficina;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oficina.Nome;
                        command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Oficina.CNPJ;
                        command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Oficina.RazaoSocial;
                        command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Oficina.Telefone;
                        command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Oficina.Celular;
                        command.Parameters.Add("@SITE", MySqlDbType.VarChar).Value = Oficina.Site;
                        command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Oficina.Endereço;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Oficina_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Oficina_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Oficina já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Oficina_Incluido;
        }
        public bool Oleo(Oleo Oleo)
        {
            try
            {
                string ConsultaOleo = "SELECT * FROM OLEO WHERE NOME = @NOME AND MARCA =  @MARCA AND LITROS = @LITROS;";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = ConsultaOleo;
                command.Connection = Conexão.Pega_Conexão();
                command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oleo.Nome;
                command.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = Oleo.Marca;
                command.Parameters.Add("@LITROS", MySqlDbType.Float).Value = Oleo.Litros;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se o Oleo Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertOleo = "INSERT INTO OLEO(NOME, MARCA, LITROS) VALUES (@NOME, @MARCA, @LITROS);";


                        command.CommandText = InsertOleo;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oleo.Nome;
                        command.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = Oleo.Marca;
                        command.Parameters.Add("@LITROS", MySqlDbType.Float).Value = Oleo.Litros;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Oleo_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Oleo_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Oleo já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Oleo_Incluido;    
        }
        public bool Posto(Posto Posto)
        {
            try
            {
                string ConsultaPosto = "SELECT * FROM POSTO WHERE NOME = @NOME AND CNPJ = @CNPJ AND RAZAO_SOCIAL = @RAZAO_SOCIAL AND TELEFONE = @TELEFONE AND CELULAR = @CELULAR AND SITE = @SITE AND ENDERECO = @ENDERECO;";
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
                command.Parameters.Add("@SITE", MySqlDbType.VarChar).Value = Posto.Site;
                command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Posto.Endereço;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se o Posto Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertPosto = "INSERT INTO POSTO(NOME, CNPJ, RAZAO_SOCIAL, TELEFONE, CELULAR, SITE, ENDERECO) VALUES (@NOME, @CNPJ, @RAZAO_SOCIAL, @TELEFONE, @CELULAR, @SITE, @ENDERECO);";


                        command.CommandText = InsertPosto;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Posto.Nome;
                        command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Posto.CNPJ;
                        command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Posto.RazaoSocial;
                        command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Posto.Telefone;
                        command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Posto.Celular;
                        command.Parameters.Add("@SITE", MySqlDbType.VarChar).Value = Posto.Site;
                        command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Posto.Endereço;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Posto_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Posto_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Posto já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Posto_Incluido;
        }
        public bool Salario(Salario Salario)
        {
            try
            {
                string ConsultaSalario = "SELECT * FROM SALARIO WHERE VALOR = @VALOR;";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = ConsultaSalario;
                command.Connection = Conexão.Pega_Conexão();
                command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Salario.Valor;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se o Salario Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertSalario = "INSERT INTO SALARIO(VALOR) VALUES (@VALOR);";


                        command.CommandText = InsertSalario;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Salario.Valor;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Salario_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Salario_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Salario já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Salario_Incluido;
        }
        public bool Usuario(Usuario Usuario)
        {
            try
            {
                string ConsultaUsuario = "SELECT * FROM USUARIO WHERE USERNAME = @USERNAME AND DEPARTAMENTO = @DEPARTAMENTO AND NOME =  @NOME, EMAIL = @EMAIL AND CPF = @CPF AND TELEFONE = @TELEFONE AND CELULAR = @CELULAR AND ENDERECO = @ENDERECO AND CNH = @CNH AND VALIDADE_CNH = @VALIDADE_CNH AND CATEGORIA_CNH = @CATEGORIA_CNH AND CATEGORIA_CNH = @CATEGORIA_CNH AND DATAS_ADIMISSAO = @DATAS_ADIMISSAO;";
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
                adapter.Fill(table);

                //Verifica se o Usuario Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertUsuario = "INSERT INTO USUARIO(USERNAME, SENHA, DEPARTAMENTO, NOME, EMAIL, CPF, TELEFONE, CELULAR, ENDERECO, CNH, VALIDADE_CNH, CATEGORIA_CNH, CATEGORIA_CNH, DATAS_ADIMISSAO) VALUES (@USERNAME, @SENHA, @DEPARTAMENTO, @NOME, @EMAIL, @CPF, @TELEFONE, @CELULAR, @ENDERECO, @CNH, @VALIDADE_CNH, @CATEGORIA_CNH, @CATEGORIA_CNH, @DATAS_ADIMISSAO);";


                        command.CommandText = InsertUsuario;
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

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Usuario_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Usuario_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Usuario_Incluido;            
        }
        public bool Veiculo(Veiculo Veiculo)
        {
            try
            {
                string ConsultaVeiculo = "SELECT * FROM VEICULO WHERE PLACA = @PLACA AND MODELO = @MODELO AND TIPO = @TIPO AND MARCA = @MARCA AND ANO = @ANO AND RENAVAM = @RENAVAM AND CHSSI_NUM = @CHSSI_NUM AND KM_POR_LITRO = @KM_POR_LITRO AND KM_TROCA_OLEO = @KM_TROCA_OLEO AND KM_REVISAO = @KM_REVISAO AND KM_PNEU = @KM_PNEU AND CAPACIDADE_TANQUE = @CAPACIDADE_TANQUE AND ID_COMBUSTIVEL = @ID_COMBUSTIVEL;";
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
                adapter.Fill(table);

                //Verifica se o Veiculo Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertVeiculo = "INSERT INTO VEICULO(PLACA, MODELO, TIPO, MARCA, ANO, RENAVAM, CHSSI_NUM, KM_POR_LITRO, KM_TROCA_OLEO, KM_REVISAO, KM_PNEU, CAPACIDADE_TANQUE, ID_COMBUSTIVEL) VALUES (@PLACA, @MODELO, @TIPO, @MARCA, @ANO, @RENAVAM, @CHSSI_NUM, @KM_POR_LITRO, @KM_TROCA_OLEO, @KM_REVISAO, @KM_PNEU, @CAPACIDADE_TANQUE, @ID_COMBUSTIVEL);";


                        command.CommandText = InsertVeiculo;
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

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Veiculo_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Veiculo_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Veiculo já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Veiculo_Incluido;
        }
        public bool Atendimento(Atendimento Atendimento)
        {
            try
            {
                string ConsultaAtendimento = "SELECT * FROM ATENDIMENTO WHERE ID_VEICULO = @ID_VEICULO AND ID_MOTORISTA = @ID_MOTORISTA AND ID_DESTINO = @ID_DESTINO;";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = ConsultaAtendimento;
                command.Connection = Conexão.Pega_Conexão();
                command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Atendimento.ID_Veiculo;
                command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Atendimento.ID_Motorista;
                command.Parameters.Add("@ID_DESTINO", MySqlDbType.VarChar).Value = Atendimento.ID_Destino;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se o Atendimento Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertAtendimento = "INSERT INTO ATENDIMENTO(ID_VEICULO, ID_MOTORISTA, ID_DESTINO) VALUES (@ID_VEICULO, @ID_MOTORISTA, @ID_DESTINO);";


                        command.CommandText = InsertAtendimento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Atendimento.ID_Veiculo;
                        command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Atendimento.ID_Motorista;
                        command.Parameters.Add("@ID_DESTINO", MySqlDbType.VarChar).Value = Atendimento.ID_Destino;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Atendimento_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Atendimento_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Atendimento já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Atendimento_Incluido;            
        }
        public bool Destino(Destino Destino)
        {
            try
            {
                string ConsultaDestino = "SELECT * FROM DESTINO WHERE ID_VEICULO = @ID_VEICULO AND ID_MOTORISTA = @ID_MOTORISTA AND LOCAL_CHEGADA = @LOCAL_CHEGADA AND LOCAL_SAIDA = @LOCAL_SAIDA AND DATAS_CHEGADA = @DATAS_CHEGADA AND DATAS_SAIDA = @DATAS_SAIDA;";
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
                adapter.Fill(table);

                //Verifica se o Destino Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertDestino = "INSERT INTO DESTINO(ID_VEICULO, ID_MOTORISTA, LOCAL_CHEGADA, LOCAL_SAIDA, DATAS_CHEGADA, DATAS_SAIDA) VALUES (@ID_VEICULO, @ID_MOTORISTA, @LOCAL_CHEGADA, @LOCAL_SAIDA, @DATAS_CHEGADA, @DATAS_SAIDA);";


                        command.CommandText = InsertDestino;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Destino.ID_Veiculo;
                        command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Destino.ID_Motorista;
                        command.Parameters.Add("@LOCAL_CHEGADA", MySqlDbType.VarChar).Value = Destino.Local_Chegada;
                        command.Parameters.Add("@LOCAL_SAIDA", MySqlDbType.VarChar).Value = Destino.Local_Saida;
                        command.Parameters.Add("@DATAS_CHEGADA", MySqlDbType.VarChar).Value = Destino.Data_Chegada;
                        command.Parameters.Add("@DATAS_SAIDA", MySqlDbType.VarChar).Value = Destino.Data_Saida;

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Destino_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Destino_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Salario já Existe", "Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Destino_Incluido;
        }
    }
}
