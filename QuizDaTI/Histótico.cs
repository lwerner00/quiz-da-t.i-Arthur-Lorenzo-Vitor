using QuizDaTI.Banco.Repositories;
using System;
using System.Windows.Forms;



namespace QuizDaTI
{
    public partial class Histótico : Form
    {
        public Histótico()
        {
            InitializeComponent();
            CarregarHistorico();
        }

        private void CarregarHistorico()
        {
            HistoricoRepository repository = new HistoricoRepository();
            dataGridView1.DataSource = repository.BuscarHistorico();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Histótico_Load(object sender, EventArgs e)
        {

        }
    }
}
