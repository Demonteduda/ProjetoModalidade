
namespace aula13_banco
{
    partial class cadMatricula
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Turma1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCpfAlu = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Turma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turma1});
            this.dataGridView1.Location = new System.Drawing.Point(15, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(265, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Turma1
            // 
            this.Turma1.HeaderText = "Turmas:";
            this.Turma1.Name = "Turma1";
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(415, 263);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(221, 56);
            this.btnMatricular.TabIndex = 1;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(29, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turmas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCpfAlu);
            this.groupBox2.Controls.Add(this.txtTurma);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Turma);
            this.groupBox2.Location = new System.Drawing.Point(371, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 147);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matricular Aluno:";
            // 
            // txtCpfAlu
            // 
            this.txtCpfAlu.Location = new System.Drawing.Point(99, 77);
            this.txtCpfAlu.Name = "txtCpfAlu";
            this.txtCpfAlu.Size = new System.Drawing.Size(198, 20);
            this.txtCpfAlu.TabIndex = 4;
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(99, 40);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(198, 20);
            this.txtTurma.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cpf Aluno:";
            // 
            // Turma
            // 
            this.Turma.AutoSize = true;
            this.Turma.Location = new System.Drawing.Point(28, 43);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(65, 13);
            this.Turma.TabIndex = 0;
            this.Turma.Text = "Modalidade:";
            // 
            // cadMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMatricular);
            this.Name = "cadMatricula";
            this.Text = "cadMatricula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCpfAlu;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turma1;
    }
}