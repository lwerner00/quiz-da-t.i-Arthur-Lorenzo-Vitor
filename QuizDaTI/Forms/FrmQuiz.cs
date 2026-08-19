using QuizDaTI.Banco.Repositories;
using QuizDaTI.Modelos;

namespace QuizDaTI.Forms
{
    public partial class FrmQuiz : Form
    {
        private int IdUsuario;
        private Usuario UsuarioAtual;
        private Pergunta PerguntaAtual;


        public FrmQuiz(int IdUsuarioAtual)
        {
            InitializeComponent();

            this.IdUsuario = IdUsuarioAtual;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void FrmQuiz_Load(object sender, EventArgs e)
        {
            UsuarioAtual = await UsuarioRepository.ObterPorId(IdUsuario);
            PerguntaAtual = await PerguntasRepository.ObterPerguntas();


            lblNickENivel.Text = $"{UsuarioAtual.NickName} lvl .5";
            lblEnunciado.Text = PerguntaAtual.Enunciado;
            lblPontosENivel.Text = $"Nível: {PerguntaAtual.Nivel}  {PerguntaAtual.Pontuacao} pontos";

        }

        private void lblEnunciado_Click(object sender, EventArgs e)
        {

        }
    }
}
