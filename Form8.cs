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
    public partial class Form8 : Form
    {
        string cpfAlu;

        public Form8()
        {
            InitializeComponent();

            Turma con_Tur = new Turma();
            MySqlDataReader r = con_Tur.consultarTodasTurmas();
            while (r.Read())
            {
                int a = int.Parse(r["ativa"].ToString());
                if (a == 0)
                {
                    cmbTurma.Items.Add(r["NomeTurma"].ToString());
                }
            }

        }

        private void btnConsultarMatricula_Click(object sender, EventArgs e)
        {
            List<string> vetCpf = new List<string>();
            Matricula m1 = new Matricula();
            MySqlDataReader re = m1.consultarMatricula(cmbTurma.Text);
            while (re.Read())
            {
                txtQtdAlu.Text = re["alunosmatriculadosTurma"].ToString();
                txtDiaSemana.Text = re["diasemanaTurma"].ToString();
                txtHora.Text = re["horaTurma"].ToString();
                vetCpf.Add(re["CPFalu"].ToString());
            }
            DAO_Conexao.con.Close();

            for (int i = 0; i < vetCpf.Count; i++)
            {
                Aluno a1 = new Aluno(vetCpf[i]);
                re = a1.ConsultarNome();
                if (re.Read())
                {
                    listBox1.Items.Add(re["nomeAluno"].ToString());
                }
               
              DAO_Conexao.con.Close();
            }
         

         
         

        

        }

        private void cmbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
