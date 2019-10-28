using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using PIM_4_PERIODO.Model;



namespace PIM_4_PERIODO.Dao
{
    class Consultar
    {
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

        private bool Login_Existe = false;
        public bool Abastecimento_Existe = false;
        public bool Combustivel_Existe = false;
        public bool Departamento_Existe = false;
        public bool Destino_Existe = false;
        public bool Manutenção_Existe = false;
        public bool Multa_Existe = false;
        public bool Notificação_Existe = false;
        public bool Oficina_Existe = false;
        public bool Oleo_Existe = false;
        public bool Posto_Existe = false;
        public bool Salario_Existe = false;
        public bool Usuario_Existe = false;
        public bool Veiculo_Existe = false;


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
                    MySqlCommand command = new MySqlCommand("SELECT * FROM USUARIO WHERE USERNAME = @usuario AND SENHA = @senha", Conexão.Pega_Conexão());

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

            }

            return Usuario_Existe;
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
                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM ABASTECIMENTO WHERE KM_NO_ABASTECIMENTO = @Km_Abastecimento AND LITROS = @Litros AND VALOR = @Valor AND ID_POSTO = @ID_Posto AND ID_VEICULO = @ID_Veiculo AND DATA = @Data;", Conexão.Pega_Conexão());   

                    command.Parameters.Add("@Km_Abastecimento", MySqlDbType.Float).Value = Abastecimento.Km_No_Abastecimento;
                    command.Parameters.Add("@Litros", MySqlDbType.Float).Value = Abastecimento.Litros;
                    command.Parameters.Add("@Valor", MySqlDbType.Float).Value = Abastecimento.Valor;
                    command.Parameters.Add("@ID_Posto", MySqlDbType.Int32).Value = Abastecimento.ID_Posto;
                    command.Parameters.Add("@ID_Veiculo", MySqlDbType.Int32).Value = Abastecimento.ID_Veiculo;
                    command.Parameters.Add("@Data", MySqlDbType.Date).Value = Abastecimento.Data;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableAbastecimento);

                    //Verifica se há uma lina no banco com esse Abastecimento.
                    if (TableAbastecimento.Rows.Count > 0)
                    {
                        Abastecimento_Existe = true;
                        return TableAbastecimento;
                    }

                    Conexão.Desconectar();
                }
            }
            catch(MySqlException Exception)
            {

            }

            return TableAbastecimento;
        }
        public DataTable Atendimento(Atendimento Atendimento)
        {
            /*
                 ID_VEICULO int not null, 
		    ID_MOTORISTA int not null,
		    ID_DESTINO int not null,  
             */
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM ABASTECIMENTO WHERE KM_NO_ABASTECIMENTO = @Km_Abastecimento AND LITROS = @Litros AND VALOR = @Valor AND ID_POSTO = @ID_Posto AND ID_VEICULO = @ID_Veiculo AND DATA = @Data;", Conexão.Pega_Conexão());

                    command.Parameters.Add("@Km_Abastecimento", MySqlDbType.Float).Value = Abastecimento.Km_No_Abastecimento;
                    command.Parameters.Add("@Litros", MySqlDbType.Float).Value = Abastecimento.Litros;
                    command.Parameters.Add("@Valor", MySqlDbType.Float).Value = Abastecimento.Valor;
                    command.Parameters.Add("@ID_Posto", MySqlDbType.Int32).Value = Abastecimento.ID_Posto;
                    command.Parameters.Add("@ID_Veiculo", MySqlDbType.Int32).Value = Abastecimento.ID_Veiculo;
                    command.Parameters.Add("@Data", MySqlDbType.Date).Value = Abastecimento.Data;
                    adapter.SelectCommand = command;
                    adapter.Fill(TableAbastecimento);

                    //Verifica se há uma lina no banco com esse Abastecimento.
                    if (TableAbastecimento.Rows.Count > 0)
                    {
                        Abastecimento_Existe = true;
                        return TableAbastecimento;
                    }

                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {

            }

            return TableAbastecimento;
        }
        public void Combustivel(Combustivel Combustivel)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Departamento(Departamento Depatamento)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Destino(Destino Destino)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Manutenção(Manutenção Manutenção)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Multa(Multa Multa)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Notificação(Notificação Notificação)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Oficina(Oficina Oficina)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Oleo(Oleo Oleo)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Posto(Posto Posto)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Salario(Salario Salario)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Usuario(Usuario Usuario)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Veiculo(Veiculo Veiculo)
        {
            try
            {

            }
            catch (MySqlException Exception)
            {

            }
        }

    }
}
