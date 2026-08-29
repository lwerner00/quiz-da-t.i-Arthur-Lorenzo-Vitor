namespace QuizDaTI.Forms
{
    partial class FrmHistorico
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
            dgvHistorico = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorico
            // 
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(49, 40);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.RowHeadersWidth = 62;
            dgvHistorico.Size = new Size(670, 365);
            dgvHistorico.TabIndex = 0;
            dgvHistorico.CellContentClick += dgvHistorico_CellContentClick;
            // 
            // FrmHistorico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHistorico);
            Name = "FrmHistorico";
            Text = "FrmHistorico";
            Load += FrmHistorico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorico;
    }
}