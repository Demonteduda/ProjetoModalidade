
namespace aula13_banco
{
    partial class Form7
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lbQttdAluno = new System.Windows.Forms.Label();
            this.lblQtdAulas = new System.Windows.Forms.Label();
            this.btnConsAtu = new System.Windows.Forms.Button();
            this.cmbDesc = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmbDesc);
            this.groupBox1.Controls.Add(this.btnConsAtu);
            this.groupBox1.Controls.Add(this.lblQtdAulas);
            this.groupBox1.Controls.Add(this.lbQttdAluno);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Location = new System.Drawing.Point(108, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidades";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(39, 66);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Descrição:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(39, 115);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // lbQttdAluno
            // 
            this.lbQttdAluno.AutoSize = true;
            this.lbQttdAluno.Location = new System.Drawing.Point(39, 166);
            this.lbQttdAluno.Name = "lbQttdAluno";
            this.lbQttdAluno.Size = new System.Drawing.Size(83, 13);
            this.lbQttdAluno.TabIndex = 2;
            this.lbQttdAluno.Text = "qtde. de alunos:";
            // 
            // lblQtdAulas
            // 
            this.lblQtdAulas.AutoSize = true;
            this.lblQtdAulas.Location = new System.Drawing.Point(39, 216);
            this.lblQtdAulas.Name = "lblQtdAulas";
            this.lblQtdAulas.Size = new System.Drawing.Size(73, 13);
            this.lblQtdAulas.TabIndex = 3;
            this.lblQtdAulas.Text = "Qtd. de aulas:";
            // 
            // btnConsAtu
            // 
            this.btnConsAtu.Location = new System.Drawing.Point(143, 257);
            this.btnConsAtu.Name = "btnConsAtu";
            this.btnConsAtu.Size = new System.Drawing.Size(266, 42);
            this.btnConsAtu.TabIndex = 4;
            this.btnConsAtu.Text = "Consultar";
            this.btnConsAtu.UseVisualStyleBackColor = true;
            this.btnConsAtu.Click += new System.EventHandler(this.btnConsAtu_Click);
            // 
            // cmbDesc
            // 
            this.cmbDesc.FormattingEnabled = true;
            this.cmbDesc.Location = new System.Drawing.Point(129, 63);
            this.cmbDesc.Name = "cmbDesc";
            this.cmbDesc.Size = new System.Drawing.Size(301, 21);
            this.cmbDesc.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbDesc;
        private System.Windows.Forms.Button btnConsAtu;
        private System.Windows.Forms.Label lblQtdAulas;
        private System.Windows.Forms.Label lbQttdAluno;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDesc;
    }
}