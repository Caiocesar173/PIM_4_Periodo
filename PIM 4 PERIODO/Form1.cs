using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntRegistrar(object sender, EventArgs e)
        {

        }

        private void BntLogar(object sender, EventArgs e)
        {
            //Aqui vamos pegar os dados do texto 
            Model.Login person = new Model.Login();

            
        }
    }
}
