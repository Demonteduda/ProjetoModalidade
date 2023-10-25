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
        private int max;
        private int contaAlu;
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
            int cpfAlu = int.Parse(txtCpfAlu.Text);
            Matricula mat1 = new Matricula();


        }
    }
}
