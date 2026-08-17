using QuizDaTI.Forms;

namespace QuizDaTI
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLogin().ShowDialog();
            this.Show();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCriarConta().ShowDialog();
            this.Show();
        }
    }
}
