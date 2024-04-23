namespace Trabalho_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            bt_sairA = new TabPage();
            rbMateria = new RadioButton();
            rbAluno = new RadioButton();
            tb_nascimento = new MaskedTextBox();
            bt_delA = new Button();
            bt_attA = new Button();
            bt_salvarA = new Button();
            tb_matricula = new TextBox();
            tb_nome = new TextBox();
            lb_nascimento = new Label();
            lb_matricula = new Label();
            label5 = new Label();
            lb_nome = new Label();
            tabPage5 = new TabPage();
            bt_deletmat = new Button();
            dGV = new DataGridView();
            btMatricula = new Button();
            btRelatorio = new Button();
            lb_mat = new Label();
            lb_ident = new Label();
            tb_mat = new TextBox();
            tb_ident = new TextBox();
            tabControl1.SuspendLayout();
            bt_sairA.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(bt_sairA);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(995, 560);
            tabControl1.TabIndex = 0;
            // 
            // bt_sairA
            // 
            bt_sairA.Controls.Add(rbMateria);
            bt_sairA.Controls.Add(rbAluno);
            bt_sairA.Controls.Add(tb_nascimento);
            bt_sairA.Controls.Add(bt_delA);
            bt_sairA.Controls.Add(bt_attA);
            bt_sairA.Controls.Add(bt_salvarA);
            bt_sairA.Controls.Add(tb_matricula);
            bt_sairA.Controls.Add(tb_nome);
            bt_sairA.Controls.Add(lb_nascimento);
            bt_sairA.Controls.Add(lb_matricula);
            bt_sairA.Controls.Add(label5);
            bt_sairA.Controls.Add(lb_nome);
            bt_sairA.Location = new Point(4, 29);
            bt_sairA.Name = "bt_sairA";
            bt_sairA.Padding = new Padding(3);
            bt_sairA.Size = new Size(987, 527);
            bt_sairA.TabIndex = 0;
            bt_sairA.Text = "Cadastro";
            bt_sairA.UseVisualStyleBackColor = true;
            // 
            // rbMateria
            // 
            rbMateria.AutoSize = true;
            rbMateria.Location = new Point(634, 91);
            rbMateria.Name = "rbMateria";
            rbMateria.Size = new Size(81, 24);
            rbMateria.TabIndex = 4;
            rbMateria.TabStop = true;
            rbMateria.Text = "Matéria";
            rbMateria.UseVisualStyleBackColor = true;
            rbMateria.CheckedChanged += rbMateria_CheckedChanged;
            // 
            // rbAluno
            // 
            rbAluno.AutoSize = true;
            rbAluno.Location = new Point(355, 91);
            rbAluno.Name = "rbAluno";
            rbAluno.Size = new Size(69, 24);
            rbAluno.TabIndex = 4;
            rbAluno.TabStop = true;
            rbAluno.Text = "Aluno";
            rbAluno.UseVisualStyleBackColor = true;
            rbAluno.CheckedChanged += rbAluno_CheckedChanged;
            // 
            // tb_nascimento
            // 
            tb_nascimento.Location = new Point(318, 268);
            tb_nascimento.Name = "tb_nascimento";
            tb_nascimento.Size = new Size(443, 27);
            tb_nascimento.TabIndex = 3;
            // 
            // bt_delA
            // 
            bt_delA.Location = new Point(615, 426);
            bt_delA.Name = "bt_delA";
            bt_delA.Size = new Size(109, 33);
            bt_delA.TabIndex = 2;
            bt_delA.Text = "Deletar";
            bt_delA.UseVisualStyleBackColor = true;
            bt_delA.Click += bt_delA_Click;
            // 
            // bt_attA
            // 
            bt_attA.Location = new Point(462, 426);
            bt_attA.Name = "bt_attA";
            bt_attA.Size = new Size(109, 33);
            bt_attA.TabIndex = 2;
            bt_attA.Text = "Atualizar";
            bt_attA.UseVisualStyleBackColor = true;
            bt_attA.Click += bt_attA_Click;
            // 
            // bt_salvarA
            // 
            bt_salvarA.Location = new Point(309, 426);
            bt_salvarA.Name = "bt_salvarA";
            bt_salvarA.Size = new Size(109, 33);
            bt_salvarA.TabIndex = 2;
            bt_salvarA.Text = "Salvar";
            bt_salvarA.UseVisualStyleBackColor = true;
            bt_salvarA.Click += bt_salvarA_Click;
            // 
            // tb_matricula
            // 
            tb_matricula.Location = new Point(318, 203);
            tb_matricula.Name = "tb_matricula";
            tb_matricula.Size = new Size(443, 27);
            tb_matricula.TabIndex = 1;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(318, 144);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(443, 27);
            tb_nome.TabIndex = 1;
            // 
            // lb_nascimento
            // 
            lb_nascimento.AutoSize = true;
            lb_nascimento.Location = new Point(141, 275);
            lb_nascimento.Name = "lb_nascimento";
            lb_nascimento.Size = new Size(148, 20);
            lb_nascimento.TabIndex = 0;
            lb_nascimento.Text = "Data de Nascimento:";
            // 
            // lb_matricula
            // 
            lb_matricula.AutoSize = true;
            lb_matricula.Location = new Point(141, 210);
            lb_matricula.Name = "lb_matricula";
            lb_matricula.Size = new Size(116, 20);
            lb_matricula.TabIndex = 0;
            lb_matricula.Text = "N° de Matrícula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 48);
            label5.Name = "label5";
            label5.Size = new Size(230, 20);
            label5.TabIndex = 0;
            label5.Text = "Selecione o que deseja cadastrar:";
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Location = new Point(141, 151);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(118, 20);
            lb_nome.TabIndex = 0;
            lb_nome.Text = "Nome do Aluno:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(bt_deletmat);
            tabPage5.Controls.Add(dGV);
            tabPage5.Controls.Add(btMatricula);
            tabPage5.Controls.Add(btRelatorio);
            tabPage5.Controls.Add(lb_mat);
            tabPage5.Controls.Add(lb_ident);
            tabPage5.Controls.Add(tb_mat);
            tabPage5.Controls.Add(tb_ident);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(987, 527);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Matrícula";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // bt_deletmat
            // 
            bt_deletmat.Location = new Point(279, 188);
            bt_deletmat.Name = "bt_deletmat";
            bt_deletmat.Size = new Size(109, 41);
            bt_deletmat.TabIndex = 11;
            bt_deletmat.Text = "Deletar";
            bt_deletmat.UseVisualStyleBackColor = true;
            bt_deletmat.Click += bt_deletmat_Click;
            // 
            // dGV
            // 
            dGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV.Location = new Point(85, 280);
            dGV.Name = "dGV";
            dGV.RowHeadersWidth = 51;
            dGV.Size = new Size(813, 219);
            dGV.TabIndex = 10;
            // 
            // btMatricula
            // 
            btMatricula.Location = new Point(123, 188);
            btMatricula.Name = "btMatricula";
            btMatricula.Size = new Size(109, 41);
            btMatricula.TabIndex = 9;
            btMatricula.Text = "Matricular";
            btMatricula.UseVisualStyleBackColor = true;
            btMatricula.Click += btMatricula_Click;
            // 
            // btRelatorio
            // 
            btRelatorio.Location = new Point(435, 188);
            btRelatorio.Name = "btRelatorio";
            btRelatorio.Size = new Size(103, 41);
            btRelatorio.TabIndex = 5;
            btRelatorio.Text = "Relatório";
            btRelatorio.UseVisualStyleBackColor = true;
            btRelatorio.Click += button9_Click;
            // 
            // lb_mat
            // 
            lb_mat.AutoSize = true;
            lb_mat.Location = new Point(85, 124);
            lb_mat.Name = "lb_mat";
            lb_mat.Size = new Size(137, 20);
            lb_mat.TabIndex = 1;
            lb_mat.Text = "Código da Matéria:";
            // 
            // lb_ident
            // 
            lb_ident.AutoSize = true;
            lb_ident.Location = new Point(85, 60);
            lb_ident.Name = "lb_ident";
            lb_ident.Size = new Size(116, 20);
            lb_ident.TabIndex = 1;
            lb_ident.Text = "N° de Matrícula:";
            // 
            // tb_mat
            // 
            tb_mat.Location = new Point(240, 115);
            tb_mat.Name = "tb_mat";
            tb_mat.Size = new Size(298, 27);
            tb_mat.TabIndex = 0;
            // 
            // tb_ident
            // 
            tb_ident.Location = new Point(240, 53);
            tb_ident.Name = "tb_ident";
            tb_ident.Size = new Size(298, 27);
            tb_ident.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 561);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Cadastro e Matrícula";
            tabControl1.ResumeLayout(false);
            bt_sairA.ResumeLayout(false);
            bt_sairA.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage bt_sairA;
        private TabPage tabPage5;
        private Button bt_delA;
        private Button bt_attA;
        private Button bt_salvarA;
        private TextBox tb_matricula;
        private TextBox tb_nome;
        private Label lb_nascimento;
        private Label lb_matricula;
        private Label label5;
        private Label lb_nome;
        private Label lb_ident;
        private TextBox tb_ident;
        private Button btRelatorio;
        private Label lb_mat;
        private TextBox tb_mat;
        private Button btMatricula;
        private MaskedTextBox tb_nascimento;
        private RadioButton rbMateria;
        private RadioButton rbAluno;
        private DataGridView dGV;
        private Button bt_deletmat;
    }
}
