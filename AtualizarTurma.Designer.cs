
namespace aula13_banco
{
    partial class AtualizarTurma
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
            this.lblProfcombo = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblModali = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.cmbModalidade = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProfcombo);
            this.groupBox1.Controls.Add(this.cmbProfessor);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblModali);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblDiaSemana);
            this.groupBox1.Controls.Add(this.cmbModalidade);
            this.groupBox1.Location = new System.Drawing.Point(111, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atualizar";
            // 
            // lblProfcombo
            // 
            this.lblProfcombo.AutoSize = true;
            this.lblProfcombo.Location = new System.Drawing.Point(22, 75);
            this.lblProfcombo.Name = "lblProfcombo";
            this.lblProfcombo.Size = new System.Drawing.Size(127, 13);
            this.lblProfcombo.TabIndex = 10;
            this.lblProfcombo.Text = "Professor da Modalidade:";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(155, 72);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(277, 21);
            this.cmbProfessor.TabIndex = 9;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(197, 221);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(168, 34);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblModali
            // 
            this.lblModali.AutoSize = true;
            this.lblModali.Location = new System.Drawing.Point(84, 35);
            this.lblModali.Name = "lblModali";
            this.lblModali.Size = new System.Drawing.Size(65, 13);
            this.lblModali.TabIndex = 4;
            this.lblModali.Text = "Modalidade:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(116, 175);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(68, 126);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(81, 13);
            this.lblDiaSemana.TabIndex = 2;
            this.lblDiaSemana.Text = "Dia da semana:";
            // 
            // cmbModalidade
            // 
            this.cmbModalidade.FormattingEnabled = true;
            this.cmbModalidade.Location = new System.Drawing.Point(155, 32);
            this.cmbModalidade.Name = "cmbModalidade";
            this.cmbModalidade.Size = new System.Drawing.Size(277, 21);
            this.cmbModalidade.TabIndex = 0;
            this.cmbModalidade.SelectedIndexChanged += new System.EventHandler(this.cmbModalidade_SelectedIndexChanged);
            // 
            // AtualizarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AtualizarTurma";
            this.Text = "AtualizarTurma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.ComboBox cmbModalidade;
        private System.Windows.Forms.Label lblModali;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblProfcombo;
        private System.Windows.Forms.ComboBox cmbProfessor;
    }
}