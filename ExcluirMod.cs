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
    public partial class ExcluirMod : Form
    {
        public ExcluirMod()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade();
            mod.excluirModalidade(comboBox1.Text);
            //boa sorte

        }
    }
}
