using QuizDaTI.Banco.Repositories;
using System.ComponentModel;
using QuizDaTI.Modelos;
namespace QuizDaTI.Forms

{
    public partial class FrmResultado : Form
    {
        private int idPergunta;
        private int Pontos;
        private int IdUsuario;

        public FrmResultado(int IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
        }

        private async Task AtualizarTabela()
        {
            var perguntas = await PerguntasRepository.ObterUltimasRespondidas();
            dgvResultadoQuiz.DataSource = new BindingList<Pergunta>(perguntas.ToList());
        }

        private async Task ExibirPontos()
        {
            Pontos = await PerguntasRepository.SomarPontuacao();
            lblPontosGanhos.Text = $"Pontos Ganhos: {Pontos}";

        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
            ExibirPontos();
        }


        private void lblNickENivel_Click(object sender, EventArgs e)
        {

        }

        private void dgvResultadoQuiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnRetornar_Click(object sender, EventArgs e)
        {
            var perguntas = await PerguntasRepository.ObterUltimasRespondidas();

            HistoricoRepository historicoRepository = new HistoricoRepository();

            foreach (var pergunta in perguntas)
            {
                bool acertou = pergunta.Resposta == pergunta.AlternativaCorreta;

                int pontosGanhos = acertou ? pergunta.Pontuacao : 0;

                await historicoRepository.SalvarHistorico(
                    pergunta.Id,
                    pergunta.Tema,
                    acertou,
                    pontosGanhos
                );
            }

            await UsuarioRepository.RegistrarJogada(IdUsuario);
            await UsuarioRepository.AdicionarPontos(IdUsuario, Pontos);
            await PerguntasRepository.LimparResposta();

            Pontos = 0;

            this.Close();

        }
    }
}
