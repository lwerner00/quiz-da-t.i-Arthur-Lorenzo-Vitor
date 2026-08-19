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
            button1 = new Button();
            label1 = new Label();
            lblPontosENivel = new Label();
            SuspendLayout();
            // 
            // lblEnunciado
            // 
            lblEnunciado.BackColor = Color.FromArgb(45, 40, 62);
            lblEnunciado.Font = new Font("Segoe UI", 11F);
            lblEnunciado.ForeColor = Color.FromArgb(209, 215, 224);
            lblEnunciado.Location = new Point(162, 65);
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
            btnAlternativa1.Location = new Point(144, 155);
            btnAlternativa1.Name = "btnAlternativa1";
            btnAlternativa1.Size = new Size(229, 105);
            btnAlternativa1.TabIndex = 1;
            btnAlternativa1.Text = "Alternativa 1";
            btnAlternativa1.UseVisualStyleBackColor = false;
            // 
            // btnAlternativa2
            // 
            btnAlternativa2.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa2.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa2.Location = new Point(409, 155);
            btnAlternativa2.Name = "btnAlternativa2";
            btnAlternativa2.Size = new Size(229, 105);
            btnAlternativa2.TabIndex = 2;
            btnAlternativa2.Text = "Alternativa 2";
            btnAlternativa2.UseVisualStyleBackColor = false;
            // 
            // btnAlternativa3
            // 
            btnAlternativa3.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa3.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa3.Location = new Point(144, 299);
            btnAlternativa3.Name = "btnAlternativa3";
            btnAlternativa3.Size = new Size(229, 105);
            btnAlternativa3.TabIndex = 3;
            btnAlternativa3.Text = "Alternativa 3";
            btnAlternativa3.UseVisualStyleBackColor = false;
            // 
            // btnAlternativa4
            // 
            btnAlternativa4.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa4.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa4.Location = new Point(409, 299);
            btnAlternativa4.Name = "btnAlternativa4";
            btnAlternativa4.Size = new Size(229, 105);
            btnAlternativa4.TabIndex = 4;
            btnAlternativa4.Text = "Alternativa 4";
            btnAlternativa4.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 73, 93);
            button1.ForeColor = Color.FromArgb(209, 215, 224);
            button1.Location = new Point(647, 405);
            button1.Name = "button1";
            button1.Size = new Size(141, 40);
            button1.TabIndex = 6;
            button1.Text = "Próxima";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(76, 73, 93);
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(209, 215, 224);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 7;
            label1.Text = "Pnts Totais";
            // 
            // lblPontosENivel
            // 
            lblPontosENivel.AutoSize = true;
            lblPontosENivel.BackColor = Color.FromArgb(76, 73, 93);
            lblPontosENivel.Font = new Font("Segoe UI", 12F);
            lblPontosENivel.ForeColor = Color.FromArgb(209, 215, 224);
            lblPontosENivel.Location = new Point(527, 9);
            lblPontosENivel.Name = "lblPontosENivel";
            lblPontosENivel.Size = new Size(224, 32);
            lblPontosENivel.TabIndex = 8;
            lblPontosENivel.Text = "Pontos Da Pergunta";
            // 
            // FrmQuiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(lblPontosENivel);
            Controls.Add(label1);
            Controls.Add(button1);
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
        private Button button1;
        private Label label1;
        private Label lblPontosENivel;
    }
}