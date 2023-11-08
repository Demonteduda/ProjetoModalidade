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

        public Turma(string nome)
        {
            this.nome = nome;
        }

        private int modalidade, qtde_Alunos, id;

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma( string professor, string dia_semana, string hora, int modalidade, string nome, int qtde_Alunos)
        {
        
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
            this.Nome = nome;
            this.Qtde_Alunos = qtde_Alunos;
        }

        public Turma(string dia_semana, int modalidade)
        {
            this.dia_semana = dia_semana;
            this.modalidade = modalidade;
        }

        public Turma(string nome,  string professor, string dia_semana, string hora, int modalidade)
        {
            this.Nome = nome;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
         
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

        public int consulIdTurma(string nomeTur)
        {
           int idturma=0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand buscarid = new MySqlCommand("Select idEstudio_Turma from Estudio_Turma where " +
                    " NomeTurma= '" + nomeTur +"'", DAO_Conexao.con);
                MySqlDataReader r = buscarid.ExecuteReader();
                while (r.Read())
                {
                    idturma = int.Parse((r["idEstudio_Turma"].ToString()));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return idturma;
        }

        public int consulIdMod1(string nomeTur1)
        {
            int idmod = 0;
            try
            {
                DAO_Conexao.con.Close();
                DAO_Conexao.con.Open();
                MySqlCommand buscaridm = new MySqlCommand("Select idModalidade from Estudio_Turma where " +
                    " NomeTurma= '" + nomeTur1 +"'", DAO_Conexao.con);
                MySqlDataReader r1 = buscaridm.ExecuteReader();
                while (r1.Read())
                {
                    idmod = int.Parse((r1["idModalidade"].ToString()));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return idmod;
        }



        public int consulqtd(int idTur)
        {
            int alu = 0;
            try
            {
                DAO_Conexao.con.Close();
                DAO_Conexao.con.Open();
                MySqlCommand buscarqtd = new MySqlCommand("Select alunosmatriculadosTurma from Estudio_Turma where " +
                    "idEstudio_Turma = '"+ idTur+"'", DAO_Conexao.con);
                MySqlDataReader r = buscarqtd.ExecuteReader();
                while(r.Read())
                {
                    alu = int.Parse(r["alunosmatriculadosTurma"].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return alu;
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


        public bool atualizar(int mod, string profmod, string diase, string hor)
        {
            bool updated = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("update Estudio_Turma setdiasemanaTurma='" + diase+  "', horaTurma='" + hora + "' where idModalidade=" + mod + " and professorTurma= '"+profmod+"'", DAO_Conexao.con);
                update.ExecuteNonQuery();
                updated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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

        public MySqlDataReader consultarTodasTurmas1(int id)
        {

            MySqlDataReader consul = null;
            try
            {
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma where idEstudio_Turma= '"+id+"'", DAO_Conexao.con);
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
