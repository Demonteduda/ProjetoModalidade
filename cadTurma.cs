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
        public cadTurma()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.consultarTodasModalide();
            while (r.Read())
                dataGridView1.Rows.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cadTurma_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade();
            DAO_Conexao.con.Close();
            mod = new Modalidade(dataGridView1.Text);
            MySqlDataReader re = mod.consultarModalidade();
            while (re.Read())
            {
                txtModalidade.Text= re["idEstudio_Modalidade"].ToString();            
            }

            Turma turmacad = new Turma(txtProfessor.Text, txtDiaDaSemana.Text, mskdtxtHora.Text, int.Parse(txtModalidade.Text) );

          if(turmacad.cadastrarTurma())
            {
                MessageBox.Show("Turma cadastrada com sucesso!");
            }
          else
            {
                MessageBox.Show("Erro no Cadastro!");
            }

        }
    }
}
