using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula13_banco
{
    class Modalidade
    {
        private string descricao;
        private decimal preco;
        private int qtd_alunos, qtd_aulas;
        private int ati;
        private int codigoID;


        public Modalidade( string descricao, decimal preco, int qtd_alunos, int qtd_aulas )
        {  
            this.descricao = descricao;
            this.preco = preco;
            this.qtd_alunos = qtd_alunos;
            this.qtd_aulas = qtd_aulas;
         
        }

        public Modalidade (string desc)
        {
            this.descricao = desc;
        }

      
        public Modalidade()
        {

         }


        public bool cadastrarModalidade()
        {
            bool cadastrar = false;
            try {
                DAO_Conexao.con.Open();

            Console.WriteLine("insert into Estudio_modalidade( descricaoModalidade,precoModalidade, qtdAlunos, qtdAulas) values " +
               "('" + descricao + "','" + preco + "','" + qtd_alunos + "','" + qtd_aulas + "')");
                MySqlCommand insere = new MySqlCommand("insert into Estudio_modalidade (descricaoModalidade, precoModalidade, qtdAlunos, qtdAulas, ) values " +
               "('" + descricao + "','" + preco + "','" + qtd_alunos + "','" + qtd_aulas + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cadastrar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cadastrar;
        }

        public MySqlDataReader consultarModalidade()
        {
            MySqlDataReader consul = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_modalidade WHERE descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
                Console.WriteLine("SELECT * FROM Estudio_modalidade WHERE descricaoModalidade = '" + descricao + "'");
                consul = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
          
            return consul;
        }
        
           public bool atualizarModalidade( string desc1, decimal preco1, int qtd_alunos1, int qtd_aulas1)
        {
            bool atu = false;

            try
            {      
                DAO_Conexao.con.Open();
                Console.WriteLine("Abriu Atualização-------------------------");

                MySqlCommand atualizar = new MySqlCommand("update Estudio_modalidade set descricaoModalidade='" + descricao + "'," +
                    " precoModalidade=" + preco + ", qtdAlunos=" + qtd_alunos + ", qtdAulas=" + qtd_aulas + ", atival=" + ati + 
                    " where idEstudio_Modalidade=" + codigoID + "", DAO_Conexao.con);
                atualizar.ExecuteNonQuery();
                atu = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            Console.WriteLine("Fechou Atualização -------------------------");
            return atu;


        }

        public MySqlDataReader consultarTodasModalide()
        {
            MySqlDataReader consul = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_modalidade", DAO_Conexao.con);
                consul = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consul;
        }
        
        public bool excluirModalidade(string descri)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_modalidade set atival" +
             "= 1 where descricaoModalidade = '" + descri + "'", DAO_Conexao.con);
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

        

        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Qtd_aulas { get => qtd_aulas; set => qtd_aulas = value; }
        public int Qtd_alunos { get => qtd_alunos; set => qtd_alunos = value; }


    }
}
