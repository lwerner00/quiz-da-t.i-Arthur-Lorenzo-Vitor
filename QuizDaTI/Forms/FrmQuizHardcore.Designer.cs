namespace QuizDaTI.Forms
{
    partial class FrmQuizHardcore
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
            components = new System.ComponentModel.Container();
            lblBonus = new Label();
            lblPontosENivel = new Label();
            lblPontosTotais = new Label();
            btnProxima = new Button();
            lblNickENivel = new Label();
            btnAlternativa4 = new Button();
            btnAlternativa3 = new Button();
            btnAlternativa2 = new Button();
            btnAlternativa1 = new Button();
            lblEnunciado = new Label();
            timerTrocaDeTela = new System.Windows.Forms.Timer(components);
            lblTempo = new Label();
            SuspendLayout();
            // 
            // lblBonus
            // 
            lblBonus.BackColor = Color.FromArgb(45, 40, 62);
            lblBonus.Font = new Font("Segoe UI", 11F);
            lblBonus.ForeColor = Color.FromArgb(209, 215, 224);
            lblBonus.Location = new Point(12, 404);
            lblBonus.Name = "lblBonus";
            lblBonus.Size = new Size(339, 35);
            lblBonus.TabIndex = 19;
            // 
            // lblPontosENivel
            // 
            lblPontosENivel.AutoSize = true;
            lblPontosENivel.BackColor = Color.FromArgb(76, 73, 93);
            lblPontosENivel.Font = new Font("Segoe UI", 12F);
            lblPontosENivel.ForeColor = Color.FromArgb(209, 215, 224);
            lblPontosENivel.Location = new Point(447, 7);
            lblPontosENivel.Name = "lblPontosENivel";
            lblPontosENivel.Size = new Size(224, 32);
            lblPontosENivel.TabIndex = 18;
            lblPontosENivel.Text = "Pontos Da Pergunta";
            // 
            // lblPontosTotais
            // 
            lblPontosTotais.AutoSize = true;
            lblPontosTotais.BackColor = Color.FromArgb(76, 73, 93);
            lblPontosTotais.Font = new Font("Segoe UI", 12F);
            lblPontosTotais.ForeColor = Color.FromArgb(209, 215, 224);
            lblPontosTotais.Location = new Point(206, 7);
            lblPontosTotais.Name = "lblPontosTotais";
            lblPontosTotais.Size = new Size(127, 32);
            lblPontosTotais.TabIndex = 17;
            lblPontosTotais.Text = "Pnts Totais";
            // 
            // btnProxima
            // 
            btnProxima.BackColor = Color.FromArgb(76, 73, 93);
            btnProxima.ForeColor = Color.FromArgb(209, 215, 224);
            btnProxima.Location = new Point(647, 403);
            btnProxima.Name = "btnProxima";
            btnProxima.Size = new Size(141, 40);
            btnProxima.TabIndex = 16;
            btnProxima.Text = "Próxima";
            btnProxima.UseVisualStyleBackColor = false;
            btnProxima.Click += button1_Click;
            // 
            // lblNickENivel
            // 
            lblNickENivel.AutoSize = true;
            lblNickENivel.BackColor = Color.FromArgb(76, 73, 93);
            lblNickENivel.Font = new Font("Segoe UI", 12F);
            lblNickENivel.ForeColor = Color.FromArgb(209, 215, 224);
            lblNickENivel.Location = new Point(12, 7);
            lblNickENivel.Name = "lblNickENivel";
            lblNickENivel.Size = new Size(120, 32);
            lblNickENivel.TabIndex = 15;
            lblNickENivel.Text = "Nick e nvl";
            // 
            // btnAlternativa4
            // 
            btnAlternativa4.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa4.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa4.Location = new Point(401, 278);
            btnAlternativa4.Name = "btnAlternativa4";
            btnAlternativa4.Size = new Size(258, 119);
            btnAlternativa4.TabIndex = 14;
            btnAlternativa4.Text = "Alternativa 4";
            btnAlternativa4.UseVisualStyleBackColor = false;
            btnAlternativa4.Click += btnAlternativa4_Click_1;
            // 
            // btnAlternativa3
            // 
            btnAlternativa3.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa3.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa3.Location = new Point(101, 278);
            btnAlternativa3.Name = "btnAlternativa3";
            btnAlternativa3.Size = new Size(258, 119);
            btnAlternativa3.TabIndex = 13;
            btnAlternativa3.Text = "Alternativa 3";
            btnAlternativa3.UseVisualStyleBackColor = false;
            btnAlternativa3.Click += btnAlternativa3_Click_1;
            // 
            // btnAlternativa2
            // 
            btnAlternativa2.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa2.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa2.Location = new Point(401, 134);
            btnAlternativa2.Name = "btnAlternativa2";
            btnAlternativa2.Size = new Size(258, 119);
            btnAlternativa2.TabIndex = 12;
            btnAlternativa2.Text = "Alternativa 2";
            btnAlternativa2.UseVisualStyleBackColor = false;
            btnAlternativa2.Click += btnAlternativa2_Click_1;
            // 
            // btnAlternativa1
            // 
            btnAlternativa1.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa1.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa1.Location = new Point(101, 134);
            btnAlternativa1.Name = "btnAlternativa1";
            btnAlternativa1.Size = new Size(258, 119);
            btnAlternativa1.TabIndex = 11;
            btnAlternativa1.Text = "Alternativa 1";
            btnAlternativa1.UseVisualStyleBackColor = false;
            btnAlternativa1.Click += btnAlternativa1_Click_1;
            // 
            // lblEnunciado
            // 
            lblEnunciado.BackColor = Color.FromArgb(45, 40, 62);
            lblEnunciado.Font = new Font("Segoe UI", 11F);
            lblEnunciado.ForeColor = Color.FromArgb(209, 215, 224);
            lblEnunciado.Location = new Point(161, 44);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(476, 100);
            lblEnunciado.TabIndex = 10;
            lblEnunciado.Text = "Enunciado";
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.BackColor = Color.FromArgb(76, 73, 93);
            lblTempo.Font = new Font("Segoe UI", 16F);
            lblTempo.ForeColor = Color.FromArgb(209, 215, 224);
            lblTempo.Location = new Point(695, 71);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(0, 45);
            lblTempo.TabIndex = 20;
            // 
            // FrmQuizHardcore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(lblTempo);
            Controls.Add(lblBonus);
            Controls.Add(lblPontosENivel);
            Controls.Add(lblPontosTotais);
            Controls.Add(btnProxima);
            Controls.Add(lblNickENivel);
            Controls.Add(btnAlternativa4);
            Controls.Add(btnAlternativa3);
            Controls.Add(btnAlternativa2);
            Controls.Add(btnAlternativa1);
            Controls.Add(lblEnunciado);
            Name = "FrmQuizHardcore";
            Text = "Quiz Hardcore";
            Load += FrmQuizHardcore_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBonus;
        private Label lblPontosENivel;
        private Label lblPontosTotais;
        private Button btnProxima;
        private Label lblNickENivel;
        private Button btnAlternativa4;
        private Button btnAlternativa3;
        private Button btnAlternativa2;
        private Button btnAlternativa1;
        private Label lblEnunciado;
        private System.Windows.Forms.Timer timerTrocaDeTela;
        private Label lblTempo;
    }
}