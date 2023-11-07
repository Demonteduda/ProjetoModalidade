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
        private string cpfalu;
        private string nomeTur;
        private int qtd1;
        private int qtd2;
       
        public Matricula(int idTurma, string cpfalu, string nomeTur)
        {
            IdTurma = idTurma;
            NomeTur = nomeTur;
            Cpfalu = cpfalu;
            
        }

        public Matricula(int idTurma, string cpfalu)
        {
            IdTurma = idTurma;
            Cpfalu = cpfalu;

        }

        public Matricula(string cpfalu, string nomeTur)
        {
            NomeTur = nomeTur;
            Cpfalu = cpfalu;
        }

        public Matricula(string cpfalu)
        {
            Cpfalu = cpfalu;
        }

        public int IdTurma { get => idTurma; set => idTurma = value; }
        public string NomeTur { get => nomeTur; set => nomeTur = value; }
        public string Cpfalu { get => cpfalu; set => cpfalu = value; }
 
        public bool cadMatricula()
        {

            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand("insert into Estudio_Matricula (cpfAlu, idTurma, NomeTurma) values " +
               "('" + Cpfalu + "','" + idTurma + "','" + nomeTur + "',)", DAO_Conexao.con);
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

     

        public bool excluirMatricula()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("delete from Estudio_Matricula" +
           " where cpfAlu = '" + Cpfalu + "'", DAO_Conexao.con);
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


        //   select* from Estudio_Aluno inner join Estudio_Matricula on Estudio_Aluno.CPFAluno = Estudio_Matricula.cpf_Aluno where Estudio_Matricula.id_Turma= '


        public MySqlDataReader consultarMatricula()
        {
            MySqlDataReader consul = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudo_Aluno inner join Estudio_Matricula on Estudo_Aluno.CPFAaluno where Estudio_Matricula.idTurma= '"+idTurma+"'", DAO_Conexao.con);
               
                consul = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consul;
        }

        public MySqlDataReader consultarMatricula1()
        {
            MySqlDataReader consul = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudo_Aluno inner join Estudio_Turma on Estudo_Aluno.CPFAaluno where Estudio_Turma.NomeTurma= '" + idTurma + "'", DAO_Conexao.con);

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
