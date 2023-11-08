
namespace aula13_banco
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultarMatricula = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtQtdAlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.lblSelecioneTurma = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultarMatricula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiaSemana);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.txtQtdAlu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.cmbTurma);
            this.groupBox1.Controls.Add(this.lblSelecioneTurma);
            this.groupBox1.Location = new System.Drawing.Point(173, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Matriculas";
            // 
            // btnConsultarMatricula
            // 
            this.btnConsultarMatricula.Location = new System.Drawing.Point(121, 250);
            this.btnConsultarMatricula.Name = "btnConsultarMatricula";
            this.btnConsultarMatricula.Size = new System.Drawing.Size(96, 32);
            this.btnConsultarMatricula.TabIndex = 10;
            this.btnConsultarMatricula.Text = "Consultar";
            this.btnConsultarMatricula.UseVisualStyleBackColor = true;
            this.btnConsultarMatricula.Click += new System.EventHandler(this.btnConsultarMatricula_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF dos Alunos:";
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(133, 165);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(100, 20);
            this.txtDiaSemana.TabIndex = 8;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(67, 211);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 7;
            // 
            // txtQtdAlu
            // 
            this.txtQtdAlu.Location = new System.Drawing.Point(163, 114);
            this.txtQtdAlu.Name = "txtQtdAlu";
            this.txtQtdAlu.Size = new System.Drawing.Size(100, 20);
            this.txtQtdAlu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade de Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dia da Semana:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(318, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 225);
            this.listBox1.TabIndex = 2;
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(163, 57);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(121, 21);
            this.cmbTurma.TabIndex = 1;
            this.cmbTurma.SelectedIndexChanged += new System.EventHandler(this.cmbTurma_SelectedIndexChanged);
            // 
            // lblSelecioneTurma
            // 
            this.lblSelecioneTurma.AutoSize = true;
            this.lblSelecioneTurma.Location = new System.Drawing.Point(28, 60);
            this.lblSelecioneTurma.Name = "lblSelecioneTurma";
            this.lblSelecioneTurma.Size = new System.Drawing.Size(110, 13);
            this.lblSelecioneTurma.TabIndex = 0;
            this.lblSelecioneTurma.Text = "Selecione sua Turma:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Label lblSelecioneTurma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtQtdAlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarMatricula;
    }
}