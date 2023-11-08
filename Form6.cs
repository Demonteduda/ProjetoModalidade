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
    public partial class ExMatricula : Form
    {
        public ExMatricula()
        {
            InitializeComponent();

            Turma con_Tur = new Turma();
            MySqlDataReader r1 = con_Tur.consultarTodasTurmas();

            while (r1.Read())
            {
                int a = int.Parse(r1["ativa"].ToString());
                if (a == 0)
                {
                    cmbTurma.Items.Add(r1["NomeTurma"].ToString());
                }
            }
        }

        private void ExMatricula_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Matricula mat = new Matricula(mskdCpf.Text);
            Aluno al1 = new Aluno();
            if (al1.verificaCPF(mskdCpf.Text))
            {
                if (mat.excluirMatricula())
                    MessageBox.Show("Matricula excluida com sucesso!!");
                else
                    MessageBox.Show("Matricula não excluida");
            }
            else
            {
                MessageBox.Show("Erro no cpf!");
            }

        }

        private void cmbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
