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
        private MySqlConnection conexao = new MySqlConnection("server = remotemysql.com; port = 3306; User Id = VJ81Ningl1; database = VJ81Ningl1; password = dRhi22fRBt");


        public void Conectar()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                }
            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Desconectar()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (MySqlException Exception)
            {

            }
        }
        public bool Checkconection()
        {
            bool retorno = false;
            try
            {
                if (conexao.State == ConnectionState.Open)
                {
                    retorno = true;
                }
            }
            catch (MySqlException Exception)
            {

            }

            return retorno;
        }
        public MySqlConnection Pega_Conexão()
        {
            return conexao;
        }

    }
}
