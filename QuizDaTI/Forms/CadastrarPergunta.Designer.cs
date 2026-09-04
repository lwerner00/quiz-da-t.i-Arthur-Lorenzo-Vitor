
namespace QuizDaTI.Forms
{
    partial class CadastrarPergunta
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
            lblResultado = new Label();
            txtAlternativaIncorreta1 = new TextBox();
            label5 = new Label();
            txtAlternativaCorreta = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtEnunciado = new TextBox();
            label2 = new Label();
            cbTipo = new ComboBox();
            txtAlternativaIncorreta2 = new TextBox();
            label1 = new Label();
            txtAlternativaIncorreta3 = new TextBox();
            label6 = new Label();
            cbNivel = new ComboBox();
            label7 = new Label();
            cbTema = new ComboBox();
            label8 = new Label();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.FromArgb(45, 40, 62);
            lblResultado.Font = new Font("Segoe UI", 13F);
            lblResultado.ForeColor = Color.FromArgb(209, 215, 224);
            lblResultado.Location = new Point(268, 18);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(234, 36);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Cadastrar Pergunta";
            // 
            // txtAlternativaIncorreta1
            // 
            txtAlternativaIncorreta1.BackColor = Color.FromArgb(76, 73, 93);
            txtAlternativaIncorreta1.ForeColor = Color.FromArgb(209, 215, 224);
            txtAlternativaIncorreta1.Location = new Point(331, 218);
            txtAlternativaIncorreta1.Name = "txtAlternativaIncorreta1";
            txtAlternativaIncorreta1.Size = new Size(234, 31);
            txtAlternativaIncorreta1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.FromArgb(209, 215, 224);
            label5.Location = new Point(92, 219);
            label5.Name = "label5";
            label5.Size = new Size(232, 30);
            label5.TabIndex = 17;
            label5.Text = "Alternativa Incorreta 1:";
            // 
            // txtAlternativaCorreta
            // 
            txtAlternativaCorreta.BackColor = Color.FromArgb(76, 73, 93);
            txtAlternativaCorreta.ForeColor = Color.FromArgb(209, 215, 224);
            txtAlternativaCorreta.Location = new Point(331, 172);
            txtAlternativaCorreta.Name = "txtAlternativaCorreta";
            txtAlternativaCorreta.Size = new Size(234, 31);
            txtAlternativaCorreta.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(209, 215, 224);
            label4.Location = new Point(124, 172);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 15;
            label4.Text = "Alternativa Correta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(209, 215, 224);
            label3.Location = new Point(264, 124);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 13;
            label3.Text = "Tipo:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.BackColor = Color.FromArgb(76, 73, 93);
            txtEnunciado.ForeColor = Color.FromArgb(209, 215, 224);
            txtEnunciado.Location = new Point(331, 77);
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(234, 31);
            txtEnunciado.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(209, 215, 224);
            label2.Location = new Point(208, 76);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 11;
            label2.Text = "Enunciado:";
            // 
            // cbTipo
            // 
            cbTipo.BackColor = Color.FromArgb(76, 73, 93);
            cbTipo.ForeColor = Color.FromArgb(209, 215, 224);
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "MultiplaEscolha", "VerdadeiroOuFalso" });
            cbTipo.Location = new Point(331, 124);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(182, 33);
            cbTipo.TabIndex = 21;
            cbTipo.Tag = "";
            // 
            // txtAlternativaIncorreta2
            // 
            txtAlternativaIncorreta2.BackColor = Color.FromArgb(76, 73, 93);
            txtAlternativaIncorreta2.ForeColor = Color.FromArgb(209, 215, 224);
            txtAlternativaIncorreta2.Location = new Point(331, 265);
            txtAlternativaIncorreta2.Name = "txtAlternativaIncorreta2";
            txtAlternativaIncorreta2.Size = new Size(234, 31);
            txtAlternativaIncorreta2.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.FromArgb(209, 215, 224);
            label1.Location = new Point(92, 266);
            label1.Name = "label1";
            label1.Size = new Size(232, 30);
            label1.TabIndex = 22;
            label1.Text = "Alternativa Incorreta 2:";
            label1.Click += label1_Click;
            // 
            // txtAlternativaIncorreta3
            // 
            txtAlternativaIncorreta3.BackColor = Color.FromArgb(76, 73, 93);
            txtAlternativaIncorreta3.ForeColor = Color.FromArgb(209, 215, 224);
            txtAlternativaIncorreta3.Location = new Point(331, 312);
            txtAlternativaIncorreta3.Name = "txtAlternativaIncorreta3";
            txtAlternativaIncorreta3.Size = new Size(234, 31);
            txtAlternativaIncorreta3.TabIndex = 25;
            txtAlternativaIncorreta3.TextChanged += txtAlternativaIncorreta3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.FromArgb(209, 215, 224);
            label6.Location = new Point(92, 313);
            label6.Name = "label6";
            label6.Size = new Size(232, 30);
            label6.TabIndex = 24;
            label6.Text = "Alternativa Incorreta 3:";
            // 
            // cbNivel
            // 
            cbNivel.BackColor = Color.FromArgb(76, 73, 93);
            cbNivel.ForeColor = Color.FromArgb(209, 215, 224);
            cbNivel.FormattingEnabled = true;
            cbNivel.Items.AddRange(new object[] { "Iniciante", "Fácil", "Intermediário", "Avançado" });
            cbNivel.Location = new Point(331, 358);
            cbNivel.Name = "cbNivel";
            cbNivel.Size = new Size(182, 33);
            cbNivel.TabIndex = 27;
            cbNivel.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.FromArgb(209, 215, 224);
            label7.Location = new Point(257, 361);
            label7.Name = "label7";
            label7.Size = new Size(67, 30);
            label7.TabIndex = 26;
            label7.Text = "Nível:";
            // 
            // cbTema
            // 
            cbTema.BackColor = Color.FromArgb(76, 73, 93);
            cbTema.ForeColor = Color.FromArgb(209, 215, 224);
            cbTema.FormattingEnabled = true;
            cbTema.Items.AddRange(new object[] { "Hardware", "Programação", "Redes", "Segurança Digital", "Sistemas Operacionais", "Ferramentas de produtividade" });
            cbTema.Location = new Point(331, 405);
            cbTema.Name = "cbTema";
            cbTema.Size = new Size(182, 33);
            cbTema.TabIndex = 29;
            cbTema.Tag = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.FromArgb(209, 215, 224);
            label8.Location = new Point(257, 408);
            label8.Name = "label8";
            label8.Size = new Size(70, 30);
            label8.TabIndex = 28;
            label8.Text = "Tema:";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(128, 43, 177);
            btnEntrar.ForeColor = Color.FromArgb(209, 215, 224);
            btnEntrar.Location = new Point(666, 361);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(113, 77);
            btnEntrar.TabIndex = 30;
            btnEntrar.Text = "Salvar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // CadastrarPergunta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(cbTema);
            Controls.Add(label8);
            Controls.Add(cbNivel);
            Controls.Add(label7);
            Controls.Add(txtAlternativaIncorreta3);
            Controls.Add(label6);
            Controls.Add(txtAlternativaIncorreta2);
            Controls.Add(label1);
            Controls.Add(cbTipo);
            Controls.Add(txtAlternativaIncorreta1);
            Controls.Add(label5);
            Controls.Add(txtAlternativaCorreta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEnunciado);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Name = "CadastrarPergunta";
            Text = "Cadastrar Pergunta";
            Load += CadastrarPergunta_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblResultado;
        private TextBox txtAlternativaIncorreta1;
        private Label label5;
        private TextBox txtAlternativaCorreta;
        private Label label4;
        private Label label3;
        private TextBox txtEnunciado;
        private Label label2;
        private ComboBox cbTipo;
        private TextBox txtAlternativaIncorreta2;
        private Label label1;
        private TextBox txtAlternativaIncorreta3;
        private Label label6;
        private ComboBox cbNivel;
        private Label label7;
        private ComboBox cbTema;
        private Label label8;
        private Button btnEntrar;
    }
}