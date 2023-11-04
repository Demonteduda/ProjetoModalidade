using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula13_banco
{
    public partial class cadMatricula : Form
    {

        private string nometur;
        private string idTurma;
        private string idMod;
        private string idalu;

        public cadMatricula()
        {
            try
            {
                InitializeComponent();
                WindowState = FormWindowState.Maximized;
                Turma con_Tur = new Turma();
                MySqlDataReader r = con_Tur.consultarTodasTurmas();

                while (r.Read())
                {
                    int a = int.Parse(r["ativa"].ToString());
                    if (a == 0)
                    {
                        dataGridView1.Rows.Add(r["NomeTurma"].ToString());
                        nometur = (r["NomeTurma"].ToString());
                    }
                }
                txtTurma.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro no preencher");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Acesse o valor da célula selecionada no DataGrid
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Verifique se o valor não é nulo
                if (cellValue != null)
                {

                    // Atribua o valor da célula ao TextBox
                    txtTurma.Text = cellValue.ToString();
                }

            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {

            try
            {

                Modalidade mol = new Modalidade();
                MySqlDataReader r = mol.consultarTodasModalide();
                Console.WriteLine("entrouuuuuuuuuuuuuuuuuu");
                while (r.Read())
                { 
                    int a = int.Parse(r["atival"].ToString());
                    if (a == 0)
                    {Console.WriteLine("passouuuuuuuuuuuuuuu");

                        idTurma = (r["idEstudio_Turma"].ToString());
                        idMod = (r["idModalidade"].ToString());
                    }
                   
                    int idmoda = int.Parse(idMod);
                    int id = int.Parse(idTurma);

                    Aluno al = new Aluno();
                    MySqlDataReader alu = al.consultarAluno1();
                    Matricula mat = new Matricula(id, mktCpf.Text, nometur);

                    if (mat.verificaAlunos(idmoda, id) == 1)
                    {
                        if (al.verificaCPF())
                        {
                            mat.cadMatricula();
                            Console.WriteLine("Aluno cadastrado na turma!");
                        }
                        else
                        {
                            Console.WriteLine("Aluno não cadastrado!");

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro no preencher");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            // Aluno al = new Aluno(mktCpf.Text);    
        

         }
            



          /*  try
            {
                Turma turm = new Turma();
                MySqlDataReader rt = turm.consultarTodasTurmas();
                Aluno alun = new Aluno();
                MySqlDataReader ra = alun.consultarAluno1();
                Matricula mat = new Matricula(mktCpf.Text, nometur);

                while (ra.Read() && rt.Read())
                {
                    nometur = (rt["NomeTurma"].ToString());
                    idalu = (ra["CPFAluno"].ToString());
                }

                mat.cadMatricula();
                Console.WriteLine("Aluno cadastrado em turma");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no preencher");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

*/           






        
    }
}
