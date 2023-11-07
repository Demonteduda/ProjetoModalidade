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
                List<int> vetCods = new List<int>();

                while (r.Read())
                {
                    int a = int.Parse(r["ativa"].ToString());
                    if (a == 0)
                    {
                        dataGridView1.Rows.Add(r["NomeTurma"].ToString());
                        vetCods.Add(int.Parse(r["idEstudio_Turma"].ToString()));
                        nometur = (r["NomeTurma"].ToString());
                        idTurma = (r["idEstudio_Turma"].ToString());
                        idMod = (r["idModalidade"].ToString());
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
            int idt = int.Parse(idTurma);

           
                Modalidade mol = new Modalidade();
                   
            int idmoda = int.Parse(idMod);
            int qtdmax = mol.consultarQtd(idmoda);
            Turma tur = new Turma();
            int qtdalu = tur.consulqtd(idt);
                    string cpf2 = mktCpf.ToString();
                    Aluno al1 = new Aluno(textBox1.Text);
                    Matricula mat = new Matricula(idt, textBox1.Text, nometur);
   

            if (qtdalu<qtdmax)
                    {
                        if (al1.verificaCPF())
                        {
                            mat.cadMatricula();
                            Console.WriteLine("Aluno cadastrado na turma!");
                        }
                        else
                        {
                            Console.WriteLine("Erro no cpf.");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantidade máxima de alunos atingida!");
                    }
                
            
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
