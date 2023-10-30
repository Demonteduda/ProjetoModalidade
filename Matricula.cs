using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13_banco
{
    class Matricula
    {

        private int idTurma;//Turma
        private int cpfalu;
        private string nomeTur;
        private int cpf;
        private int qtd1;
        private int qtd2;
       
        public Matricula(int idTurma, int cpfalu, string nomeTur)
        {
            IdTurma = idTurma;
            Cpfalu = cpfalu;
            NomeTur = nomeTur;
            
        }

        public Matricula(int cpfalu)
        {
            Cpfalu = cpfalu;
        }

        public int IdTurma { get => idTurma; set => idTurma = value; }
        public int Cpfalu { get => cpfalu; set => cpfalu = value; }
        public string NomeTur { get => nomeTur; set => nomeTur = value; }


        public bool cadMatricula(int cpfalu, int idTurma, string nomeTur)
        {

            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand("insert into Estudio_Matricula (cpfAlu, idTurma, NomeTurma) values " +
               "('" + cpfalu + "','" + idTurma + "','" + nomeTur + "',)", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            finally
            {
               // DAO_Conexao.con.Close();
            }
            return cad;

        }

   /*     public int consultarIdModalidade()
        {
            MySqlDataReader resul = null;
            int id = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand retorno = new MySqlCommand("SELECT DISTINCT * FROM Estudio_Matricula INNER JOIN Estudio_turma ON " +
                    "Estudio_Turma.idEstudio_Turma = Estudio_Matricula.idEstudioTurma,  ")

            }
        }
   */

        public void verificaAlunos()
        {
            Modalidade md = new Modalidade();
            md.AlunosQuant(qtd2);

            Turma tur1 = new Turma();
            tur1.qtdAlunos(qtd1);

            if (qtd1 > qtd2)
            Console.WriteLine("Quantidade maior de alunos");    
        }

        public bool excluirMatricula()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("delete from Estudio_Matricula" +
           " where cpfAlu = '" + cpfalu + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public MySqlDataReader consultarMatricula()
        {
            MySqlDataReader consul = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_ WHERE NomeTurma = '" + nomeTur + "'", DAO_Conexao.con);
               
                consul = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consul;
        }

    }
}
