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
    public partial class Tela_Destino : Form
    {
        public Tela_Destino()
        {
           
            InitializeComponent();
        }

        private void Bnt_Salvar_Departamento_Click(object sender, EventArgs e)
        {
            Destino destino = new Destino();
            destino.ID_Motorista = int.Parse(TxTBox_Motorista.Text);
            //falta o ID do veiculo
            destino.Local_Saida = TxTBox_Local_Saida.Text;
            destino.Local_Chegada = TxTBox_Local_Chegada.Text;
            destino.Data_Chegada = Convert.ToDateTime(TxTBox_Data_chegada.Text);
            destino.Data_Saida = Convert.ToDateTime(TxTBox_Data_chegada.Text);

            MessageBox.Show("Destino cadastrado com sucesso");
        }

        private void TxTBox_Motorista_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
