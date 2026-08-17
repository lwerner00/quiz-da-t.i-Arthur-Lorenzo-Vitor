namespace QuizC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            new Histórico().ShowDialog();
            this.Show();
        }

        private void btnIniciarQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            new IniciarQuiz().ShowDialog();
            this.Show();
        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VerRanking().ShowDialog();
            this.Show();
        }
    }
}
