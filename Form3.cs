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
    public partial class Form3 : Form
    {
           int opc;
        
        public Form3(int opcao)
        {
            InitializeComponent();
            if (opcao == 1)
            {
                btnCadastrar.Text = "Cadastrar";
            }
            else
            {
                btnCadastrar.Text = "Atualizar";
            }
            opc = opcao;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
            {
               
            }


        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

                stream.Seek(0, System.IO.SeekOrigin.Begin);
                Byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

            byte[] foto1 = ConverterFotoParaByteArray();

            Aluno aln = new Aluno(txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text, txtCompl.Text, txtCep.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text,foto1);
            txtCPF.Enabled = false;
            if (opc == 1)
            {
                if (aln.cadastrarAluno())
                {
                    MessageBox.Show("Cadastrado com sucesso");

                }
                else
                    MessageBox.Show("Erro de cadastro");

            }
            else

            {
                txtCPF.Enabled = false;
                if (aln.atualizarAluno())
                {
                    MessageBox.Show("Atualizado com sucesso");
                }
            }
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {



            Aluno aluno = new Aluno(txtCPF.Text);

         /*  if (aluno.verificaCPF())
           MessageBox.Show("CPF valido!!");
           else
            MessageBox.Show("CPF inválido");
         */

            if (e.KeyChar == 13)
            { 
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já cadastrado!");
                    
                        
                }
                else
                {
                    txtNome.Focus();
                }
            

                DAO_Conexao.con.Close(); //somente fecha depois de retornar
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir foto";
            dialog.Filter = "JPG(*.jpg)|*.jpg"+"|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar a foto: " + ex.Message);
                }
                dialog.Dispose();
            }
        }
    }
}
