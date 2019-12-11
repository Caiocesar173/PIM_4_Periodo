using PIM_4_PERIODO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro
{
    public partial class Tela_Destino : Form
    {
        Dao.Incluir Incluir = new Dao.Incluir();
        Dao.Consultar Consultar = new Dao.Consultar();
        Destino Destino = new Destino();

        public Tela_Destino()
        {
           
            InitializeComponent();
            LoadVeiculos();
            LoadMotoristas();

        }
        private void LoadMotoristas()
        {
            DataTable Table_Deparatemnto = new DataTable();
            DataTable Table_Motoristas = new DataTable();
            Departamento Departamento = new Departamento();
            Model.Usuario Usuario = new Model.Usuario();

            int DepartamentoMotorista = 0;
            Table_Deparatemnto = Consultar.Departamento(Departamento, 3);
            for (int i = Table_Deparatemnto.Rows.Count - 1; i >= 0; i--)
            {
                if(Table_Deparatemnto.Rows[i][2].ToString() == "Motorista")
                {
                    DepartamentoMotorista = Convert.ToInt32(Table_Deparatemnto.Rows[i][0]);
                }
            }

            Table_Motoristas = Consultar.Usuario(Usuario, 8);
            for (int i = Table_Motoristas.Rows.Count - 1, j = 0; i >= 0; i--)
            { 
                if(Convert.ToInt32(Table_Motoristas.Rows[i][3]) == 3)
                {
                    ComboBox_Motorista.Items.Insert(j, Table_Motoristas.Rows[i][1]);
                    j++;
                }
            }
            ComboBox_Motorista.SelectedItem = 0;

        }
        private void LoadVeiculos()
        {
            DataTable Table_Veiculos = new DataTable();
            Model.Veiculo Veiculo = new Model.Veiculo();

            Table_Veiculos = Consultar.Veiculo(Veiculo, 9);
            for(int i = Table_Veiculos.Rows.Count - 1, j = 0 ; i >= 0; i--, j++)
            {
                //VeiculosDic = (Table_Veiculos.Rows[j][0], Table_Veiculos.Rows[j][2], j);
                ComboBox_Veiculo.Items.Insert(j, Convert.ToString(Table_Veiculos.Rows[j][2]));
            }
            ComboBox_Veiculo.SelectedItem = 0;
        }

        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), CadastroDestino_Label.Location.Y + Error_Label.Height + CadastroDestino_Label.Height + 5);
        }
        private void Cadastrar_Btn_Click(object sender, EventArgs e) 
        {
            if (TxTBox_Saida.Text != "" && TxTBox_Local_Chegada.Text != "" && TxTBox_Data_Saida.Text != "" && TxTBox_Data_Chegada.Text != "")
            {
                Console.WriteLine("Data Saida; " + TxTBox_Data_Saida.Text);
                Console.WriteLine("Data Chegada: " + TxTBox_Data_Chegada.Text);
               
                Destino.ID_Motorista = ComboBox_Motorista.SelectedIndex;
                Destino.ID_Veiculo = ComboBox_Veiculo.SelectedIndex;

                //Falta o ID do veiculo
                Destino.Local_Saida = TxTBox_Saida.Text;
                Destino.Local_Chegada = TxTBox_Local_Chegada.Text;
                Destino.Data_Chegada = Convert.ToDateTime(TxTBox_Data_Chegada.Text);
                Destino.Data_Saida = Convert.ToDateTime(TxTBox_Data_Saida.Text);


                if (Incluir.Destino(Destino, 1))
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
    }
}
