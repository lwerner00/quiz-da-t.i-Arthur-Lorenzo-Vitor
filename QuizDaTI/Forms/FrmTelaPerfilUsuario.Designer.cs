namespace QuizDaTI.Forms
{
    partial class FrmTelaPerfilUsuario
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
            lblJogador = new Label();
            lblNivelJogador = new Label();
            lblTotalDePontosJogador = new Label();
            lblPerguntasRespondidas = new Label();
            lblAcertosDoJogador = new Label();
            lblTemaMaisAcertado = new Label();
            bntConquistas = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblJogador
            // 
            lblJogador.AutoSize = true;
            lblJogador.BackColor = Color.MediumPurple;
            lblJogador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJogador.Location = new Point(120, 77);
            lblJogador.Name = "lblJogador";
            lblJogador.Size = new Size(99, 32);
            lblJogador.TabIndex = 5;
            lblJogador.Text = "Jogador";
            // 
            // lblNivelJogador
            // 
            lblNivelJogador.AutoSize = true;
            lblNivelJogador.BackColor = Color.MediumPurple;
            lblNivelJogador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNivelJogador.Location = new Point(120, 126);
            lblNivelJogador.MaximumSize = new Size(100, 0);
            lblNivelJogador.MinimumSize = new Size(230, 0);
            lblNivelJogador.Name = "lblNivelJogador";
            lblNivelJogador.Size = new Size(230, 25);
            lblNivelJogador.TabIndex = 7;
            lblNivelJogador.Text = "Nivel 1. Iniciante (300/500)";
            // 
            // lblTotalDePontosJogador
            // 
            lblTotalDePontosJogador.AutoSize = true;
            lblTotalDePontosJogador.BackColor = Color.MediumPurple;
            lblTotalDePontosJogador.Location = new Point(27, 197);
            lblTotalDePontosJogador.MinimumSize = new Size(250, 30);
            lblTotalDePontosJogador.Name = "lblTotalDePontosJogador";
            lblTotalDePontosJogador.Size = new Size(260, 30);
            lblTotalDePontosJogador.TabIndex = 17;
            lblTotalDePontosJogador.Text = "Total de Pontos do Jogador: 00";
            // 
            // lblPerguntasRespondidas
            // 
            lblPerguntasRespondidas.AutoSize = true;
            lblPerguntasRespondidas.BackColor = Color.MediumPurple;
            lblPerguntasRespondidas.Location = new Point(27, 244);
            lblPerguntasRespondidas.MinimumSize = new Size(250, 30);
            lblPerguntasRespondidas.Name = "lblPerguntasRespondidas";
            lblPerguntasRespondidas.Size = new Size(250, 30);
            lblPerguntasRespondidas.TabIndex = 18;
            lblPerguntasRespondidas.Text = "Perguntas respondidas : 00";
            // 
            // lblAcertosDoJogador
            // 
            lblAcertosDoJogador.AutoSize = true;
            lblAcertosDoJogador.BackColor = Color.MediumPurple;
            lblAcertosDoJogador.Location = new Point(27, 290);
            lblAcertosDoJogador.MinimumSize = new Size(250, 30);
            lblAcertosDoJogador.Name = "lblAcertosDoJogador";
            lblAcertosDoJogador.Size = new Size(250, 30);
            lblAcertosDoJogador.TabIndex = 19;
            lblAcertosDoJogador.Text = "Acertos do Jogador: 00";
            // 
            // lblTemaMaisAcertado
            // 
            lblTemaMaisAcertado.AutoSize = true;
            lblTemaMaisAcertado.BackColor = Color.MediumPurple;
            lblTemaMaisAcertado.Location = new Point(27, 340);
            lblTemaMaisAcertado.MinimumSize = new Size(250, 30);
            lblTemaMaisAcertado.Name = "lblTemaMaisAcertado";
            lblTemaMaisAcertado.Size = new Size(250, 30);
            lblTemaMaisAcertado.TabIndex = 20;
            lblTemaMaisAcertado.Text = "Especialista em : Redes ";
            // 
            // bntConquistas
            // 
            bntConquistas.BackColor = Color.MediumPurple;
            bntConquistas.Location = new Point(460, 64);
            bntConquistas.Name = "bntConquistas";
            bntConquistas.Size = new Size(150, 62);
            bntConquistas.TabIndex = 21;
            bntConquistas.Text = "Conquistas";
            bntConquistas.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = Properties.Resources.github_3__1_;
            pictureBox1.Location = new Point(12, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // FrmTelaPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(bntConquistas);
            Controls.Add(lblTemaMaisAcertado);
            Controls.Add(lblAcertosDoJogador);
            Controls.Add(lblPerguntasRespondidas);
            Controls.Add(lblTotalDePontosJogador);
            Controls.Add(lblNivelJogador);
            Controls.Add(lblJogador);
            Name = "FrmTelaPerfilUsuario";
            Text = "FrmTelaPerfilUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJogador;
        private Label lblNivelJogador;
        private Label lblTotalDePontosJogador;
        private Label lblPerguntasRespondidas;
        private Label lblAcertosDoJogador;
        private Label lblTemaMaisAcertado;
        private Button bntConquistas;
        private PictureBox pictureBox1;
    }
}