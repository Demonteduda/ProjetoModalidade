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
    public partial class CadastroMoView : Form
    {
        int opc;
        public CadastroMoView()
        {
           
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Modalidade moda = new Modalidade(txtDesc.Text, txtPreco.Text, txtQtdAluno.Text, txtQtdeAulas.Text);

            if(opc==1)
            {
                if (moda.cadastrarModalidade)
                {

                }
                else
                {

                }
            }
            else
            {

            }
        }
    }
}
