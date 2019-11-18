using System;
using System.Drawing;
using System.Windows.Forms;
using PIM_4_PERIODO.Model;
using PIM_4_PERIODO.Dao;
using PIM_4_PERIODO.View;

namespace PIM_4_Periodo.View
{
    public partial class Tela_Login : Form
    {
        PIM_4_PERIODO.Login Login = new PIM_4_PERIODO.Login();
        Consultar Consulta = new Consultar();
        TelaPrincipal Principal = new TelaPrincipal();

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
                if (Consulta.Entra_Sistema(Login))
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

        private void Label_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void Label_Error_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Login_Load(object sender, EventArgs e)
        {

        }
    }
}






