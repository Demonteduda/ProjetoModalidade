﻿
namespace aula13_banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modaliadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarModalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarModalideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTurmaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matricularAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.consultarMatriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.modaliadesToolStripMenuItem,
            this.turmaToolStripMenuItem,
            this.matriculaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.cadastrarLoginToolStripMenuItem,
            this.atualizarDadosToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Login";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // cadastrarLoginToolStripMenuItem
            // 
            this.cadastrarLoginToolStripMenuItem.Name = "cadastrarLoginToolStripMenuItem";
            this.cadastrarLoginToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cadastrarLoginToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarLoginToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLoginToolStripMenuItem_Click);
            // 
            // atualizarDadosToolStripMenuItem
            // 
            this.atualizarDadosToolStripMenuItem.Name = "atualizarDadosToolStripMenuItem";
            this.atualizarDadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.atualizarDadosToolStripMenuItem.Text = "Atualizar dados";
            this.atualizarDadosToolStripMenuItem.Click += new System.EventHandler(this.atualizarDadosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(156, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // modaliadesToolStripMenuItem
            // 
            this.modaliadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarModalidadesToolStripMenuItem,
            this.atualizarModalidadeToolStripMenuItem,
            this.consultarModalideToolStripMenuItem,
            this.excluirModalidadeToolStripMenuItem});
            this.modaliadesToolStripMenuItem.Name = "modaliadesToolStripMenuItem";
            this.modaliadesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.modaliadesToolStripMenuItem.Text = "Modaliade";
            // 
            // cadastrarModalidadesToolStripMenuItem
            // 
            this.cadastrarModalidadesToolStripMenuItem.Name = "cadastrarModalidadesToolStripMenuItem";
            this.cadastrarModalidadesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarModalidadesToolStripMenuItem.Text = "Cadastrar Modalidade";
            this.cadastrarModalidadesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarModalidadesToolStripMenuItem_Click);
            // 
            // atualizarModalidadeToolStripMenuItem
            // 
            this.atualizarModalidadeToolStripMenuItem.Name = "atualizarModalidadeToolStripMenuItem";
            this.atualizarModalidadeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.atualizarModalidadeToolStripMenuItem.Text = "Atualizar Modalidade";
            this.atualizarModalidadeToolStripMenuItem.Click += new System.EventHandler(this.atualizarModalidadeToolStripMenuItem_Click);
            // 
            // consultarModalideToolStripMenuItem
            // 
            this.consultarModalideToolStripMenuItem.Name = "consultarModalideToolStripMenuItem";
            this.consultarModalideToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.consultarModalideToolStripMenuItem.Text = "Consultar Modalide";
            this.consultarModalideToolStripMenuItem.Click += new System.EventHandler(this.consultarModalideToolStripMenuItem_Click);
            // 
            // excluirModalidadeToolStripMenuItem
            // 
            this.excluirModalidadeToolStripMenuItem.Name = "excluirModalidadeToolStripMenuItem";
            this.excluirModalidadeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.excluirModalidadeToolStripMenuItem.Text = "Excluir Modalidade";
            this.excluirModalidadeToolStripMenuItem.Click += new System.EventHandler(this.excluirModalidadeToolStripMenuItem_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTurmaToolStripMenuItem,
            this.excluirTurmaToolStripMenuItem,
            this.excluirTurmaToolStripMenuItem1,
            this.consultarTurmaToolStripMenuItem});
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // cadastrarTurmaToolStripMenuItem
            // 
            this.cadastrarTurmaToolStripMenuItem.Name = "cadastrarTurmaToolStripMenuItem";
            this.cadastrarTurmaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cadastrarTurmaToolStripMenuItem.Text = "Cadastrar Turma";
            this.cadastrarTurmaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTurmaToolStripMenuItem_Click);
            // 
            // excluirTurmaToolStripMenuItem
            // 
            this.excluirTurmaToolStripMenuItem.Name = "excluirTurmaToolStripMenuItem";
            this.excluirTurmaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.excluirTurmaToolStripMenuItem.Text = "Atualizar Turma";
            this.excluirTurmaToolStripMenuItem.Click += new System.EventHandler(this.excluirTurmaToolStripMenuItem_Click);
            // 
            // excluirTurmaToolStripMenuItem1
            // 
            this.excluirTurmaToolStripMenuItem1.Name = "excluirTurmaToolStripMenuItem1";
            this.excluirTurmaToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.excluirTurmaToolStripMenuItem1.Text = "Excluir Turma";
            this.excluirTurmaToolStripMenuItem1.Click += new System.EventHandler(this.excluirTurmaToolStripMenuItem1_Click);
            // 
            // consultarTurmaToolStripMenuItem
            // 
            this.consultarTurmaToolStripMenuItem.Name = "consultarTurmaToolStripMenuItem";
            this.consultarTurmaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consultarTurmaToolStripMenuItem.Text = "Consultar Turma";
            this.consultarTurmaToolStripMenuItem.Click += new System.EventHandler(this.consultarTurmaToolStripMenuItem_Click);
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matricularAlunoToolStripMenuItem,
            this.excluirAlunoToolStripMenuItem,
            this.consultarMatriculasToolStripMenuItem});
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // matricularAlunoToolStripMenuItem
            // 
            this.matricularAlunoToolStripMenuItem.Name = "matricularAlunoToolStripMenuItem";
            this.matricularAlunoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.matricularAlunoToolStripMenuItem.Text = "Matricular Aluno";
            this.matricularAlunoToolStripMenuItem.Click += new System.EventHandler(this.matricularAlunoToolStripMenuItem_Click);
            // 
            // excluirAlunoToolStripMenuItem
            // 
            this.excluirAlunoToolStripMenuItem.Name = "excluirAlunoToolStripMenuItem";
            this.excluirAlunoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.excluirAlunoToolStripMenuItem.Text = "Excluir Aluno";
            this.excluirAlunoToolStripMenuItem.Click += new System.EventHandler(this.excluirAlunoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(188, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validação";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "123";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "duda";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // consultarMatriculasToolStripMenuItem
            // 
            this.consultarMatriculasToolStripMenuItem.Name = "consultarMatriculasToolStripMenuItem";
            this.consultarMatriculasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.consultarMatriculasToolStripMenuItem.Text = "Consultar Matriculas";
            this.consultarMatriculasToolStripMenuItem.Click += new System.EventHandler(this.consultarMatriculasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Estúdio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modaliadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarModalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarModalideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTurmaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matricularAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMatriculasToolStripMenuItem;
    }
}

