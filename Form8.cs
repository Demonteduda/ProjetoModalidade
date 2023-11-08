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
        string nomeAlu;
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
            Matricula m1 = new Matricula();
            MySqlDataReader re = m1.consultarMatricula(cmbTurma.Text);
            while (re.Read())
            {
                txtQtdAlu.Text= re["alunosmatriculadosTurma"].ToString();
                txtDiaSemana.Text = re["diasemanaTurma"].ToString();
                txtHora.Text = re["horaTurma"].ToString();
                cpfAlu = re["CPFalu"].ToString();
            }
            DAO_Conexao.con.Close();
            DAO_Conexao.con.Open();
            MessageBox.Show(cpfAlu);
            Aluno a1 = new Aluno();
            MySqlDataReader r2 = a1.consultarNome(nomeAlu);
            while(r2.Read())
            {
                listBox1.Items.Add(r2["nomeAluno"].ToString());
            }


        }
    }
}
