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
    public partial class Form7 : Form
    {
        int opc;
        public Form7(int opcao)
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            Modalidade cad = new Modalidade();
            MySqlDataReader r = cad.consultarTodasModalide();
            while (r.Read())
            {
                cmbDesc.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();

            if (opcao == 1)
            {
                btnConsAtu.Text = "Atualizar";
            }
            else
            {
                btnConsAtu.Text = "Consultar";
            }
            opc = opcao;
        }

        private void btnConsAtu_Click(object sender, EventArgs e)
        {
            Modalidade mod = null;


            if (opc == 1)
            {
                mod = new Modalidade();
                if (mod.atualizarModalidade(cmbDesc.Text, decimal.Parse(txtPreco.Text), int.Parse(txtQtdAlunos.Text), int.Parse(txtQtdeAulas.Text)))
                {
                    MessageBox.Show("Atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar!");
                }
            }
            else
            {
                DAO_Conexao.con.Close();
                mod = new Modalidade(cmbDesc.Text);
                MySqlDataReader re = mod.consultarModalidade();
                while(re.Read())
                { 
                    txtPreco.Text = re["precoModalidade"].ToString();
                   txtQtdAlunos.Text = re["qtdAlunos"].ToString();
                    txtQtdeAulas.Text = re["qtdAulas"].ToString();
                }
              
            }

            DAO_Conexao.con.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQtdeAulas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtdAlunos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQtdAulas_Click(object sender, EventArgs e)
        {

        }

        private void lbQttdAluno_Click(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
