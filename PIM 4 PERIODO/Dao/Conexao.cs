using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Dao
{
    class Conexao
    {
        private MySqlConnection conexao = new MySqlConnection("server =  127.0.0.1; port = 3306; User Id = root; database = pim_4_periodo; password = ");


        public void Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        public bool Checkconection()
        {
            if (conexao.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public MySqlConnection Pega_Conexão()
        {
            return conexao;
        }

    }
}
