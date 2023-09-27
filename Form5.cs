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
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(txtExc.Text);
            if( mod.excluirModalidade())
            {
                Console.WriteLine("excluido com sucesso!");
            }
           
            //boa sorte
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
