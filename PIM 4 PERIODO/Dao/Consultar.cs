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
        private Conexao Conexão = new Conexao();
        private bool Usuario_Existe = false;

        public bool Entra_Sistema(Login Login)
        {
            if (!Conexão.Checkconection())
            {
                Conexão.Conectar();
            }

            if (Conexão.Checkconection())
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM LOGIN WHERE USUARIO = @usuario AND SENHA = @senha", Conexão.Pega_Conexão());

                command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = Login.Usuario;
                command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Login.Senha;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se há uma lina no banco com esse Usuário.
                if (table.Rows.Count > 0)
                {
                    Usuario_Existe = true;
                }

                Conexão.Desconectar();
            }

            return Usuario_Existe;
        }


    }
}
