﻿using PIM_4_PERIODO.Model;
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
    public partial class Tela_Departamento : Form
    {
        Departamento departamento = new Departamento();
        public Tela_Departamento()
        {
            InitializeComponent();
        }

        private void Bnt_Salvar_Departamento_Click(object sender, EventArgs e)
        {
            if(TxTBox_Nivel_Departamento.Text != "" && TxTBox_Nome_Departamento.Text != "")
            {
                //Departamento departamento = new Departamento();
                departamento.Nome = TxTBox_Nome_Departamento.Text;
                departamento.NivelAcesso = int.Parse(TxTBox_Nivel_Departamento.Text);

            }
        }

        private void TxTBox_Nome_Departamento_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Bnt_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void TxTBox_Nivel_Departamento_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
