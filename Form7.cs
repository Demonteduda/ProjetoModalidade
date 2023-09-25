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



        }
    }
}
