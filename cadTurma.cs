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
    public partial class cadTurma : Form
    {
       
            bool att;
            public cadTurma()
            {
                try
                {
                    InitializeComponent();
                    WindowState = FormWindowState.Maximized;
                    Modalidade con_Mod = new Modalidade();
                    MySqlDataReader r = con_Mod.consultarTodasModalide();

                    while (r.Read())
                    {
                        int a = int.Parse(r["atival"].ToString());
                        if (a == 0)
                        {
                            dataGridView1.Rows.Add(r["descricaoModalidade"].ToString());
                        }
                    }
                    txtModalidade.Enabled = false;
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
            private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cadTurma_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string dia_semana = txtDiaDaSemana.Text;
            string hora = mskdtxtHora.Text;
            string prof = txtProfessor.Text;
            string mod = txtModalidade.Text;
            int modalidade = -1;
            //int qtde = int.Parse(txtQtdeAluno.Text);
            try
            {

                Modalidade m = new Modalidade();
                MySqlDataReader r = m.consultarModalidade();
                while (r.Read())
                {
                    modalidade = int.Parse(r["idEstudio_Modalidade"].ToString());
                }
                MessageBox.Show(modalidade.ToString());

                DAO_Conexao.con.Close();
                MessageBox.Show(modalidade.ToString());
                Turma t = new Turma(prof, dia_semana, hora, modalidade);

                if (t.cadastar())
                {
                    MessageBox.Show("Turma cadastrada");
                }
                else
                {
                    MessageBox.Show("Erro ao cadatrar turma");
                }
                txtDiaDaSemana.Text = "";
                mskdtxtHora.Text = "";
                txtProfessor.Text = "";
                txtModalidade.Text = "";
                //txtQtdeAluno.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Acesse o valor da célula selecionada no DataGrid
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Verifique se o valor não é nulo
                if (cellValue != null)
                {
                   
                // Atribua o valor da célula ao TextBox
                 txtModalidade.Text = cellValue.ToString();
                }

            }
        }


    }
}
        