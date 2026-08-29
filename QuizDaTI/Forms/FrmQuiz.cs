


﻿using QuizDaTI.Banco.Repositories;
using QuizDaTI.Modelos;

namespace QuizDaTI.Forms

{
    public partial class FrmQuiz : Form
    {
        private int IdUsuario;
        private Usuario UsuarioAtual;
        private Pergunta PerguntaAtual;
        private Random random = new Random();
        private Button botaoCorreto;
        private bool AlternativaSelecionadaValidacao = false;
        private string AlternativaSelecionada;
        private int ContadorCliques = 0;
        private bool VerificarSePodeJogarHoje;


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
            VerificarSePodeJogarHoje = await UsuarioRepository.PodeJogarHoje(IdUsuario);
            VerificarCincoAcertosSeguidos();
            VerificarTresAcertosSeguids();

            //if (VerificarSePodeJogarHoje == false)
            //{
            //    this.Close();
            //    MessageBox.Show("Você ja fez o Quiz de hoje!",
            //    "Quiz já realizado",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Warning);
            //}

            //PerguntaAtual = await PerguntasRepository.ObterPerguntas();
            lblNickENivel.Text = $"{UsuarioAtual.NickName} lvl .5";
            lblPontosTotais.Text = $"{UsuarioAtual.PontuacaoTotal} Pontos";
            AtualizarQuiz();

        }


        private async Task VerificarTresAcertosSeguids()
        {
           bool Verficar = await PerguntasRepository.VerificarTresAcertosSeguidos();

            if (Verficar)
            {
                PerguntaAtual.Pontuacao += (int)(PerguntaAtual.Pontuacao * 1.10);
                lblBonus.Text = "Pergunta Com bônus";
            }
        }

        private async Task VerificarCincoAcertosSeguidos()
        {
            bool Verficar = await PerguntasRepository.VerificarCincoAcertosSeguidos();

            if (Verficar)
            {
                PerguntaAtual.Pontuacao += (int)(PerguntaAtual.Pontuacao * 1.20);
                lblBonus.Text = "Pergunta com bônus";
            }
        }
        private async Task AtualizarQuiz()
        {
            VerificarTresAcertosSeguids();
            VerificarCincoAcertosSeguidos();
            PerguntaAtual = await PerguntasRepository.ObterPerguntas();
            btnAlternativa1.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa2.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa3.BackColor = Color.FromArgb(128, 43, 177);
            btnAlternativa4.BackColor = Color.FromArgb(128, 43, 177);
            AlternativaSelecionadaValidacao = false;
            AlternativaSelecionada = String.Empty;
            if (PerguntaAtual.Tipo == "MultiplaEscolha")
            {
                btnAlternativa3.Visible = true;
                btnAlternativa4.Visible = true;
                lblEnunciado.Text = PerguntaAtual.Enunciado;
                lblPontosENivel.Text = $"Nível: {PerguntaAtual.Nivel}  {PerguntaAtual.Pontuacao} pontos";
                string respostaCerta = PerguntaAtual.AlternativaCorreta;

                List<string> respostasErradas = new List<string> { PerguntaAtual.AlternativaIncorreta1, PerguntaAtual.AlternativaIncorreta2, PerguntaAtual.AlternativaIncorreta3 };
                Button[] botoes = new Button[] { btnAlternativa1, btnAlternativa2, btnAlternativa3, btnAlternativa4 };

                int indiceBotaoCerto = random.Next(botoes.Length);
                botaoCorreto = botoes[indiceBotaoCerto];
                botaoCorreto.Text = respostaCerta;

                int indiceErradas = 0;
                for (int i = 0; i < botoes.Length; i++)
                {
                    if (i != indiceBotaoCerto)
                    {
                        botoes[i].Text = respostasErradas[indiceErradas];
                        indiceErradas++;
                    }
                }
                //if (AlternativaSelecionada?.Trim() == PerguntaAtual.AlternativaCorreta?.Trim())
                //{
                //    PerguntaAtual.Resposta = "Correta";
                //    await PerguntasRepository.ResponderPergunta(PerguntaAtual.Resposta, PerguntaAtual.Id);
                //    UsuarioAtual.Pontuacao += PerguntaAtual.Pontuacao;
                //}
                //else
                //{
                //    PerguntaAtual.Resposta = "Incorreta";
                //    await PerguntasRepository.ResponderPergunta(PerguntaAtual.Resposta, PerguntaAtual.Id);
                //}
                

            }
            else
            {
                lblEnunciado.Text = PerguntaAtual.Enunciado;
                lblPontosENivel.Text = $"Nível: {PerguntaAtual.Nivel}  {PerguntaAtual.Pontuacao} pontos";
                string respostaCerta = PerguntaAtual.AlternativaCorreta;

                btnAlternativa1.Text = "Verdadeiro";
                btnAlternativa2.Text = "Falso";

                btnAlternativa3.Visible = false;
                btnAlternativa4.Visible = false;
            }

        }

        private void lblEnunciado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (AlternativaSelecionadaValidacao == false)
            {
                MessageBox.Show("Por favor, selecione pelo menos uma alternativa antes de continuar!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool respostaCorreta = string.Equals(
                AlternativaSelecionada?.Trim(),
                PerguntaAtual.AlternativaCorreta?.Trim(),
                StringComparison.OrdinalIgnoreCase
            );

            if (respostaCorreta)
            {
                PerguntaAtual.Resposta = "Correta";
                UsuarioAtual.Pontuacao += PerguntaAtual.Pontuacao;
            }
            else
            {
                PerguntaAtual.Resposta = "Incorreta";
            }
            await PerguntasRepository.ResponderPergunta(PerguntaAtual.Resposta, PerguntaAtual.Id);
            await AtualizarQuiz();
            ContadorCliques++;

            if(ContadorCliques == 9)
            {
                btnProxima.Text = "Finalizar";
            }
            else if(ContadorCliques > 9)
            {
                new FrmResultado(UsuarioAtual.Id).ShowDialog();
                this.Hide();
                this.Close();
            }

        }

    

        private void btnAlternativa2_Click(object sender, EventArgs e)
        {
            btnAlternativa2.BackColor = SystemColors.HotTrack;
            btnAlternativa1.BackColor = SystemColors.ControlDarkDark;
            btnAlternativa3.BackColor = SystemColors.ControlDarkDark;
            btnAlternativa4.BackColor = SystemColors.ControlDarkDark;
            AlternativaSelecionadaValidacao = true;
            AlternativaSelecionada = btnAlternativa2.Text;
        }

        private void btnAlternativa3_Click(object sender, EventArgs e)
        {
            btnAlternativa3.BackColor = SystemColors.HotTrack;
            btnAlternativa1.BackColor = SystemColors.ControlDarkDark;
            btnAlternativa2.BackColor = SystemColors.ControlDarkDark;
            btnAlternativa4.BackColor = SystemColors.ControlDarkDark;
            AlternativaSelecionadaValidacao = true;
            AlternativaSelecionada = btnAlternativa3.Text;
        }

        private void btnAlternativa4_Click(object sender, EventArgs e)
        {
            btnAlternativa4.BackColor = SystemColors.HotTrack;
            btnAlternativa1.BackColor = SystemColors.ControlDarkDark;
            btnAlternativa3.BackColor = SystemColors.ControlDarkDark;
            btnAlternativa2.BackColor = SystemColors.ControlDarkDark;
            AlternativaSelecionadaValidacao = true;
            AlternativaSelecionada = btnAlternativa4.Text;
        }

       
    }
}
