﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13_banco
{
    class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade;

        public Turma(string professor, string dia_semana, string hora, int modalidade)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
        }

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(string dia_semana, int modalidade)
        {
            this.dia_semana = dia_semana;
            this.modalidade = modalidade;
        }

        public bool cadastrarTurma()
        {

        }

        public bool excluirTurma()
        {

        }

        public MySqlDataReader consultarTurma()
        {

        }

        public MySqlDataReader consultarTurma01()
        {

        }



        public string Professor { get => professor; set => professor = value; }
      
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }

        public string Hora { get => hora; set => hora = value; }  
        public int Modalidade { get => modalidade; set => modalidade = value; }


    }
}