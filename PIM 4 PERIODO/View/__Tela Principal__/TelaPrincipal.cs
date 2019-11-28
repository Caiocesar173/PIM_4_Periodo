﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


using PIM_4_Periodo.View;
using PIM_4_PERIODO.View.__Tela_Principal__.Home;
using PIM_4_PERIODO.View.__Tela_Principal__.Solicitacao;
using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro;
using PIM_4_PERIODO.View.__Tela_Principal__.Sac;
using PIM_4_PERIODO.View.__Tela_Principal__.Chat;


namespace PIM_4_PERIODO.View
{
    public partial class TelaPrincipal : Form
    {
        Tela_Home Home;
        Tela_SolicitaçãoInicial Solicitacao;
        Tela_Cadastro Cadastro;
        Tela_Sac Sac;
        Tela_Chat Chat;

        public bool AbreAtendimento = false;
        public TelaPrincipal()
        {

            InitializeComponent();

            //Incia Sempre o sistema com o Botao Home Ativo
            if (Home_btn.Active)
            {
                Home = new Tela_Home();
                Home.TopLevel = false;
                Home.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Home);
                Home.Show();
            }

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            Tela_Login Login = new Tela_Login();
            this.Hide();
            Login.Show();
        }


        //Botões do Painel de menus
        private void Home_btn_Click(object sender, EventArgs e)
        {
            if (!Home_btn.Active)
            {
                Home = new Tela_Home();
                Home.TopLevel = false;
                Home.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Home);
                Home.Show();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                AbreAtendimento = false;
            }

        }
        private void Solicitacao_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home.Close();
            }
            if (!Solicitacao_btn.Active)
            {
                Solicitacao = new Tela_SolicitaçãoInicial();
                Solicitacao.TopLevel = false;
                Solicitacao.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Solicitacao);
                Solicitacao.Show();
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                AbreAtendimento = false;
            }

        }
        private void Atendimento_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
            if (!Atendimento_btn.Active || AbreAtendimento)
            {
                Chat = new Tela_Chat();
                Chat.TopLevel = false;
                Chat.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Chat);
                Chat.Show();
            }
            
        }
        private void Cadastro_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (!Cadastro_btn.Active)
            {
                Cadastro = new Tela_Cadastro();
                Cadastro.TopLevel = false;
                Cadastro.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Cadastro);
                Cadastro.Show();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                AbreAtendimento = false;
            }

        }
        private void Relatorios_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                AbreAtendimento = false;
            }
        }
        private void SAC_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (!SAC_btn.Active)
            {
                Sac = new Tela_Sac();
                Sac.TopLevel = false;
                Sac.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Sac);
                Sac.Show();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                AbreAtendimento = false;
            }
            
        }
        private void Abastecimento_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                AbreAtendimento = false;
            }

        }
    }
}
