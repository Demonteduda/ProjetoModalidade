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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnConsultarMatricula_Click(object sender, EventArgs e)
        {
            Matricula m1 = new Matricula(cmbTurma.SelectedIndex);
            MySqlDataReader re = m1.consultarMatricula();
            while (re.Read())
            {
                txtQtdAlu.Text= re["alunosmatriculadosTurma"].ToString();
                txtDiaSemana.Text = re["diasemanaTurma"].ToString();
                txtHora.Text = re["horaTurma"].ToString();
            }
        }
    }
}
