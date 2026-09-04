using QuizDaTI.Banco.Repositories;
using QuizDaTI.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDaTI.Forms
{
    public partial class FrmTelaPerfilUsuario : Form
    {
        private Usuario UsuarioAtual;
        private Pergunta pergunta;
        private int IdUsuario;

        public FrmTelaPerfilUsuario(Usuario usuario)
        {
            InitializeComponent();


            UsuarioAtual = usuario;
            IdUsuario = usuario.Id;

            Load += FrmTelaPerfilUsuario_Load;
        }

        public FrmTelaPerfilUsuario(int idUsuario)
        {
            IdUsuario = idUsuario;
        }

        private async void FrmTelaPerfilUsuario_Load(object? sender, EventArgs e)
        {



            int pontos = await UsuarioRepository.PontosDoJogador(UsuarioAtual.Id);
            int perguntas = await UsuarioRepository.PerguntasRespondidas(UsuarioAtual.Id);
            int acertos = await UsuarioRepository.AcertosDoJogador(UsuarioAtual.Id);

            var especialidade = await UsuarioRepository.ObterEspecialidade(UsuarioAtual.Id);



            lblJogador.Text = UsuarioAtual.NickName;
            lblTotalDePontosJogador.Text = $"Total de Pontos do jogador: {pontos}";
            lblPerguntasRespondidas.Text = $"Perguntas respondidas: {perguntas}";
            lblAcertosDoJogador.Text = $"Acertos do Jogador :{acertos}";

            if (especialidade != null)
            {
                lblTemaMaisAcertado.Text =
                    $"Especialista em: {especialidade.Tema} - {especialidade.Acertos} acertos";
            }
            else
            {
                lblTemaMaisAcertado.Text =
                    "Especialista em: Nenhum tema ainda";
            }


            lblTotalDePontosJogador.Text =
                $"Total de Pontos do jogador: {pontos}";

            AtualizarNivel(pontos);


        }


        private void AtualizarNivel(int pontos)
        {
            string nivel;
            int proximoNivel;

            if (pontos < 500)
            {
                nivel = "Nível 1. Iniciante";
                proximoNivel = 500;
            }
            else if (pontos < 1000)
            {
                nivel = "Nível 2. Aprendiz";
                proximoNivel = 1000;
            }
            else if (pontos < 1500)
            {
                nivel = "Nível 3. Intermediário";
                proximoNivel = 1500;
            }
            else if (pontos < 2500)
            {
                nivel = "Nível 4. Avançado";
                proximoNivel = 2500;
            }
            else
            {
                nivel = "Nível 5. Especialista";
                proximoNivel = 2500;
            }

            lblNivelJogador.Text = $"{nivel} ({pontos}/{proximoNivel})";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmTelaPerfilUsuario_Load_1(object sender, EventArgs e)
        {

        }

        private void bntConquistas_Click(object sender, EventArgs e)

        {

            this.Hide();
            new FrmConquista(IdUsuario).ShowDialog();
            this.Show();
        }


    }
}
