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
    public partial class Tela_Cadastro : Form
    {
        public Tela_Cadastro()
        {
            InitializeComponent();

            //Definindo Icones
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

        }
        private void Abastecimento_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento abastecimento = new Abastecimento();
            //this.Hide();
            //TelaAbastecimento abastecimento = new TelaAbastecimento();
            //abastecimento.Show();

           
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO_HOVER;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

        }

        private void Atendimento_Btn_Click(object sender, EventArgs e)
        {
            Model.Atendimento atendimento = new Model.Atendimento();
            //aten
            //this.Hide();
          //tela de atendimento tela atendimento = new TelaAtendimento(abastecimento.valor, abastecimento.litros); 

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO_HOVER;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Combustivel_Btn_Click(object sender, EventArgs e)
        {
            Combustivel combustivel = new Combustivel();
            this.Hide();
            //telaCombustivel combustivel = new telaCombustivel();
            //combustivel.Show();


            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL_HOVER;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Departamento_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO_HOVER;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Destino_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO_HOVER;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Manutenção_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO_HOVER;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Multa_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA_HOVER;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Notificação_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO_HOVER;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Oficina_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();


            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA_HOVER;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Oleo_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO_HOVER;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Posto_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO_HOVER;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Salario_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO_HOVER;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Usuario_Btn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            this.Hide();
         //   CadastroUsuario cadUsuario = new CadastroUsuario();
           // cadUsuario.Show();

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO_HOVER;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Veiculo_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // TelaCadastroVeiculo telaVeiculo = new TelaCadastroVeiculo();
            //telaVeiculo.Show();

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO_HOVER;
        }
    }
}
