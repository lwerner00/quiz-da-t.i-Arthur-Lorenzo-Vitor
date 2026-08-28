using QuizDaTI.Banco.Repositories;
using QuizDaTI.Modelos;
using System.ComponentModel;
namespace QuizDaTI.Forms
{
    public partial class FrmResultado : Form
    {
        private int IdUsuario;
        private Usuario UsuarioAtual;
        private int Pontos;
        public FrmResultado(int idUsuario)
        {
            InitializeComponent();
            this.IdUsuario = idUsuario;
        }

        private async Task AtualizarTabela()
        {
            var perguntas = await PerguntasRepository.ObterUltimasRespondidas();
            dgvResultadoQuiz.DataSource = new BindingList<Pergunta>(perguntas.ToList());
            dgvResultadoQuiz.Columns["VerdadeiroOuFalso"].Visible = false;
        }

        private async Task AtualizarPontuacao()
        {
            //var perguntas = await PerguntasRepository.ObterUltimasRespondidas();
            Pontos = await PerguntasRepository.SomarPontuacao();
            lblPontosGanhos.Text = $"Pontos ganhos: {Pontos}";
        }

        private void lblNickENivel_Click(object sender, EventArgs e)
        {

        }

        private async void FrmResultado_Load(object sender, EventArgs e)
        {
            await AtualizarTabela();
            await AtualizarPontuacao();
            await UsuarioRepository.AdicionarPontos(Pontos, IdUsuario);
        }

        private async void btnRetornar_Click(object sender, EventArgs e)
        {
            await UsuarioRepository.RegistrarJogada(IdUsuario);
            await PerguntasRepository.LimparResposta();
            Pontos = 0;
            this.Close();
        }
    }
}
