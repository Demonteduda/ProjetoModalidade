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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarTodasModalide();
            while (r.Read())
            {
                cmb2Desc.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();

        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade();
            if( mod.excluirModalidade(cmb2Desc.Text))
            {
                MessageBox.Show("excluido com sucesso!");
            }
           
            //boa sorte
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
