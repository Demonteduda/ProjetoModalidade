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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DAO_Conexao.getConexao("143.106.241.3", "cl202251", "cl202251", "demonte18"))
                Console.WriteLine("Conectado");
            else 
                Console.WriteLine("Erro de conexão");
        }


        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(1);
            form3.MdiParent = this;
            form3.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.VerificaLogin(textBox1.Text, textBox2.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
            if (tipo == 2) {
                MessageBox.Show("Usuário Restrito");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarAlunoToolStripMenuItem.Enabled = false;

            }
        }

        private void atualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(2);
            form3.MdiParent = this;
            form3.Show();
        }

        private void cadastrarModalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMoView formCad = new CadastroMoView();
            formCad.MdiParent = this;
            formCad.Show();
        }

        private void atualizarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 formCad = new Form7 (1);
            formCad.MdiParent = this;
            formCad.Show();
        }

        private void consultarModalideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 formCad = new Form7(2);
            formCad.MdiParent = this;
            formCad.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 formExc = new Form5();
            formExc.MdiParent = this;
            formExc.Show();
        }

        private void cadastrarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadTurma formcadt = new cadTurma();
            formcadt.MdiParent = this;
            formcadt.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarTurma atuTurma1 = new AtualizarTurma();
            atuTurma1.MdiParent = this;
            atuTurma1.Show();
        }

        private void excluirTurmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcluirTurma excluirTurma1 = new ExcluirTurma();
            excluirTurma1.MdiParent = this;
            excluirTurma1.Show();
        }
    }
}
