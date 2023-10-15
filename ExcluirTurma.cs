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
        }

        private void cmbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAO_Conexao.con.Close();
            Modalidade modal = new Modalidade(cmbModalidade.Text);
            MySqlDataReader re = modal.consultarModalidade();
            while (re.Read())
            {
                cmbModalidade.Text = re["idModalidade"].ToString(); 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             Turma tur = new Turma(cmbModalidade.SelectedIndex);
             Console.WriteLine("Entrouu");
             if (tur.excluirTurma(cmbModalidade.SelectedIndex))
             {
                 MessageBox.Show("excluido com sucesso!");
             }
         }*/
    }
}
