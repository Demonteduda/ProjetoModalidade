
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdeAulas = new System.Windows.Forms.TextBox();
            this.txtQtdAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cmbDesc = new System.Windows.Forms.ComboBox();
            this.btnConsAtu = new System.Windows.Forms.Button();
            this.lblQtdAulas = new System.Windows.Forms.Label();
            this.lbQttdAluno = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtQtdeAulas);
            this.groupBox1.Controls.Add(this.txtQtdAlunos);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.cmbDesc);
            this.groupBox1.Controls.Add(this.btnConsAtu);
            this.groupBox1.Controls.Add(this.lblQtdAulas);
            this.groupBox1.Controls.Add(this.lbQttdAluno);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidades";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 230);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(260, 20);
            this.txtId.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição para Atualizar:";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // txtQtdeAulas
            // 
            this.txtQtdeAulas.Location = new System.Drawing.Point(131, 189);
            this.txtQtdeAulas.Name = "txtQtdeAulas";
            this.txtQtdeAulas.Size = new System.Drawing.Size(301, 20);
            this.txtQtdeAulas.TabIndex = 8;
            this.txtQtdeAulas.TextChanged += new System.EventHandler(this.txtQtdeAulas_TextChanged);
            // 
            // txtQtdAlunos
            // 
            this.txtQtdAlunos.Location = new System.Drawing.Point(131, 132);
            this.txtQtdAlunos.Name = "txtQtdAlunos";
            this.txtQtdAlunos.Size = new System.Drawing.Size(301, 20);
            this.txtQtdAlunos.TabIndex = 7;
            this.txtQtdAlunos.TextChanged += new System.EventHandler(this.txtQtdAlunos_TextChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(131, 81);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(301, 20);
            this.txtPreco.TabIndex = 6;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // cmbDesc
            // 
            this.cmbDesc.FormattingEnabled = true;
            this.cmbDesc.Location = new System.Drawing.Point(131, 36);
            this.cmbDesc.Name = "cmbDesc";
            this.cmbDesc.Size = new System.Drawing.Size(301, 21);
            this.cmbDesc.TabIndex = 5;
            this.cmbDesc.SelectedIndexChanged += new System.EventHandler(this.cmbDesc_SelectedIndexChanged);
            // 
            // btnConsAtu
            // 
            this.btnConsAtu.Location = new System.Drawing.Point(140, 269);
            this.btnConsAtu.Name = "btnConsAtu";
            this.btnConsAtu.Size = new System.Drawing.Size(266, 42);
            this.btnConsAtu.TabIndex = 4;
            this.btnConsAtu.Text = "Consultar";
            this.btnConsAtu.UseVisualStyleBackColor = true;
            this.btnConsAtu.Click += new System.EventHandler(this.btnConsAtu_Click);
            // 
            // lblQtdAulas
            // 
            this.lblQtdAulas.AutoSize = true;
            this.lblQtdAulas.Location = new System.Drawing.Point(41, 189);
            this.lblQtdAulas.Name = "lblQtdAulas";
            this.lblQtdAulas.Size = new System.Drawing.Size(73, 13);
            this.lblQtdAulas.TabIndex = 3;
            this.lblQtdAulas.Text = "Qtd. de aulas:";
            this.lblQtdAulas.Click += new System.EventHandler(this.lblQtdAulas_Click);
            // 
            // lbQttdAluno
            // 
            this.lbQttdAluno.AutoSize = true;
            this.lbQttdAluno.Location = new System.Drawing.Point(41, 139);
            this.lbQttdAluno.Name = "lbQttdAluno";
            this.lbQttdAluno.Size = new System.Drawing.Size(83, 13);
            this.lbQttdAluno.TabIndex = 2;
            this.lbQttdAluno.Text = "qtde. de alunos:";
            this.lbQttdAluno.Click += new System.EventHandler(this.lbQttdAluno_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(41, 88);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            this.lblPreco.Click += new System.EventHandler(this.lblPreco_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(41, 39);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Descrição:";
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQtdeAulas;
        private System.Windows.Forms.TextBox txtQtdAlunos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ComboBox cmbDesc;
        private System.Windows.Forms.Button btnConsAtu;
        private System.Windows.Forms.Label lblQtdAulas;
        private System.Windows.Forms.Label lbQttdAluno;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}