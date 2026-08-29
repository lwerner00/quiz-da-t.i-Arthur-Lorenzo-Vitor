namespace QuizDaTI.Forms
{
    partial class FrmAdmin
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
            btnCadastrarPergunta = new Button();
            btnRanking = new Button();
            SuspendLayout();
            // 
            // btnCadastrarPergunta
            // 
            btnCadastrarPergunta.BackColor = Color.FromArgb(128, 43, 177);
            btnCadastrarPergunta.ForeColor = Color.FromArgb(209, 215, 224);
            btnCadastrarPergunta.Location = new Point(418, 173);
            btnCadastrarPergunta.Name = "btnCadastrarPergunta";
            btnCadastrarPergunta.Size = new Size(229, 105);
            btnCadastrarPergunta.TabIndex = 4;
            btnCadastrarPergunta.Text = "Cadastrar Pergunta";
            btnCadastrarPergunta.UseVisualStyleBackColor = false;
            btnCadastrarPergunta.Click += btnCadastrarPergunta_Click;
            // 
            // btnRanking
            // 
            btnRanking.BackColor = Color.FromArgb(128, 43, 177);
            btnRanking.ForeColor = Color.FromArgb(209, 215, 224);
            btnRanking.Location = new Point(153, 173);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(229, 105);
            btnRanking.TabIndex = 3;
            btnRanking.Text = "Ver Ranking";
            btnRanking.UseVisualStyleBackColor = false;
            btnRanking.Click += btnRanking_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarPergunta);
            Controls.Add(btnRanking);
            Name = "FrmAdmin";
            Text = "FrmAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarPergunta;
        private Button btnRanking;
    }
}