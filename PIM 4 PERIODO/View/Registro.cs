using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_4_PERIODO.Model;



namespace PIM_4_PERIODO.View
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void BntCadastrar_Click(object sender, EventArgs e)
        {
            //Aqui vamos pegar os campos da cadastro 
            Usuario person2 =  new Usuario();
            person2.Nome = (txtNome.Text);
            person2.Username = (txtUser.Text);
            person2.CPF = (txtCPF.Text);
            person2.Categoria_CNH = (txtCatCnh.Text);
            person2.Email = (txtEmail.Text);
            person2.Departamento = (txtDepartamento.Text);
            person2.Senha = (txtSen.Text);

            if (txtSen.Text == txtConfirSen.Text)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Usuários não cadastrado");
            }
           
        }
    }
}
