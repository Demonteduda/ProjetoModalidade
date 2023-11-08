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
        string nometur;

        public cadMatricula()
        {
            try
            {
                InitializeComponent();
                Turma con_Tur = new Turma();
                MySqlDataReader r = con_Tur.consultarTodasTurmas();
              
                while (r.Read())
                {
                    int a = int.Parse(r["ativa"].ToString());
                    if (a == 0)
                    {
          dataGridView1.Rows.Add(r["NomeTurma"].ToString()) ;
                      
                        //  idTurma = (r["idEstudio_Turma"].ToString());
                        //idMod = (r["idModalidade"].ToString());
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
                    nometur = cellValue.ToString();
                }

            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            Turma t1 = new Turma();
            int idtur = t1.consulIdTurma(nometur);
            Turma t2 = new Turma();
            int idmod = t2.consulIdMod1(nometur);
            Modalidade mol = new Modalidade();
            int qtdmax = mol.consultarQtd(idmod);
            int qtdalu = t1.consulqtd(idtur);

            MessageBox.Show(qtdmax.ToString());
            MessageBox.Show(qtdalu.ToString());
            Aluno al1 = new Aluno();
            Matricula mat = new Matricula(idtur, mktCpf.Text, nometur);

           
            if (qtdalu < qtdmax)
            {
                if (al1.verificaCPF(mktCpf.Text))
                {
                    mat.cadMatricula();
                    MessageBox.Show("Aluno cadastrado na turma!");
                }
                else
                {
                    MessageBox.Show("Erro no cpf.");

                }
            }
            else
            {
                MessageBox.Show("Quantidade máxima de alunos atingida!");
            }

        
         }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
