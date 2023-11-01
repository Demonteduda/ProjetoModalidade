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
    public partial class AtualizarTurma : Form
    {
        int opc;
        public AtualizarTurma(int opcao)
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarTodasModalide();
            while (r.Read())
            {
                cmbModalidade.Items.Add(r["idEstudio_Modalidade"].ToString());
            }
            DAO_Conexao.con.Close();

            if (opcao == 1)
            {
                btnAtualizar.Text = "Atualizar";
            }
            else
            {
                btnAtualizar.Text = "Consultar";
            }
            opc = opcao;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (opc == 1)
            {
                Turma tur1 = new Turma();
                int idmod = int.Parse(cmbModalidade.SelectedItem.ToString());
                MessageBox.Show(idmod.ToString());
                tur1.atualizar(idmod, cmbProfessor.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Atualizado com sucesso!");

            }

            else
            {

                Turma turma1 = new Turma();
                MySqlDataReader re = turma1.consultarTurma(int.Parse(cmbModalidade.Text));
                while (re.Read())
                {
                    textBox2.Text = re["diasemanaTurma"].ToString();
                    textBox3.Text = re["horaTurma"].ToString();
                }

                DAO_Conexao.con.Close();
            }

        }

        private void cmbModalidade_SelectedIndexChanged(object sender, EventArgs e)
          
        {
            if (opc == 1)
            {
                Turma turma1 = new Turma();
                MySqlDataReader re = turma1.consultarTurma(int.Parse(cmbModalidade.Text));
                while (re.Read())
                {
                    cmbProfessor.Text = re["professorTurma"].ToString();
                    textBox2.Text = re["diasemanaTurma"].ToString();
                    textBox3.Text = re["horaTurma"].ToString();
                  
                }  

                DAO_Conexao.con.Close();
                
              
            }

           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }

}
    

    

