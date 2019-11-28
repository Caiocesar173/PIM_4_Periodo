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

            PIM_4_PERIODO.Dao.Incluir objCadastro = new Dao.Incluir();

         
            //Aqui aonde vamos cadastrar o veiculo 
              Veiculo Veiculo = new Veiculo();
              Veiculo.Marca = txtMarca.Text;
              Veiculo.Modelo = txtModelo.Text;
              Veiculo.Placa = txtMarca.Text;
              Veiculo.Renavam = Convert.ToInt32(txt_Renavam.Text);
              Veiculo.KM_TrocaPneu = Convert.ToInt32(txt_KmPneu.Text);
              Veiculo.Chassi = txt_Chassi.Text;

              objCadastro.Veiculo(Veiculo);

            MessageBox.Show("Cadastrado com sucesso");


        }
    }
}
