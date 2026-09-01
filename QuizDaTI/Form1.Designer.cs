namespace QuizDaTI
{
    partial class FrmMudarSenha
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
            label2 = new Label();
            label3 = new Label();
            txtNovaSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            btnMudarSenha = new Button();
            txtSenhaAtual = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 167);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Nova Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 226);
            label3.Name = "label3";
            label3.Size = new Size(186, 25);
            label3.TabIndex = 2;
            label3.Text = "Confirmar nova senha";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(315, 166);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(150, 31);
            txtNovaSenha.TabIndex = 4;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(315, 226);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(150, 31);
            txtConfirmarSenha.TabIndex = 5;
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.Location = new Point(318, 281);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(136, 104);
            btnMudarSenha.TabIndex = 6;
            btnMudarSenha.Text = "Mudar Senha";
            btnMudarSenha.UseVisualStyleBackColor = true;
            btnMudarSenha.Click += btnMudarSenha_Click;
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Location = new Point(315, 107);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.Size = new Size(150, 31);
            txtSenhaAtual.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 108);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 7;
            label1.Text = "Senha Atual";
            // 
            // FrmMudarSenha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenhaAtual);
            Controls.Add(label1);
            Controls.Add(btnMudarSenha);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FrmMudarSenha";
            Text = "Mudar Senha";
            Load += FrmMudarSenha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmarSenha;
        private Button btnMudarSenha;
        private TextBox txtSenhaAtual;
        private Label label1;
    }
}