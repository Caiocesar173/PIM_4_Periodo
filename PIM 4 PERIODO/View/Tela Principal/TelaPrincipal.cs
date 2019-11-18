using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PIM_4_PERIODO.View.Tela_Principal.Home;
using PIM_4_PERIODO.View.Tela_Principal.Solicitacao;
using PIM_4_PERIODO.View.Cadastro;


namespace PIM_4_PERIODO.View
{
    public partial class TelaPrincipal : Form
    {
        //public Image img = Properties.Resources.Background_Principal;
        Tela_Home Home = new Tela_Home();
        Tela_Solicitacao Solicitacao = new Tela_Solicitacao();
        View.Cadastro.AdicionarUsuarioSistema cadastro = new Cadastro.AdicionarUsuarioSistema();
        public TelaPrincipal()
        {
            
            InitializeComponent();

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

        private void Home_btn_Click(object sender, EventArgs e)
        {
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }

            if (!Home_btn.Active)
            {
                Home = new Tela_Home();
                Home.TopLevel = false;
                Home.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Home);
                Home.Show();
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
                Solicitacao = new Tela_Solicitacao();
                Solicitacao.TopLevel = false;
                Solicitacao.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Solicitacao);
                Solicitacao.Show();
            }
        }
        private void Atendimento_btn_Click(object sender, EventArgs e)
        {
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (!Home_btn.Active)
            {

                Home.Close();
            }
        }

        private void Cadastro_btn_Click(object sender, EventArgs e)
        {
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Home_btn.Active)
            {

                Home.Close();
            }
            if (Cadastro_btn.Active)
            {
                cadastro = new Cadastro.AdicionarUsuarioSistema();
                cadastro.Show();

            }
        }

        private void Relatorios_btn_Click(object sender, EventArgs e)
        {
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (!Home_btn.Active)
            {
                Home.Close();
            }
        }

        private void SAC_btn_Click(object sender, EventArgs e)
        {
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (!Home_btn.Active)
            {
                Home.Close();
            }
        }

        private void Panel_Menus_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(759, 564);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Panel_Menus_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
