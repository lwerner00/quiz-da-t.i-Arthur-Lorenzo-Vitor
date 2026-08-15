
namespace QuizDaTI
{
    partial class FrmTelaInicial
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
            label1 = new Label();
            btnLogin = new Button();
            btnCriarConta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(76, 73, 93);
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(209, 215, 224);
            label1.Location = new Point(188, 35);
            label1.Name = "label1";
            label1.Size = new Size(396, 38);
            label1.TabIndex = 0;
            label1.Text = "Seja Bem Vindo ao Quiz da T.I!";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 43, 177);
            btnLogin.ForeColor = Color.FromArgb(209, 215, 224);
            btnLogin.Location = new Point(216, 175);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 121);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Fazer Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCriarConta
            // 
            btnCriarConta.BackColor = Color.FromArgb(128, 43, 177);
            btnCriarConta.ForeColor = Color.FromArgb(209, 215, 224);
            btnCriarConta.Location = new Point(407, 175);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(147, 121);
            btnCriarConta.TabIndex = 2;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCriarConta);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Name = "FrmTelaInicial";
            Text = "Tela Inicial";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Button btnLogin;
        private Button btnCriarConta;
    }
}
