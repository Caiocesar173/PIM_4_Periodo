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

namespace PIM_4_PERIODO.View.Tela_Oficina
{
    public partial class CadastrarOficina : Form
    {
        public CadastrarOficina()
        {
            InitializeComponent();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            PIM_4_PERIODO.Dao.Incluir objCadastro = new Dao.Incluir();
            Oficina oficina = new Oficina();
            oficina.Nome = txtNomeOficina.Text;
            oficina.RazaoSocial = txtRazaoSocial.Text;
            oficina.Telefone = Convert.ToInt16(txtTelefone.Text);
            oficina.CNPJ = txtCpnj.Text;
            oficina.Endereço = txtEndereco.Text;
            oficina.ID_Oficina = Convert.ToInt16(txt_IdOficina);
            MessageBox.Show("Oficina cadastrada com sucesso");
            objCadastro.Oficina(oficina);
            
        }
    }
}
