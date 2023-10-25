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

        public Matricula(int idTurma, int cpfalu, string nomeTur)
        {
            IdTurma = idTurma;
            Cpfalu = cpfalu;
            NomeTur = nomeTur;
        }

        public int IdTurma { get => idTurma; set => idTurma = value; }
        public int Cpfalu { get => cpfalu; set => cpfalu = value; }
        public string NomeTur { get => nomeTur; set => nomeTur = value; }


      /*  public bool cadMatricula(int cpfalu, int idTur, string nomeTur)
        {

            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand("insert into Estudio_Matricula ", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;

        }
      */

    }
}
