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
            label1 = new Label();
            btnAlternativa1 = new Button();
            btnAlternativa2 = new Button();
            btnAlternativa3 = new Button();
            btnAlternativa4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(76, 73, 93);
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(209, 215, 224);
            label1.Location = new Point(316, 53);
            label1.Name = "label1";
            label1.Size = new Size(128, 38);
            label1.TabIndex = 0;
            label1.Text = "Pergunta";
            // 
            // btnAlternativa1
            // 
            btnAlternativa1.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa1.ForeColor = Color.FromArgb(209, 215, 224);
            btnAlternativa1.Location = new Point(137, 147);
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
            btnAlternativa2.Location = new Point(402, 147);
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
            btnAlternativa3.Location = new Point(137, 291);
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
            btnAlternativa4.Location = new Point(402, 291);
            btnAlternativa4.Name = "btnAlternativa4";
            btnAlternativa4.Size = new Size(229, 105);
            btnAlternativa4.TabIndex = 4;
            btnAlternativa4.Text = "Alternativa 4";
            btnAlternativa4.UseVisualStyleBackColor = false;
            // 
            // FrmQuiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlternativa4);
            Controls.Add(btnAlternativa3);
            Controls.Add(btnAlternativa2);
            Controls.Add(btnAlternativa1);
            Controls.Add(label1);
            Name = "FrmQuiz";
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAlternativa1;
        private Button btnAlternativa2;
        private Button btnAlternativa3;
        private Button btnAlternativa4;
    }
}