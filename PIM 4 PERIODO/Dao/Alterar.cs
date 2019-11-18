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
    class Alterar
    {
        private Conexao Conexão = new Conexao();
        private Consultar Consulta = new Consultar();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        private bool Abastecimento_Alterado = false;
        private bool Combustivel_Alterado = false;
        private bool Departamento_Alterado = false;
        private bool Manutenção_Alterado = false;
        private bool Multa_Alterado = false;
        private bool Notificação_Alterado = false;
        private bool Oficina_Alterado = false;
        private bool Oleo_Alterado = false;
        private bool Posto_Alterado = false;
        private bool Salario_Alterado = false;
        private bool Usuario_Alterado = false;
        private bool Veiculo_Alterado = false;
        private bool Atendimento_Alterado = false;
        private bool Destino_Alterado = false;



        public bool Abastecimento(Abastecimento Abastecimento)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();

                table = Consulta.Abastecimento(Abastecimento);

                //Verifica se o Abastecimento Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterAbastecimento = "UPDATE ABASTECIMENTO SET KM_NO_ABASTECIMENTO = @KM_NO_ABASTECIMENTO, LITROS = @LITROS, VALOR = @VALOR, ID_POSTO = @ID_POSTO, ID_VEICULO = @ID_VEICULO, DATAS = @DATAS WHERE ID_ABASTECIMENTO = @ID_ABASTECIMENTO;";


                        command.CommandText = AlterAbastecimento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@KM_NO_ABASTECIMENTO", MySqlDbType.VarChar).Value = Abastecimento.Km_No_Abastecimento;
                        command.Parameters.Add("@LITROS", MySqlDbType.VarChar).Value = Abastecimento.Litros;
                        command.Parameters.Add("@VALOR", MySqlDbType.VarChar).Value = Abastecimento.Valor;
                        command.Parameters.Add("@ID_POSTO", MySqlDbType.VarChar).Value = Abastecimento.ID_Posto;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Abastecimento.ID_Veiculo;
                        command.Parameters.Add("@DATAS", MySqlDbType.VarChar).Value = Abastecimento.Data;
                        command.Parameters.Add("@ID_ABASTECIMENTO", MySqlDbType.Int32).Value =  table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Abastecimento_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Abastecimento_Alterado;
                    }
                }
                else
                {

                    MessageBox.Show("Atendimento não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Abastecimento_Alterado;

        }
        public bool Combustivel(Combustivel Combustivel)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Combustivel(Combustivel);

                //Verifica se o Combustivel Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterCombustivel = "UPDATE COMBUSTIVEL SET NOME = @NOME, VALOR = @VALOR, DATAS = @DATAS WHERE ID_COMBUSTIVEL = @ID_COMBUSTIVEL;";


                        command.CommandText = AlterCombustivel;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Combustivel.Nome;
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Combustivel.Valor;
                        command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Combustivel.Data;
                        command.Parameters.Add("@ID_COMBUSTIVEL", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Combustivel_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Combustivel_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Combustivel não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Combustivel_Alterado;
        }
        public bool Departamento(Departamento Depatamento)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Departamento(Depatamento);

                //Verifica se o Departamento Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterDepartamento = "UPDATE DEPARTAMENTO SET NOME = @NOME, NIVELACESSO = @NIVELACESSO WHERE ID_DEPARTAMENTO = @ID_DEPARTAMENTO;";


                        command.CommandText = AlterDepartamento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NIVELACESSO", MySqlDbType.Int32).Value = Depatamento.NivelAcesso;
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Depatamento.Nome;
                        command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value =  table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Departamento_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Departamento_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Departamento não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Departamento_Alterado;
        }
        public bool Manutenção(Manutenção Manutenção)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Manutenção(Manutenção);


                //Verifica se o Manutenção Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertManutençãoo = "UPDATE MANUTENCAO SET NUM_OS = @NUM_OS, ID_OFICINA = @ID_OFICINA, DATAS_ENTRADA = @DATAS_ENTRADA, DATAS_SAIDA = @DATAS_SAIDA, MOTIVO = @MOTIVO, VALOR = @VALOR, ID_VEICULO = @ID_VEICULO WHERE ID_MANUTENCAO = @ID_MANUTENCAO;";


                        command.CommandText = InsertManutençãoo;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NUM_OS", MySqlDbType.Int32).Value = Manutenção.NumeroOS;
                        command.Parameters.Add("@ID_OFICINA", MySqlDbType.Int32).Value = Manutenção.ID_Oficina;
                        command.Parameters.Add("@DATAS_ENTRADA", MySqlDbType.Date).Value = Manutenção.Data_Entrada;
                        command.Parameters.Add("@DATAS_SAIDA", MySqlDbType.Date).Value = Manutenção.Data_Saida;
                        command.Parameters.Add("@MOTIVO", MySqlDbType.VarChar).Value = Manutenção.Motivo;
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Manutenção.Valor;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Manutenção.ID_Veiculo;
                        command.Parameters.Add("@ID_MANUTENCAO", MySqlDbType.Int32).Value =  table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Manutenção_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Manutenção_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Manutenção não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Manutenção_Alterado;
        }
        public bool Multa(Multa Multa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Multa(Multa);

                //Verifica se o Multa Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        
                        string InsertMulta = "UPDATE MULTA SET NUM_INFRACAO = @NUM_INFRACAO, TIPO_INFRACAO = @TIPO_INFRACAO, ID_MOTORISTA = @ID_MOTORISTA, ID_VEICULO = @ID_VEICULO, VALOR = @VALOR, DATAS = @DATAS, ENDERECO = @ENDERECO WHERE ID_MULTA = @ID_MULTA";


                        command.CommandText = InsertMulta;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NUM_INFRACAO", MySqlDbType.Int32).Value = Multa.Infração;
                        command.Parameters.Add("@TIPO_INFRACAO", MySqlDbType.VarChar).Value = Multa.Tipo;
                        command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.Int32).Value = Multa.Motorista;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Multa.Veiculo;
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Multa.Valor;
                        command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Multa.Data;
                        command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Multa.Endereço;
                        command.Parameters.Add("@ID_MULTA", MySqlDbType.Int32).Value =  table.Rows[0][0];
                        
                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Multa_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Multa_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Multa não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Multa_Alterado;
        }
        public bool Notificação(Notificação Notificação)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Notificação(Notificação);

                //Verifica se o Notificação Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertNotificação = "UPDATE NOTIFICACAO SET ID_DEPARTAMENTO = @ID_DEPARTAMENTO, TITULO = @TITULO, IMAGEM = @IMAGEM, DESCRICAO = @DESCRICAO  WHERE ID_NOTIFICACAO = @ID_NOTIFICACAO;";


                        command.CommandText = InsertNotificação;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value = Notificação.ID_Departamento;
                        command.Parameters.Add("@TITULO", MySqlDbType.VarChar).Value = Notificação.Titulo;
                        command.Parameters.Add("@IMAGEM", MySqlDbType.VarChar).Value = Notificação.Imagem;
                        command.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar).Value = Notificação.Descrição;
                        command.Parameters.Add("@ID_NOTIFICACAO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Notificação_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Notificação_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Notificação não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Notificação_Alterado;
        }
        public bool Oficina(Oficina Oficina)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Oficina(Oficina);

                //Verifica se o Oficina Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string InsertOficina = "UPDATE OFICINA SET NOME = @NOME, CNPJ = @CNPJ, RAZAO_SOCIAL = @RAZAO_SOCIAL, TELEFONE = @TELEFONE, CELULAR = @CELULAR, SITE = @SITE, ENDERECO = @ENDERECO WHERE ID_OFICINA = @ID_OFICINA;";


                        command.CommandText = InsertOficina;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oficina.Nome;
                        command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Oficina.CNPJ;
                        command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Oficina.RazaoSocial;
                        command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Oficina.Telefone;
                        command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Oficina.Celular;
                        command.Parameters.Add("@SITE", MySqlDbType.VarChar).Value = Oficina.Site;
                        command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Oficina.Endereço;
                        command.Parameters.Add("@ID_OFICINA", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Oficina_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Oficina_Alterado;    
                    }
                }
                else
                {
                    MessageBox.Show("Oficina não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Oficina_Alterado;
        }
        public void Oleo(Oleo Oleo)
        {

        }
        public void Posto(Posto Posto)
        {

        }
        public void Salario(Salario Salario)
        {

        }
        public void Usuario(Usuario Usuario)
        {

        }
        public void Veiculo(Veiculo Veiculo)
        {

        }
        public void Atendimento(Atendimento Atendimento)
        {

        }
        public void Destino(Destino Destino)
        {

        }

    }
}
