namespace QuizDaTI.Forms
{
    partial class FrmMenuPrincipal
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
            btnVerHistorico = new Button();
            btnIniciarQuiz = new Button();
            btnVerRanking = new Button();
            BtnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(209, 215, 224);
            label1.Location = new Point(263, 26);
            label1.Name = "label1";
            label1.Size = new Size(288, 54);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            label1.Click += label1_Click;
            // 
            // btnVerHistorico
            // 
            btnVerHistorico.BackColor = Color.FromArgb(128, 43, 177);
            btnVerHistorico.Font = new Font("Segoe UI", 15F);
            btnVerHistorico.ForeColor = Color.FromArgb(209, 215, 224);
            btnVerHistorico.Location = new Point(297, 259);
            btnVerHistorico.Name = "btnVerHistorico";
            btnVerHistorico.Size = new Size(210, 44);
            btnVerHistorico.TabIndex = 1;
            btnVerHistorico.Text = "Ver histórico";
            btnVerHistorico.UseVisualStyleBackColor = false;
            btnVerHistorico.Click += btnVerHistorico_Click;
            // 
            // btnIniciarQuiz
            // 
            btnIniciarQuiz.BackColor = Color.FromArgb(128, 43, 177);
            btnIniciarQuiz.Font = new Font("Segoe UI", 15F);
            btnIniciarQuiz.ForeColor = Color.FromArgb(209, 215, 224);
            btnIniciarQuiz.Location = new Point(297, 118);
            btnIniciarQuiz.Name = "btnIniciarQuiz";
            btnIniciarQuiz.Size = new Size(210, 45);
            btnIniciarQuiz.TabIndex = 2;
            btnIniciarQuiz.Text = "Iniciar o Quiz";
            btnIniciarQuiz.UseVisualStyleBackColor = false;
            btnIniciarQuiz.Click += btnIniciarQuiz_Click;
            // 
            // btnVerRanking
            // 
            btnVerRanking.BackColor = Color.FromArgb(128, 43, 177);
            btnVerRanking.Font = new Font("Segoe UI", 15F);
            btnVerRanking.ForeColor = Color.FromArgb(209, 215, 224);
            btnVerRanking.Location = new Point(297, 191);
            btnVerRanking.Name = "btnVerRanking";
            btnVerRanking.Size = new Size(210, 42);
            btnVerRanking.TabIndex = 3;
            btnVerRanking.Text = "Ver Ranking";
            btnVerRanking.UseVisualStyleBackColor = false;
            btnVerRanking.Click += btnVerRanking_Click;
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.FromArgb(128, 43, 177);
            BtnSair.Font = new Font("Segoe UI", 15F);
            BtnSair.ForeColor = Color.FromArgb(209, 215, 224);
            BtnSair.Location = new Point(297, 324);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(210, 44);
            BtnSair.TabIndex = 4;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSair);
            Controls.Add(btnVerRanking);
            Controls.Add(btnIniciarQuiz);
            Controls.Add(btnVerHistorico);
            Controls.Add(label1);
            Name = "FrmMenuPrincipal";
            Text = "Menu principal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVerHistorico;
        private Button btnIniciarQuiz;
        private Button btnVerRanking;
        private Button BtnSair;
    }
}