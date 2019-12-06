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
    public partial class Cadastro_Departamento : Form
    {
        Departamento departamento = new Departamento();
        public Cadastro_Departamento()
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
    }
}
