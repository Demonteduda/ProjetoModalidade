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
                MySqlCommand insere = new MySqlCommand("insert into Estudio_modalidade (descricaoModalidade, precoModalidade, qtdAlunos, qtdAulas) values " +
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
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudo_Modalidade" +
                    "WHERE descricaoModaliddae = '" + descricao + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    consul = consulta.ExecuteReader();
                }
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
                Console.WriteLine("Abriu -------------------------");
                MySqlCommand atualizar = new MySqlCommand("Update Estudio_modalidade where descricaoModalidade = "+desc1+" ( " +
                    "precoModalidades, qtdAlunos, qtdAulas) values " +
               "('" + preco1 + "','" + qtd_alunos1 + "','" + qtd_aulas1 + "')");
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
            return atu;


        }

        public MySqlDataReader consultarTodasModalid()
        {
            MySqlDataReader consul = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudo_Modalidade", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    consul = consulta.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consul;
        }
        
        public bool excluirModalidade()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidae set atival = 1 WHERE" +
                    " descricaoModalidade = '"+descricao+"'" , DAO_Conexao.con);
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
