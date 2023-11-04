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
    public partial class ExMatricula : Form
    {
        public ExMatricula()
        {
            InitializeComponent();
        }

        private void ExMatricula_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Matricula mat = new Matricula(txtcpfAluno.Text);

            if (mat.excluirMatricula())
                MessageBox.Show("Matricula excluida com sucesso!!");
            else
                MessageBox.Show("Matricula não excluida");


        }
    }
}
