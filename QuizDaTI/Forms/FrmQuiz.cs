namespace QuizDaTI.Forms
{
    public partial class FrmQuiz : Form
    {
        public FrmQuiz()
        {
            InitializeComponent();
        }

        private void btnAlternativa1_Click(object sender, EventArgs e)
        {
            
            int pontuacaoTotal = 0;

           
            int sequenciaAcertos = 0;


            
            void ResponderPergunta(bool acertou, int pontosDaPergunta)
            {
                
                if (!acertou)
                {
                    
                    sequenciaAcertos = 0;
                    return;
                }

               
                decimal pontosGanhos = pontosDaPergunta;

                
                if (sequenciaAcertos == 5)
                {
                    pontosGanhos = pontosDaPergunta * 1.20m;
                }
             
                else if (sequenciaAcertos == 3)
                {
                    pontosGanhos = pontosDaPergunta * 1.10m;
                }

               
                pontuacaoTotal += (int)pontosGanhos;

              
                sequenciaAcertos++;
            }
        }
    }
}
