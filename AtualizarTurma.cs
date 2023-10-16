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
        public AtualizarTurma()
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
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DAO_Conexao.con.Close();
            Turma turma1 = new Turma();
            int idmod = int.Parse(cmbModalidade.Text);
            MySqlDataReader re = turma1.consultarTurma(idmod);
            while (re.Read())
            {
                
            }

        }
    }
}
