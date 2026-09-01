using QuizDaTI.Banco.Repositories;
using System.Data;

namespace QuizDaTI.Forms
{
    public partial class FrmHistorico : Form
    {
        private HistoricoRepository historicoRepository = new HistoricoRepository();
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            CarregarHistorico();
        }



        private void CarregarHistorico()
        {
            try
            {
                DataTable tabela = historicoRepository.BuscarHistorico();

                dgvHistorico.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar histórico: " + ex.Message);
            }
        }




        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

}