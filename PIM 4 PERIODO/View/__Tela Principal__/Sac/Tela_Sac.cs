﻿using PIM_4_PERIODO.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Sac
{
    public partial class Tela_Sac : Form
    {
        public Tela_Sac()
        {
            InitializeComponent();
        }

        private void Atendimento_Btn_Click(object sender, EventArgs e)
        {
            TelaPrincipal Principal = new TelaPrincipal();
            Principal.AbreAtendimento = true;
        }
    }
}
