﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_4_PERIODO.View;



namespace PIM_4_PERIODO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bntRegistrar(object sender, EventArgs e)
        {
            Registro regis = new Registro();
            this.Hide();
            regis.Show();
        }

        private void BntLogar(object sender, EventArgs e)
        {
            //Aqui vamos pegar os dados do texto 
            Model.Login person = new Model.Login();
            person.Usuario = (TxtLogin.Text);
            person.Senha = (txtSenha.Text);
            //Aqui vai aparecer a tela principal
            if (TxtLogin.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Por favor Digite seus dados");
            }
            else {
                 View.Principal prin = new View.Principal();
                 this.Hide();
                 prin.Show();
            }
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            //Aqui vamos pegar os dados do texto 
            Model.Login person = new Model.Login();
            person.Usuario = (TxtLogin.Text);
            person.Senha = (txtSenha.Text);
            //Aqui vai aparecer a tela principal
            if (TxtLogin.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Por favor Digite seus dados");
            }
            else
            {
                View.Principal prin = new View.Principal();
                this.Hide();
                prin.Show();
            }
        }

        private void TxtLogin_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
