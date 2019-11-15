using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_4_Periodo.Model;
using PIM_4_Periodo.Dao;



namespace PIM_4_Periodo.View
{
    public partial class Tela_Login : Form
    {
        Model.Login Login = new Model.Login();
        Consultar.Entra_Sistema bdlogin = new Consultar.Entra_Sistema();
        Principal Principal = new Principal();

        public Tela_Login()
        {
            InitializeComponent();
            Label_Error.Visible = false;
        }

        private void Repoisicionamento_ErrorLabel()
        {
            Label_Error.Visible = true;
            int PanelImg_Center = (this.Size.Width - Label_Error.Size.Width) / 2;
            Label_Error.Location = new Point(PanelImg_Center, Panel_LoginImg.Location.Y + Panel_LoginImg.Height);
        }

        private void Entra_Button_Click(object sender, EventArgs e)
        {
            Login.Usuario = txt_Usuario.Text;
            Login.Senha = txt_Senha.Text;

            if (Login.Usuario != "" && Login.Senha != "")
            {
                if (bdlogin.Validausuario(Login))
                {
                    this.Hide();
                    Principal.Show();
                }
                else
                {
                    Label_Error.Text = "Usuario ou Senha inválidos";
                    Repoisicionamento_ErrorLabel();
                }
            }
            else
            {
                Label_Error.Text = "Usuario e Senha não podem ser vazios";
                Repoisicionamento_ErrorLabel();
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Usuario_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_Usuario.Text != "")
            {
                Label_Error.Visible = false;
            }
        }

        private void Txt_Senha_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_Senha.Text != "")
            {
                Label_Error.Visible = false;
            }
        }
    }
}






