using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Entrega_de_Veiculo
{
    public partial class Tela_Entrega_Veiculo : Form
    {
        public Tela_Entrega_Veiculo()
        {
            InitializeComponent();
        }

        private void Bnt_Registrar_Devolucao_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Veiculo Entregue com sucesso");
        }
    }
}
