using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Tela_Oficina
{
    public partial class Oficina : Form
    {
        Oficina oficina = new Oficina();
        public Oficina()
        {
            InitializeComponent();
        }

        private void Bnt_Cadastrar_Oficina_Click(object sender, EventArgs e)
        {
            if (TxTBox_NomeOficina.Text != "" && TxTBox_RazaoSocial.Text != "" && TxTBox_CNPJ.Text != "" && TxTBox_Endereco.Text != "" && TxTBox_Celular.Text != "" && TxTBox_Telefone.Text != "" && TxTBox_SiteOficina.Text != "") { }
            
            //Oficina.razaosocial = TxTBox_RazaoSocial.Text
            //oficina.nome = TxTBox_NomeOficina.Text 
            // oficina.cnpj = TxTBox_CNPJ.Text
            //oficina.endereco = TxTBox_Endereco.Text
            //oficina.celular = TxTBox_Celular.Text
            //oficina.telefone = xTBox_Telefone.Text  
            //oficina.siteoficina = TxTBox_SiteOficina.Text

        }
        private void Cadastrar_Btn_Click(object sender, EventArgs e) { }
        private void Cancelar_Btn_Click(object sender, EventArgs e) { }
    }
}
