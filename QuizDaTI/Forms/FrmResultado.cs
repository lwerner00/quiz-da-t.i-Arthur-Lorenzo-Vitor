using QuizDaTI.Banco.Repositories;
using System.ComponentModel;
using QuizDaTI.Modelos;
namespace QuizDaTI.Forms

{
    public partial class FrmResultado : Form
    {
        private int idPergunta;

        public object IdUsuario { get; private set; }
        public int Pontos { get; private set; }

        public FrmResultado(int IdPergunta)
        {
            InitializeComponent();
            idPergunta = IdPergunta;
        }

        private async Task AtualizarTabela()
        {
            var perguntas = await PerguntasRepository.ObterUltimasRespondidas();
            dgvResultadoQuiz.DataSource = new BindingList<Pergunta>(perguntas.ToList());
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
            await PerguntasRepository.LimparResposta();

            Pontos = 0;

            this.Close();
        
        }
    }
}
