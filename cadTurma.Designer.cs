
namespace aula13_banco
{
    partial class cadTurma
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
            this.mskdtxtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaDaSemana = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDiaDaSemana = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.txtNomeTur = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeTur);
            this.groupBox1.Controls.Add(this.lblNomeTurma);
            this.groupBox1.Controls.Add(this.mskdtxtHora);
            this.groupBox1.Controls.Add(this.txtDiaDaSemana);
            this.groupBox1.Controls.Add(this.txtProfessor);
            this.groupBox1.Controls.Add(this.txtModalidade);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblDiaDaSemana);
            this.groupBox1.Controls.Add(this.lblProfessor);
            this.groupBox1.Controls.Add(this.lblModalidade);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // mskdtxtHora
            // 
            this.mskdtxtHora.Location = new System.Drawing.Point(132, 206);
            this.mskdtxtHora.Mask = "00:00";
            this.mskdtxtHora.Name = "mskdtxtHora";
            this.mskdtxtHora.Size = new System.Drawing.Size(100, 20);
            this.mskdtxtHora.TabIndex = 8;
            this.mskdtxtHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtDiaDaSemana
            // 
            this.txtDiaDaSemana.Location = new System.Drawing.Point(132, 153);
            this.txtDiaDaSemana.Name = "txtDiaDaSemana";
            this.txtDiaDaSemana.Size = new System.Drawing.Size(307, 20);
            this.txtDiaDaSemana.TabIndex = 7;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(132, 116);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(307, 20);
            this.txtProfessor.TabIndex = 6;
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(132, 80);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(307, 20);
            this.txtModalidade.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(165, 249);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(232, 32);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(93, 206);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora:";
            this.lblHora.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDiaDaSemana
            // 
            this.lblDiaDaSemana.AutoSize = true;
            this.lblDiaDaSemana.Location = new System.Drawing.Point(43, 156);
            this.lblDiaDaSemana.Name = "lblDiaDaSemana";
            this.lblDiaDaSemana.Size = new System.Drawing.Size(83, 13);
            this.lblDiaDaSemana.TabIndex = 2;
            this.lblDiaDaSemana.Text = "Dia da Semana:";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(72, 119);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(54, 13);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "Professor:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(56, 83);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(65, 13);
            this.lblModalidade.TabIndex = 0;
            this.lblModalidade.Text = "Modalidade:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modalidade});
            this.dataGridView1.Location = new System.Drawing.Point(38, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 174);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Modalidade
            // 
            this.Modalidade.HeaderText = "Modalidade";
            this.Modalidade.Name = "Modalidade";
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Location = new System.Drawing.Point(56, 53);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(70, 13);
            this.lblNomeTurma.TabIndex = 9;
            this.lblNomeTurma.Text = "Nome turma: ";
            // 
            // txtNomeTur
            // 
            this.txtNomeTur.Location = new System.Drawing.Point(132, 50);
            this.txtNomeTur.Name = "txtNomeTur";
            this.txtNomeTur.Size = new System.Drawing.Size(307, 20);
            this.txtNomeTur.TabIndex = 10;
            this.txtNomeTur.TextChanged += new System.EventHandler(this.txtNomeTur_TextChanged);
            // 
            // cadTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "cadTurma";
            this.Text = "cadTurma";
            this.Load += new System.EventHandler(this.cadTurma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDiaDaSemana;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDiaDaSemana;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidade;
        internal System.Windows.Forms.MaskedTextBox mskdtxtHora;
        private System.Windows.Forms.TextBox txtNomeTur;
        private System.Windows.Forms.Label lblNomeTurma;
    }
}