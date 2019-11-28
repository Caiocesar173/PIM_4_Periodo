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

namespace PIM_4_PERIODO.View.Posto_de_Abastecimento
{
    public partial class CadastrarPosto : Form
    {
        public CadastrarPosto()
        {
            InitializeComponent();
        }

        private void bntInseriPosto_Click(object sender, EventArgs e)
        {
            PIM_4_PERIODO.Dao.Incluir objCadastro = new Dao.Incluir();
            Posto posto = new Posto();
            posto.RazaoSocial = txtRposto.Text;
            posto.Nome = txtNposto.Text;
            posto.Telefone = Convert.ToInt32(txtTposto.Text);
            posto.Celular =  Convert.ToInt32(txtCPposto.Text);
            objCadastro.Posto(posto);   
            
            /*
            Veiculo carro = new Veiculo();
            carro.Marca = txtMarca.Text;
            carro.Modelo = txtModelo.Text;
            carro.Placa = txtMarca.Text;
            */
        }
    }
}
