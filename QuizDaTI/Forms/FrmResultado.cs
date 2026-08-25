using QuizDaTI.Banco.Repositories;
using System.ComponentModel;
namespace QuizDaTI.Forms
{
    public partial class FrmResultado : Form
    {
        public FrmResultado(int IdPergunta)
        {
            InitializeComponent();
        }

        private async Task AtualizarTabela()
        {
            var perguntas = await PerguntasRepository.ObterUltimasRespondidas();
            dgvResultadoQuiz.DataSource = new BindingList<Pergunta>(perguntas.ToList());
        }

        private void lblNickENivel_Click(object sender, EventArgs e)
        {

        }
    }
}
