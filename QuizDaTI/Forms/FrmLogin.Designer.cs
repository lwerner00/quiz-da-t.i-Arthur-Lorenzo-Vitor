namespace QuizDaTI.Forms
{
    partial class FrmLogin
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
            txtNick = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label5 = new Label();
            btnEntrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNick
            // 
            txtNick.BackColor = Color.FromArgb(76, 73, 93);
            txtNick.ForeColor = Color.FromArgb(209, 215, 224);
            txtNick.Location = new Point(324, 108);
            txtNick.Name = "txtNick";
            txtNick.PlaceholderText = "wernerzx00";
            txtNick.Size = new Size(234, 31);
            txtNick.TabIndex = 6;
            txtNick.TextChanged += txtNick_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(209, 215, 224);
            label3.Location = new Point(200, 109);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 5;
            label3.Text = "NickName:";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(76, 73, 93);
            txtSenha.ForeColor = Color.FromArgb(209, 215, 224);
            txtSenha.Location = new Point(324, 194);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha123@";
            txtSenha.Size = new Size(234, 31);
            txtSenha.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.FromArgb(209, 215, 224);
            label5.Location = new Point(240, 193);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 9;
            label5.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(128, 43, 177);
            btnEntrar.ForeColor = Color.FromArgb(209, 215, 224);
            btnEntrar.Location = new Point(324, 287);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(147, 121);
            btnEntrar.TabIndex = 12;
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
            label1.Location = new Point(358, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 38);
            label1.TabIndex = 13;
            label1.Text = "Login";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(label5);
            Controls.Add(txtNick);
            Controls.Add(label3);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNick;
        private Label label3;
        private TextBox txtSenha;
        private Label label5;
        private Button btnEntrar;
        private Label label1;
    }
}