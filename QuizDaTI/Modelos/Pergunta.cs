namespace QuizDaTI.Modelos
{
    public class Pergunta
    {
        public Pergunta(string enunciado, string tipo, string alternativaCorreta, string alternativaIncorreta1, string alternativaIncorreta2, string alternativaIncorreta3, bool verdadeiroOuFalso, string nivel, int pontuacao, string tema)
        {
            Enunciado = enunciado;
            Tipo = tipo;
            AlternativaCorreta = alternativaCorreta;
            AlternativaIncorreta1 = alternativaIncorreta1;
            AlternativaIncorreta2 = alternativaIncorreta2;
            AlternativaIncorreta3 = alternativaIncorreta3;
            VerdadeiroOuFalso = verdadeiroOuFalso;
            Nivel = nivel;
            Pontuacao = pontuacao;
            Tema = tema;
        }

        public Pergunta(int id,string enunciado, string tipo, string alternativaCorreta, string alternativaIncorreta1, string alternativaIncorreta2, string alternativaIncorreta3, bool verdadeiroOuFalso, string nivel, int pontuacao, string tema, string resposta)
        {
            Id = id;
            Enunciado = enunciado;
            Tipo = tipo;
            AlternativaCorreta = alternativaCorreta;
            AlternativaIncorreta1 = alternativaIncorreta1;
            AlternativaIncorreta2 = alternativaIncorreta2;
            AlternativaIncorreta3 = alternativaIncorreta3;
            VerdadeiroOuFalso = verdadeiroOuFalso;
            Nivel = nivel;
            Pontuacao = pontuacao;
            Tema = tema;
            Resposta = resposta;
        }

        public int Id { get; set; }

        public string Enunciado { get; private set; }

        public string Tipo { get; private set;}

        public string AlternativaCorreta { get; private set;}

        public string AlternativaIncorreta1 { get; private set; }

        public string AlternativaIncorreta2 { get; private set; }

        public string AlternativaIncorreta3 { get; private set; }

        public bool VerdadeiroOuFalso { get; private set; }

        public string Nivel {  get; private set; }

        public int Pontuacao { get; set; }

        public string Tema { get; private set; }

        public string Resposta { get; set; }


        //public void SetResposta(string resposta)
        //{
        //    Resposta = resposta;
        //}

    }
}
