﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_4_PERIODO.Model
{
    class Destino
    {
        private DateTime data_chegada;
        private DateTime data_saida;
        private int id_Destino;
        private int id_Veiculo;
        private int id_Motorista;


        public DateTime Data_Chegada { get => data_chegada; set => data_chegada = value; }
        public DateTime Data_Saida { get => data_saida; set => data_saida = value; }
        public int ID_Destino { get => id_Destino; set => id_Destino = value; }
        public int ID_Veiculo { get => id_Veiculo; set => id_Veiculo = value; }
        public int ID_Motorista { get => id_Motorista; set => id_Motorista = value; }

    }
}
