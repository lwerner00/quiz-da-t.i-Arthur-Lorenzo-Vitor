using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDaTI.Modelos
{
    public class Pergunta
    {
        public Pergunta(int id,string enunciado, string tipo, string alternativaCorreta, string alternativaIncorreta1, string alternativaIncorreta2, string alternativaIncorreta3, bool verdadeiroOuFalso, string nivel, int pontuacao, string tema)
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
        }

        public int Id { get; set; }

        public string Enunciado { get; set; }

        public string Tipo { get; set;}

        public string AlternativaCorreta { get; set;}

        public string AlternativaIncorreta1 { get; set; }

        public string AlternativaIncorreta2 { get; set; }

        public string AlternativaIncorreta3 { get; set; }

        public bool VerdadeiroOuFalso { get; set; }

        public string Nivel {  get; set; }

        public int Pontuacao { get; set; }

        public string Tema { get; set; }

    }
}
