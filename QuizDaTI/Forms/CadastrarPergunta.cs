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
    public partial class CadastrarPergunta : Form
    {
        public CadastrarPergunta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string Enunciado = txtEnunciado.Text;
            string Tipo = cbTipo.Text;
            string AlternativaCorreta = txtAlternativaCorreta.Text;
            string AlternativaIncorreta1 = txtAlternativaIncorreta1.Text;
            string AlternativaIncorreta2 = txtAlternativaIncorreta2.Text;
            string AlternativaIncorreta3 = txtAlternativaIncorreta3.Text;
            string Nivel = cbNivel.Text;
            string Tema = cbTema.Text;
            int Pontuacao;
            bool VerdadeiroOuFalso;
            if (Nivel == "Iniciante")
            {
                Pontuacao = 10;
            }
            else if (Nivel == "Fácil")
            {
                Pontuacao = 20;
            }
            else if (Nivel == "Intermediário")
            {
                Pontuacao = 30;
            }
            else
            {
                Pontuacao = 50;
            }

            if (Tipo == "VerdadeiroOuFalso")
            {
                VerdadeiroOuFalso = true;
            }
            else
            {
                VerdadeiroOuFalso = false;
            }


            var pergunta = new Pergunta(Enunciado,
                Tipo,
                AlternativaCorreta,
                AlternativaIncorreta1,
                AlternativaIncorreta2,
                AlternativaIncorreta3,
                VerdadeiroOuFalso,
                Nivel,
                Pontuacao,
                Tema);

            await PerguntasRepository.Adicionar(pergunta);
            MessageBox.Show("Pergunta adicionada com sucesso!",
 "Sucesso",
 MessageBoxButtons.OK,
 MessageBoxIcon.Exclamation);
            this.Close();

        }

        private void txtAlternativaIncorreta3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarPergunta_Load(object sender, EventArgs e)
        {

        }
    }
}
