using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PIM_4_PERIODO.View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button4_click(object sender, EventArgs e)
        {
            
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            Registro regis = new Registro();
            this.Hide();
            regis.Show();
        }
    }
}
