namespace QuizDaTI.Forms
{
    partial class FrmTelaRanking
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
        private DataGridView dgvRankingJogadores;
        private TextBox txtProcurarJogador;
        private Button btnPesquisar;
        private Button btnLimpar;
        private DataGridViewTextBoxColumn colPosicao;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colPontosTotais;
        private DataGridViewTextBoxColumn colAcertos;
        private DataGridViewTextBoxColumn colPerguntasRespondidas;
        private DataGridViewTextBoxColumn colAcertosConsecutivos;
        private DataGridViewTextBoxColumn colTema;
        private Button btnVerPerfil;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVerPerfil = new Button();
            btnLimpar = new Button();
            btnPesquisar = new Button();
            txtProcurarJogador = new TextBox();
            dgvRankingJogadores = new DataGridView();
            colPosicao = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colPontosTotais = new DataGridViewTextBoxColumn();
            colAcertos = new DataGridViewTextBoxColumn();
            colPerguntasRespondidas = new DataGridViewTextBoxColumn();
            colAcertosConsecutivos = new DataGridViewTextBoxColumn();
            colTema = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRankingJogadores).BeginInit();
            SuspendLayout();
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.Location = new Point(797, 20);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(112, 34);
            btnVerPerfil.TabIndex = 10;
            btnVerPerfil.Text = "Ver perfil";
            btnVerPerfil.UseVisualStyleBackColor = true;
            btnVerPerfil.Visible = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(511, 6);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(378, 6);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(112, 34);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "Procurar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtProcurarJogador
            // 
            txtProcurarJogador.Location = new Point(12, 9);
            txtProcurarJogador.Name = "txtProcurarJogador";
            txtProcurarJogador.PlaceholderText = "Para procurar, digite o nome do jogador";
            txtProcurarJogador.Size = new Size(336, 31);
            txtProcurarJogador.TabIndex = 7;
            // 
            // dgvRankingJogadores
            // 
            dgvRankingJogadores.AllowDrop = true;
            dgvRankingJogadores.AllowUserToAddRows = false;
            dgvRankingJogadores.AllowUserToDeleteRows = false;
            dgvRankingJogadores.AllowUserToOrderColumns = true;
            dgvRankingJogadores.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvRankingJogadores.ColumnHeadersHeight = 34;
            dgvRankingJogadores.Columns.AddRange(new DataGridViewColumn[] { colPosicao, colNome, colPontosTotais, colAcertos, colPerguntasRespondidas, colAcertosConsecutivos, colTema });
            dgvRankingJogadores.Dock = DockStyle.Bottom;
            dgvRankingJogadores.GridColor = SystemColors.Window;
            dgvRankingJogadores.Location = new Point(0, 112);
            dgvRankingJogadores.MultiSelect = false;
            dgvRankingJogadores.Name = "dgvRankingJogadores";
            dgvRankingJogadores.ReadOnly = true;
            dgvRankingJogadores.RightToLeft = RightToLeft.No;
            dgvRankingJogadores.RowHeadersWidth = 30;
            dgvRankingJogadores.ScrollBars = ScrollBars.Vertical;
            dgvRankingJogadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRankingJogadores.Size = new Size(1055, 415);
            dgvRankingJogadores.TabIndex = 6;
            // 
            // colPosicao
            // 
            colPosicao.HeaderText = "Posição";
            colPosicao.MinimumWidth = 8;
            colPosicao.Name = "colPosicao";
            colPosicao.ReadOnly = true;
            colPosicao.SortMode = DataGridViewColumnSortMode.NotSortable;
            colPosicao.Width = 150;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 8;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNome.Width = 140;
            // 
            // colPontosTotais
            // 
            colPontosTotais.HeaderText = "Pontos Totais";
            colPontosTotais.MinimumWidth = 8;
            colPontosTotais.Name = "colPontosTotais";
            colPontosTotais.ReadOnly = true;
            colPontosTotais.SortMode = DataGridViewColumnSortMode.NotSortable;
            colPontosTotais.Width = 150;
            // 
            // colAcertos
            // 
            colAcertos.HeaderText = "Acertos ";
            colAcertos.MinimumWidth = 8;
            colAcertos.Name = "colAcertos";
            colAcertos.ReadOnly = true;
            colAcertos.SortMode = DataGridViewColumnSortMode.NotSortable;
            colAcertos.Width = 120;
            // 
            // colPerguntasRespondidas
            // 
            colPerguntasRespondidas.HeaderText = "PerguntasRespondidas";
            colPerguntasRespondidas.MinimumWidth = 8;
            colPerguntasRespondidas.Name = "colPerguntasRespondidas";
            colPerguntasRespondidas.ReadOnly = true;
            colPerguntasRespondidas.SortMode = DataGridViewColumnSortMode.NotSortable;
            colPerguntasRespondidas.Width = 205;
            // 
            // colAcertosConsecutivos
            // 
            colAcertosConsecutivos.HeaderText = "AcertosConsecutivos";
            colAcertosConsecutivos.MinimumWidth = 8;
            colAcertosConsecutivos.Name = "colAcertosConsecutivos";
            colAcertosConsecutivos.ReadOnly = true;
            colAcertosConsecutivos.SortMode = DataGridViewColumnSortMode.NotSortable;
            colAcertosConsecutivos.Width = 190;
            // 
            // colTema
            // 
            colTema.HeaderText = "Tema";
            colTema.MinimumWidth = 8;
            colTema.Name = "colTema";
            colTema.ReadOnly = true;
            colTema.Width = 150;
            // 
            // FrmTelaRanking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 527);
            Controls.Add(btnVerPerfil);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtProcurarJogador);
            Controls.Add(dgvRankingJogadores);
            Name = "FrmTelaRanking";
            Text = "FrmTelaRanking";
            Load += FrmTelaRanking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRankingJogadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}