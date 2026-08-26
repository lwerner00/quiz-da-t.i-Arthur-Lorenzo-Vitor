namespace QuizDaTI.Forms
{
    partial class FrmResultado
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
            dgvResultadoQuiz = new DataGridView();
            btnRetornar = new Button();
            lblPontosGanhos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultadoQuiz).BeginInit();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.FromArgb(45, 40, 62);
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.ForeColor = Color.FromArgb(209, 215, 224);
            lblResultado.Location = new Point(336, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(118, 32);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            lblResultado.Click += lblNickENivel_Click;
            // 
            // dgvResultadoQuiz
            // 
            dgvResultadoQuiz.BackgroundColor = Color.FromArgb(76, 73, 93);
            dgvResultadoQuiz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadoQuiz.GridColor = Color.FromArgb(76, 73, 93);
            dgvResultadoQuiz.Location = new Point(29, 44);
            dgvResultadoQuiz.Name = "dgvResultadoQuiz";
            dgvResultadoQuiz.RowHeadersWidth = 62;
            dgvResultadoQuiz.Size = new Size(741, 349);
            dgvResultadoQuiz.TabIndex = 7;
            // 
            // btnRetornar
            // 
            btnRetornar.BackColor = Color.FromArgb(128, 43, 177);
            btnRetornar.ForeColor = Color.FromArgb(209, 215, 224);
            btnRetornar.Location = new Point(478, 399);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(154, 43);
            btnRetornar.TabIndex = 8;
            btnRetornar.Text = "Retornar";
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // lblPontosGanhos
            // 
            lblPontosGanhos.AutoSize = true;
            lblPontosGanhos.BackColor = Color.FromArgb(45, 40, 62);
            lblPontosGanhos.Font = new Font("Segoe UI", 12F);
            lblPontosGanhos.ForeColor = Color.FromArgb(209, 215, 224);
            lblPontosGanhos.Location = new Point(137, 402);
            lblPontosGanhos.Name = "lblPontosGanhos";
            lblPontosGanhos.Size = new Size(0, 32);
            lblPontosGanhos.TabIndex = 9;
            // 
            // FrmResultado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(lblPontosGanhos);
            Controls.Add(btnRetornar);
            Controls.Add(dgvResultadoQuiz);
            Controls.Add(lblResultado);
            Name = "FrmResultado";
            Text = "Resultado do quiz";
            Load += FrmResultado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultadoQuiz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private DataGridView dgvResultadoQuiz;
        private Button btnRetornar;
        private Label lblPontosGanhos;
    }
}