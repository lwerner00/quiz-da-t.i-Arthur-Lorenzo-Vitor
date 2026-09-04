using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDaTI.Modelos
{
    public class RankingUsuario
    {
        public int IdUsuario { get; set; }
        public int Posicao { get; set; }
        public string Nickname { get; set; }
        public int PontosTotais { get; set; }

        public int Acertos { get; set; }
        public int PerguntasRespondidas { get; set; }

        public int AcertosConsecutivos { get; set; }

        public string Tema { get; set; }


    }
}
