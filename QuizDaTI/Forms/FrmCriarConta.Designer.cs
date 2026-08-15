namespace QuizDaTI.Forms
{
    partial class FrmCriarConta
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
            label2 = new Label();
            txtNome = new TextBox();
            txtNickName = new TextBox();
            label3 = new Label();
            txtDataDeNascimento = new TextBox();
            label4 = new Label();
            txtSenha = new TextBox();
            label5 = new Label();
            txtConfirmarSenha = new TextBox();
            label6 = new Label();
            btnEntrar = new Button();
            label1 = new Label();
            lblErros = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(209, 215, 224);
            label2.Location = new Point(209, 77);
            label2.Name = "label2";
            label2.Size = new Size(78, 30);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(76, 73, 93);
            txtNome.ForeColor = Color.FromArgb(209, 215, 224);
            txtNome.Location = new Point(293, 80);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Lorenzo Werner";
            txtNome.Size = new Size(234, 31);
            txtNome.TabIndex = 2;
            // 
            // txtNickName
            // 
            txtNickName.BackColor = Color.FromArgb(76, 73, 93);
            txtNickName.ForeColor = Color.FromArgb(209, 215, 224);
            txtNickName.Location = new Point(293, 126);
            txtNickName.Name = "txtNickName";
            txtNickName.PlaceholderText = "wernerzx00";
            txtNickName.Size = new Size(234, 31);
            txtNickName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(209, 215, 224);
            label3.Location = new Point(169, 127);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 3;
            label3.Text = "NickName:";
            // 
            // txtDataDeNascimento
            // 
            txtDataDeNascimento.BackColor = Color.FromArgb(76, 73, 93);
            txtDataDeNascimento.ForeColor = Color.FromArgb(209, 215, 224);
            txtDataDeNascimento.Location = new Point(293, 172);
            txtDataDeNascimento.Name = "txtDataDeNascimento";
            txtDataDeNascimento.PlaceholderText = "DD/MM/AAAA";
            txtDataDeNascimento.Size = new Size(234, 31);
            txtDataDeNascimento.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(209, 215, 224);
            label4.Location = new Point(78, 172);
            label4.Name = "label4";
            label4.Size = new Size(209, 30);
            label4.TabIndex = 5;
            label4.Text = "Data de nascimento:";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(76, 73, 93);
            txtSenha.ForeColor = Color.FromArgb(209, 215, 224);
            txtSenha.Location = new Point(293, 220);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha123@";
            txtSenha.Size = new Size(234, 31);
            txtSenha.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.FromArgb(209, 215, 224);
            label5.Location = new Point(209, 219);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 7;
            label5.Text = "Senha:";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BackColor = Color.FromArgb(76, 73, 93);
            txtConfirmarSenha.ForeColor = Color.FromArgb(209, 215, 224);
            txtConfirmarSenha.Location = new Point(293, 267);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PlaceholderText = "Senha123@";
            txtConfirmarSenha.Size = new Size(234, 31);
            txtConfirmarSenha.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.FromArgb(209, 215, 224);
            label6.Location = new Point(99, 266);
            label6.Name = "label6";
            label6.Size = new Size(187, 30);
            label6.TabIndex = 9;
            label6.Text = "Confirme a senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(128, 43, 177);
            btnEntrar.ForeColor = Color.FromArgb(209, 215, 224);
            btnEntrar.Location = new Point(329, 318);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(147, 121);
            btnEntrar.TabIndex = 11;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(76, 73, 93);
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(209, 215, 224);
            label1.Location = new Point(313, 19);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 0;
            label1.Text = "Crie sua conta";
            label1.Click += label1_Click;
            // 
            // lblErros
            // 
            lblErros.AutoSize = true;
            lblErros.Font = new Font("Segoe UI", 11F);
            lblErros.ForeColor = Color.Red;
            lblErros.Location = new Point(495, 327);
            lblErros.Name = "lblErros";
            lblErros.Size = new Size(0, 30);
            lblErros.TabIndex = 12;
            lblErros.Click += label7_Click;
            // 
            // FrmCriarConta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(832, 460);
            Controls.Add(lblErros);
            Controls.Add(btnEntrar);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(label6);
            Controls.Add(txtSenha);
            Controls.Add(label5);
            Controls.Add(txtDataDeNascimento);
            Controls.Add(label4);
            Controls.Add(txtNickName);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCriarConta";
            Text = "Criar Conta";
            Load += FrmCriarConta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtNome;
        private TextBox txtNickName;
        private Label label3;
        private TextBox txtDataDeNascimento;
        private Label label4;
        private TextBox txtSenha;
        private Label label5;
        private TextBox txtConfirmarSenha;
        private Label label6;
        private Button btnEntrar;
        private Label label1;
        private Label lblErros;
    }
}