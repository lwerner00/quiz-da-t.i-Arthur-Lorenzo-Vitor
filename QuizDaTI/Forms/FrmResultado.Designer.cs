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
            lblNickENivel = new Label();
            dgvResultadoQuiz = new DataGridView();
            btnRetornar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultadoQuiz).BeginInit();
            SuspendLayout();
            // 
            // lblNickENivel
            // 
            lblNickENivel.AutoSize = true;
            lblNickENivel.BackColor = Color.FromArgb(45, 40, 62);
            lblNickENivel.Font = new Font("Segoe UI", 12F);
            lblNickENivel.ForeColor = Color.FromArgb(209, 215, 224);
            lblNickENivel.Location = new Point(336, 9);
            lblNickENivel.Name = "lblNickENivel";
            lblNickENivel.Size = new Size(118, 32);
            lblNickENivel.TabIndex = 6;
            lblNickENivel.Text = "Resultado";
            lblNickENivel.Click += lblNickENivel_Click;
            // 
            // dgvResultadoQuiz
            // 
            dgvResultadoQuiz.BackgroundColor = Color.FromArgb(76, 73, 93);
            dgvResultadoQuiz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadoQuiz.Location = new Point(29, 44);
            dgvResultadoQuiz.Name = "dgvResultadoQuiz";
            dgvResultadoQuiz.RowHeadersWidth = 62;
            dgvResultadoQuiz.Size = new Size(741, 349);
            dgvResultadoQuiz.TabIndex = 7;
            dgvResultadoQuiz.CellContentClick += dgvResultadoQuiz_CellContentClick;
            // 
            // btnRetornar
            // 
            btnRetornar.BackColor = Color.FromArgb(128, 43, 177);
            btnRetornar.ForeColor = Color.FromArgb(209, 215, 224);
            btnRetornar.Location = new Point(322, 399);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(154, 43);
            btnRetornar.TabIndex = 8;
            btnRetornar.Text = "Retornar";
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // FrmResultado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetornar);
            Controls.Add(dgvResultadoQuiz);
            Controls.Add(lblNickENivel);
            Name = "FrmResultado";
            Text = "Resultado do quiz";
            Load += FrmResultado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultadoQuiz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNickENivel;
        private DataGridView dgvResultadoQuiz;
        private Button btnRetornar;
    }
}