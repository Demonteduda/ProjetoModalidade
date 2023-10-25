using aula13_banco;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula13_banco
{
    class Turma
    {
        private string nome, professor, dia_semana, hora;
        private int modalidade, qtde_Alunos, id;

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma( string professor, string dia_semana, string hora, int modalidade, string nome)
        {
        
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
            this.Nome = nome;
        }

        public Turma(string dia_semana, int modalidade)
        {
            this.dia_semana = dia_semana;
            this.modalidade = modalidade;
        }

        public Turma(string nome,  string professor, string dia_semana, string hora, int modalidade, int qtde_Alunos)
        {
            this.Nome = nome;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
            this.Qtde_Alunos = qtde_Alunos;

        }
        public Turma()
        {

        }

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
        public int Qtde_Alunos { get => qtde_Alunos; set => qtde_Alunos = value; }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public bool cadastar()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand("insert into Estudio_Turma(idModalidade,professorTurma," +
                    " diaSemanaTurma, horaTurma,alunosmatriculadosTurma, ativa, NomeTurma) values (" + modalidade + ",'" + professor + "','"
                    + dia_semana + "','" + hora + "'," + qtde_Alunos + ", 0, '" +nome+ "')", DAO_Conexao.con);
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

        public MySqlDataReader consultarTurma(int mod1)
        {
            MySqlDataReader consulta = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaBool = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade = " + mod1 + "", DAO_Conexao.con);
                Console.WriteLine("SELECT * FROM Estudio_Turma WHERE idEModalidade = " + mod1 + "");
                consulta = consultaBool.ExecuteReader();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return consulta;

        }


        public bool atualizar(int mod, string profmod, string prof, string diase, string hor)
        {
            bool updated = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("update Estudio_Turma set professorTurma='" + professor + "', diasemanaTurma='" + diase+  "', horaTurma='" + hora + "' where idModalidade=" + mod + " and professorTurma= '"+profmod+"'", DAO_Conexao.con);
                update.ExecuteNonQuery();
                updated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return updated;
        }

        public MySqlDataReader consultarTodasTurmas()
        {
            MySqlDataReader consul = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma", DAO_Conexao.con);
                consul = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
           

            return consul;
        }



        public bool excluir()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Turma set ativa=1 where idModalidade = '" + modalidade + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }
   


        public MySqlDataReader consultarTurmaId(int id)
        {
            MySqlCommand consulta = null;
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade='" + id + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

            finally
            {
                DAO_Conexao.con.Close();

            }
            return resultado;
        }
    }

}
