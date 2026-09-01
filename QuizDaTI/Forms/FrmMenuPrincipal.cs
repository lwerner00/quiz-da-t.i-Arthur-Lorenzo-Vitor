namespace QuizDaTI.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        private int IdUsuarioAtual;

        public FrmMenuPrincipal(int IdUsuario)
        {
            InitializeComponent();

            this.IdUsuarioAtual = IdUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerHistorico_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Histótico().ShowDialog();

            this.Show();
        }

        private void btnIniciarQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmQuiz(IdUsuarioAtual).ShowDialog();
            this.Show();
        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRanking().ShowDialog();
            this.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmQuizHardcore(IdUsuarioAtual).ShowDialog();
            this.Show();
        }
    }
}
