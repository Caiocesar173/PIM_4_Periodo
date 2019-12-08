using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Usuario
{
    public partial class Tela_Usuario : Form
    {
        DataTable Table = new DataTable();
        Model.Usuario Usuario = new Model.Usuario();
        Model.Departamento Departamento = new Model.Departamento();
        Dao.Incluir Incluir = new Dao.Incluir();
        Dao.Consultar Conslutar = new Dao.Consultar();

        public Tela_Usuario()
        {
            Table = Conslutar.Departamento(Departamento, 3);
            for(int i = Table.Rows.Count; i <= 0; i--)
            {
                Console.WriteLine("ID: " + Table.Rows[i][0] + "Departamento: " + Table.Rows[i][2]);
                //Table.Rows[i][2];
            }
            InitializeComponent();
        }

        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), CadastroUsuario_Label.Location.Y + Error_Label.Height + CadastroUsuario_Label.Height + 5);
        }
        private void Cancelar_Btn_Click(object sender, EventArgs e)
        {
            Tela_Cadastro Cadastro = new Tela_Cadastro();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Cadastro.TopLevel = false;
            PainelCentral.Controls.Add(Cadastro);
            this.Controls.Add(PainelCentral);
            PainelCentral.BringToFront();
            Cadastro.Show();
            PainelCentral.Show();
        }
        private void Cadastrar_Btn_Click(object sender, EventArgs e)
        {
            if (TxTBox_Litragem.Text != "" && TxTBox_Marca.Text != "" && TxTBox_Nome.Text != "")
            {
                if (TxTBox_Litragem.Text.Contains(","))
                {
                    TxTBox_Litragem.Text = TxTBox_Litragem.Text.Replace(",", ".");
                }

                if (Incluir.Usuario(Usuario, 1))
                {
                    Repoisicionamento_Label(Sucesso_Label);
                }
                else
                {
                    Error_Label.Text = "Ocorreu um erro durante o Cadastro";
                    Repoisicionamento_Label(Error_Label);
                }
            }
            else
            {
                Error_Label.Text = "Os campos não podem ser vazios";
                Repoisicionamento_Label(Error_Label);
            }
        }
    }
}
