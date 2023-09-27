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
                 Modalidade mod = new Modalidade();
            if (opc == 1)
            {

                if (mod.atualizarModalidade ( cmbDesc.Text, decimal.Parse(txtPreco.Text), int.Parse(txtQtdAlunos.Text), int.Parse(txtQtdeAulas.Text)))
                {
                    MessageBox.Show("Atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastar!");
                }
            }
            else
            {

                mod.consultarModalidade();
            }


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
    }
}
