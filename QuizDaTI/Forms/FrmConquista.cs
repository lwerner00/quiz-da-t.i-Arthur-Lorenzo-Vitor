using QuizDaTI.Banco.Repositories.Recursos;
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
    public partial class FrmConquista : Form
    {
        private int IdUsuario;

        public FrmConquista(int idUsuario)
        {
            InitializeComponent();

            IdUsuario = idUsuario;

            Load += FrmConquista_Load;
            AutoScroll = true;
        }

        private async void FrmConquista_Load(object? sender, EventArgs e)
        {


            await CarregarConquistas();
        }

        private async Task CarregarConquistas()
        {
            var conquistas = await ConquistaRepository.ObterTodas();



            int posicaoY = 30;

            foreach (var conquista in conquistas)
            {
                Label lblNome = new Label();

                lblNome.Text = conquista.Nome;
                lblNome.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblNome.AutoSize = true;
                lblNome.Location = new Point(30, posicaoY);

                Controls.Add(lblNome);

                posicaoY += 60;
            }
        }
    }
}
