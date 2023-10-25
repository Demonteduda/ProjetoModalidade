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
    public partial class ExcluirTurma : Form
    {
        public ExcluirTurma()
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
            Turma tur = new Turma();
            MySqlDataReader r1 = tur.consultarTodasTurmas();
            while(r1.Read())
            {
                cmbSemana.Items.Add(r1["diasemanaTurma"].ToString());
                cmbHora.Items.Add(r1["horaTurma"].ToString());
            }
     
            DAO_Conexao.con.Close();

        }

        private void cmbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Turma tur = new Turma(cmbModalidade.SelectedIndex);
            if (tur.excluir())
            {
                MessageBox.Show("excluido com sucesso!");
            }
        }

        private void cmbSemana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

