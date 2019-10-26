using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PIM_4_PERIODO.Model;



namespace PIM_4_PERIODO.Dao
{
    class Incluir
    {
        private Conexao Conexão = new Conexao();

       
        public void Abastecimento(Abastecimento Abastecimento)
        {
            string InsertAbastecimento = "INSERT INTO ABASTECIMENTO(KM_NO_ABASTECIMENTO, LITROS, VALOR, ID_POSTO, DATA) VALUES (@KM_NO_ABASTECIMENTO, @LITROS, @VALOR, @ID_POSTO, @DATA);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertAbastecimento);
            command.Parameters.Add("@KM_NO_ABASTECIMENTO", MySqlDbType.Float).Value = Abastecimento.Km_No_Abastecimento;
            command.Parameters.Add("@LITROS", MySqlDbType.Float).Value = Abastecimento.Litros;
            command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Abastecimento.Valor;
            command.Parameters.Add("@ID_POSTO", MySqlDbType.Int32).Value = Abastecimento.ID_Posto;
            command.Parameters.Add("@DATA", MySqlDbType.Date).Value = Abastecimento.Data;
            Conexão.Desconectar();
        }
        public void Combustivel(Combustivel Combustivel)
        {
            string InsertCombustivel = "INSERT INTO COMBUSTIVEL(NOME, VALOR, DATA) VALUES (@NOME, @VALOR, @DATA);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertCombustivel);
            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Combustivel.Nome;
            command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Combustivel.Valor;
            command.Parameters.Add("@DATA", MySqlDbType.Date).Value = Combustivel.Data;
            Conexão.Desconectar();
        }
        public void Departamento(Departamento Depatamento)
        {
            string InsertDepartamento = "INSERT INTO DEPARTAMENTO(NIVELACESSO, NOME) VALUES (@NIVELACESSO, @NOME);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertDepartamento);
            command.Parameters.Add("@NIVELACESSO", MySqlDbType.Int32).Value = Depatamento.NivelAcesso;
            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Depatamento.Nome;
            Conexão.Desconectar();
        }
        public void Manutenção(Manutenção Manutenção)
        {
            string InsertManutenção = "INSERT INTO DEPARTAMENTO(NUM_OS, ID_OFICINA, DATA_ENTRADA, DATA_SAIDA, MOTIVO, VALOR, ID_VEICULO) VALUES (@NUM_OS, @ID_OFICINA, @DATA_ENTRADA, @DATA_SAIDA, @MOTIVO, @VALOR, @ID_VEICULO);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertManutenção);
            command.Parameters.Add("@NUM_OS", MySqlDbType.Int32).Value = Manutenção.NumeroOS;
            command.Parameters.Add("@ID_OFICINA", MySqlDbType.Int32).Value = Manutenção.ID_Oficina;
            command.Parameters.Add("@DATA_ENTRADA", MySqlDbType.Date).Value = Manutenção.Data_Entrada;
            command.Parameters.Add("@DATA_SAIDA", MySqlDbType.Date).Value = Manutenção.Data_Saida;
            command.Parameters.Add("@MOTIVO", MySqlDbType.VarChar).Value = Manutenção.Motivo;
            command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Manutenção.Valor;
            command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Manutenção.ID_Veiculo;
            Conexão.Desconectar();
        }
        public void Multa(Multa Multa)
        {
            string InsertMulta = "INSERT INTO MULTA(NUM_INFRACAO, TIPO_INFRACAO, ID_MOTORISTA, ID_VEICULO, VALOR, DATA, ENDERECO) VALUES (@NUM_INFRACAO, @TIPO_INFRACAO, @ID_MOTORISTA, @ID_VEICULO, @VALOR, @DATA, @ENDERECO);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertMulta);
            command.Parameters.Add("@NUM_INFRACAO", MySqlDbType.Int32).Value = Multa.Infração;
            command.Parameters.Add("@TIPO_INFRACAO", MySqlDbType.VarChar).Value = Multa.Tipo;
            command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.Int32).Value = Multa.Motorista;
            command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Multa.Veiculo;
            command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Multa.Valor;
            command.Parameters.Add("@DATA", MySqlDbType.Date).Value = Multa.Data;
            command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Multa.Endereço;
            Conexão.Desconectar();
        }
        public void Notificação(Notificação Notificação)
        {
            string InsertNotificação = "INSERT INTO MULTA(ID_DEPARTAMENTO, TITULO, IMAGEM, DESCRICAO) VALUES (@ID_DEPARTAMENTO, @TITULO, @IMAGEM, @DESCRICAO);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertNotificação);
            command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value = Notificação.ID_Departamento;
            command.Parameters.Add("@TITULO", MySqlDbType.VarChar).Value = Notificação.Titulo;
            command.Parameters.Add("@IMAGEM", MySqlDbType.VarChar).Value = Notificação.Imagem;
            command.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar).Value = Notificação.Descrição;
            Conexão.Desconectar();
        }
        public void Oficina(Oficina Oficina)
        {
            string InsertOficina = "INSERT INTO MULTA(NOME, CNPJ, RAZAO_SOCIAL, TELEFONE, CELULAR, SITE, ENDERECO) VALUES (@NOME, @CNPJ, @RAZAO_SOCIAL, @TELEFONE, @CELULAR, @SITE, @ENDERECO);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertOficina);
            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oficina.Nome;
            command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Oficina.CNPJ;
            command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Oficina.RazaoSocial;
            command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Oficina.Telefone;
            command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Oficina.Celular;
            command.Parameters.Add("@SITE", MySqlDbType.VarChar).Value = Oficina.Site;
            command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Oficina.Endereço;
            Conexão.Desconectar();
        }
        public void Oleo(Oleo Oleo)
        {
            string InsertOleo = "INSERT INTO OLEO(NOME, MARCA, LITROS) VALUES (@NOME, @MARCA, @LITROS);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertOleo);
            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oleo.Nome;
            command.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = Oleo.Marca;
            command.Parameters.Add("@LITROS", MySqlDbType.Float).Value = Oleo.Litros;
            Conexão.Desconectar();
        }
        public void Posto(Posto Posto)
        {
            string InsertPosto = "INSERT INTO POSTO(NOME, CNPJ, RAZAO_SOCIAL, TELEFONE, CELULAR, SITE, ENDERECO) VALUES (@NOME, @CNPJ, @RAZAO_SOCIAL, @TELEFONE, @CELULAR, @SITE, @ENDERECO);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertPosto);
            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Posto.Nome;
            command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Posto.CNPJ;
            command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Posto.RazaoSocial;
            command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Posto.Telefone;
            command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Posto.Celular;
            command.Parameters.Add("@SITE", MySqlDbType.VarChar).Value = Posto.Site;
            command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Posto.Endereço;
            Conexão.Desconectar();
        }
        public void Salario(Salario Salario)
        {
            string InsertSalario = "INSERT INTO SALARIO(VALOR) VALUES (@VALOR);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertSalario);
            command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Salario.Valor; ;
            Conexão.Desconectar();
        }
        public void Usuario(Usuario Usuario)
        {
            string InsertUsuario = "INSERT INTO USUARIO(USERNAME, SENHA, DEPARTAMENTO, NOME, EMAIL, CPF, TELEFONE, CELULAR, ENDERECO, CNH, VALIDADE_CNH, CATEGORIA_CNH, CATEGORIA_CNH, DATA_ADIMISSAO) VALUES (@USERNAME, @SENHA, @DEPARTAMENTO, @NOME, @EMAIL, @CPF, @TELEFONE, @CELULAR, @ENDERECO, @CNH, @VALIDADE_CNH, @CATEGORIA_CNH, @CATEGORIA_CNH, @DATA_ADIMISSAO);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertUsuario);
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
            command.Parameters.Add("@DATA_ADIMISSAO", MySqlDbType.Date).Value = Usuario.Categoria_CNH;

            Conexão.Desconectar();
        }
        public void Veiculo(Veiculo Veiculo)
        {
            string InsertVeiculo = "INSERT INTO VEICULO(PLACA, MODELO, TIPO, MARCA, ANO, RENAVAM, CHSSI_NUM, KM_POR_LITRO, KM_TROCA_OLEO, KM_REVISAO, KM_PNEU, CAPACIDADE_TANQUE, ID_COMBUSTIVEL) VALUES (@PLACA, @MODELO, @TIPO, @MARCA, @ANO, @RENAVAM, @CHSSI_NUM, @KM_POR_LITRO, @KM_TROCA_OLEO, @KM_REVISAO, @KM_PNEU, @CAPACIDADE_TANQUE, @ID_COMBUSTIVEL);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertVeiculo);
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
            Conexão.Desconectar();
        }
        public void Atendimento(Atendimento Atendimento)
        {
            string InsertAtendimento = "INSERT INTO ATENDIMENTO(ID_VEICULO, ID_MOTORISTA, ID_DESTINO) VALUES (@ID_VEICULO, @ID_MOTORISTA, @ID_DESTINO);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertAtendimento);
            command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Atendimento.ID_Veiculo;
            command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Atendimento.ID_Motorista;
            command.Parameters.Add("@ID_DESTINO", MySqlDbType.VarChar).Value = Atendimento.ID_Destino;
            Conexão.Desconectar();
        }
        public void Destino(Destino Destino)
        {
            string InsertDestino = "INSERT INTO ATENDIMENTO(ID_VEICULO, ID_MOTORISTA, LOCAL_CHEGADA, LOCAL_SAIDA, DATA_CHEGADA, DATA_SAIDA) VALUES (@ID_VEICULO, @ID_MOTORISTA, @LOCAL_CHEGADA, @LOCAL_SAIDA, @DATA_CHEGADA, @DATA_SAIDA);";

            Conexão.Conectar();
            MySqlCommand command = new MySqlCommand(InsertDestino);
            command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Destino.ID_Veiculo;
            command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Destino.ID_Motorista;
            command.Parameters.Add("@LOCAL_CHEGADA", MySqlDbType.VarChar).Value = Destino.Local_Chegada;
            command.Parameters.Add("@LOCAL_SAIDA", MySqlDbType.VarChar).Value = Destino.Local_Saida;
            command.Parameters.Add("@DATA_CHEGADA", MySqlDbType.VarChar).Value = Destino.Data_Chegada;
            command.Parameters.Add("@DATA_SAIDA", MySqlDbType.VarChar).Value = Destino.Data_Saida;
            Conexão.Desconectar();
        }

    }
}
