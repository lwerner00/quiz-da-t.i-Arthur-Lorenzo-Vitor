namespace QuizDaTI.Forms
{
    partial class FrmQuiz
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
            lblEnunciado = new Label();
            btnAlternativa1 = new Button();
            btnAlternativa2 = new Button();
            btnAlternativa3 = new Button();
            btnAlternativa4 = new Button();
            lblNickENivel = new Label();
            btnProxima = new Button();
            lblPontosTotais = new Label();
            lblPontosENivel = new Label();
            lblBonus = new Label();
            SuspendLayout();
            // 
            // lblEnunciado
            // 
            lblEnunciado.BackColor = Color.FromArgb(45, 40, 62);
            lblEnunciado.Font = new Font("Segoe UI", 11F);
            lblEnunciado.ForeColor = Color.FromArgb(209, 215, 224);
            lblEnunciado.Location = new Point(161, 46);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(476, 100);
            lblEnunciado.TabIndex = 0;
            lblEnunciado.Text = "Enunciado";
            lblEnunciado.Click += lblEnunciado_Click;
            // 
            // btnAlternativa1
            // 
            btnAlternativa1.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa1.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa1.Location = new Point(101, 136);
            btnAlternativa1.Name = "btnAlternativa1";
            btnAlternativa1.Size = new Size(258, 119);
            btnAlternativa1.TabIndex = 1;
            btnAlternativa1.Text = "Alternativa 1";
            btnAlternativa1.UseVisualStyleBackColor = false;
            btnAlternativa1.Click += btnAlternativa1_Click;
            // 
            // btnAlternativa2
            // 
            btnAlternativa2.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa2.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa2.Location = new Point(401, 136);
            btnAlternativa2.Name = "btnAlternativa2";
            btnAlternativa2.Size = new Size(258, 119);
            btnAlternativa2.TabIndex = 2;
            btnAlternativa2.Text = "Alternativa 2";
            btnAlternativa2.UseVisualStyleBackColor = false;
            btnAlternativa2.Click += btnAlternativa2_Click;
            // 
            // btnAlternativa3
            // 
            btnAlternativa3.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa3.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa3.Location = new Point(101, 280);
            btnAlternativa3.Name = "btnAlternativa3";
            btnAlternativa3.Size = new Size(258, 119);
            btnAlternativa3.TabIndex = 3;
            btnAlternativa3.Text = "Alternativa 3";
            btnAlternativa3.UseVisualStyleBackColor = false;
            btnAlternativa3.Click += btnAlternativa3_Click;
            // 
            // btnAlternativa4
            // 
            btnAlternativa4.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa4.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa4.Location = new Point(401, 280);
            btnAlternativa4.Name = "btnAlternativa4";
            btnAlternativa4.Size = new Size(258, 119);
            btnAlternativa4.TabIndex = 4;
            btnAlternativa4.Text = "Alternativa 4";
            btnAlternativa4.UseVisualStyleBackColor = false;
            btnAlternativa4.Click += btnAlternativa4_Click;
            // 
            // lblNickENivel
            // 
            lblNickENivel.AutoSize = true;
            lblNickENivel.BackColor = Color.FromArgb(76, 73, 93);
            lblNickENivel.Font = new Font("Segoe UI", 12F);
            lblNickENivel.ForeColor = Color.FromArgb(209, 215, 224);
            lblNickENivel.Location = new Point(12, 9);
            lblNickENivel.Name = "lblNickENivel";
            lblNickENivel.Size = new Size(120, 32);
            lblNickENivel.TabIndex = 5;
            lblNickENivel.Text = "Nick e nvl";
            // 
            // btnProxima
            // 
            btnProxima.BackColor = Color.FromArgb(76, 73, 93);
            btnProxima.ForeColor = Color.FromArgb(209, 215, 224);
            btnProxima.Location = new Point(647, 405);
            btnProxima.Name = "btnProxima";
            btnProxima.Size = new Size(141, 40);
            btnProxima.TabIndex = 6;
            btnProxima.Text = "Próxima";
            btnProxima.UseVisualStyleBackColor = false;
            btnProxima.Click += button1_Click;
            // 
            // lblPontosTotais
            // 
            lblPontosTotais.AutoSize = true;
            lblPontosTotais.BackColor = Color.FromArgb(76, 73, 93);
            lblPontosTotais.Font = new Font("Segoe UI", 12F);
            lblPontosTotais.ForeColor = Color.FromArgb(209, 215, 224);
            lblPontosTotais.Location = new Point(206, 9);
            lblPontosTotais.Name = "lblPontosTotais";
            lblPontosTotais.Size = new Size(127, 32);
            lblPontosTotais.TabIndex = 7;
            lblPontosTotais.Text = "Pnts Totais";
            lblPontosTotais.Click += label1_Click;
            // 
            // lblPontosENivel
            // 
            lblPontosENivel.AutoSize = true;
            lblPontosENivel.BackColor = Color.FromArgb(76, 73, 93);
            lblPontosENivel.Font = new Font("Segoe UI", 12F);
            lblPontosENivel.ForeColor = Color.FromArgb(209, 215, 224);
            lblPontosENivel.Location = new Point(447, 9);
            lblPontosENivel.Name = "lblPontosENivel";
            lblPontosENivel.Size = new Size(224, 32);
            lblPontosENivel.TabIndex = 8;
            lblPontosENivel.Text = "Pontos Da Pergunta";
            // 
            // lblBonus
            // 
            lblBonus.BackColor = Color.FromArgb(45, 40, 62);
            lblBonus.Font = new Font("Segoe UI", 11F);
            lblBonus.ForeColor = Color.FromArgb(209, 215, 224);
            lblBonus.Location = new Point(12, 406);
            lblBonus.Name = "lblBonus";
            lblBonus.Size = new Size(339, 35);
            lblBonus.TabIndex = 9;
            // 
            // FrmQuiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
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
            Name = "FrmQuiz";
            Text = "Quiz";
            Load += FrmQuiz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnunciado;
        private Button btnAlternativa1;
        private Button btnAlternativa2;
        private Button btnAlternativa3;
        private Button btnAlternativa4;
        private Label lblNickENivel;
        private Button btnProxima;
        private Label lblPontosTotais;
        private Label lblPontosENivel;
        private Label lblBonus;
    }
}