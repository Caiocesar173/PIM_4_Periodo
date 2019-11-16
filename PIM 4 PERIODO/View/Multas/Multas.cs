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

namespace PIM_4_PERIODO.View.Multas
{
    public partial class Multas : Form
    {
        public Multas()
        {
            InitializeComponent();
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            //Aqui vamos passar os dados da multa 
            Multa multa = new Multa();
            //Veiculo Multado
            multa.Veiculo = Convert.ToInt16(txtID_Veiculo.Text);
           // multa.Data = Convert.ToInt16(txtData_Entrada.Text);
            //multa
        }
    }
}
