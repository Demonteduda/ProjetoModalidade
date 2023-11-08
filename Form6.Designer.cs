
namespace aula13_banco
{
    partial class ExMatricula
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
            this.Excluir = new System.Windows.Forms.GroupBox();
            this.mskdCpf = new System.Windows.Forms.MaskedTextBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.lblturma = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblcpfAluno = new System.Windows.Forms.Label();
            this.Excluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // Excluir
            // 
            this.Excluir.Controls.Add(this.mskdCpf);
            this.Excluir.Controls.Add(this.cmbTurma);
            this.Excluir.Controls.Add(this.lblturma);
            this.Excluir.Controls.Add(this.btnExcluir);
            this.Excluir.Controls.Add(this.lblcpfAluno);
            this.Excluir.Location = new System.Drawing.Point(194, 71);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(268, 164);
            this.Excluir.TabIndex = 0;
            this.Excluir.TabStop = false;
            this.Excluir.Text = "Excluir Aluno da Turma";
            // 
            // mskdCpf
            // 
            this.mskdCpf.Location = new System.Drawing.Point(75, 82);
            this.mskdCpf.Mask = "000-000-000-00";
            this.mskdCpf.Name = "mskdCpf";
            this.mskdCpf.Size = new System.Drawing.Size(129, 20);
            this.mskdCpf.TabIndex = 5;
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(75, 43);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(129, 21);
            this.cmbTurma.TabIndex = 4;
            this.cmbTurma.SelectedIndexChanged += new System.EventHandler(this.cmbTurma_SelectedIndexChanged);
            // 
            // lblturma
            // 
            this.lblturma.AutoSize = true;
            this.lblturma.Location = new System.Drawing.Point(9, 43);
            this.lblturma.Name = "lblturma";
            this.lblturma.Size = new System.Drawing.Size(40, 13);
            this.lblturma.TabIndex = 3;
            this.lblturma.Text = "Turma:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(88, 123);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 24);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblcpfAluno
            // 
            this.lblcpfAluno.AutoSize = true;
            this.lblcpfAluno.Location = new System.Drawing.Point(9, 85);
            this.lblcpfAluno.Name = "lblcpfAluno";
            this.lblcpfAluno.Size = new System.Drawing.Size(60, 13);
            this.lblcpfAluno.TabIndex = 0;
            this.lblcpfAluno.Text = "CPF Aluno:";
            // 
            // ExMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excluir);
            this.Name = "ExMatricula";
            this.Text = "Excluir Aluno";
            this.Load += new System.EventHandler(this.ExMatricula_Load);
            this.Excluir.ResumeLayout(false);
            this.Excluir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Excluir;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Label lblturma;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblcpfAluno;
        private System.Windows.Forms.MaskedTextBox mskdCpf;
    }
}