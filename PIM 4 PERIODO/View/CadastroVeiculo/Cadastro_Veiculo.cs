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

namespace PIM_4_PERIODO.View.CadastroVeiculo
{
    public partial class Cadastro_Veiculo : Form
    {
        public Cadastro_Veiculo()
        {
            InitializeComponent();
        }

        private void bntLCadastrar_Click(object sender, EventArgs e)
        {
            //Aqui aonde vamos cadastrar o veiculo 
              Veiculo carro = new Veiculo();
              carro.Marca = txtMarca.Text;
              carro.Modelo = txtModelo.Text;
              carro.Placa = txtMarca.Text;
              carro.Renavam = Convert.ToInt32(txt_Renavam.Text);
              carro.KM_TrocaPneu = Convert.ToInt32(txt_KmPneu.Text);
              carro.Chassi = txt_Chassi.Text;
 
            MessageBox.Show("Cadastrado com sucesso");


        }
    }
}
