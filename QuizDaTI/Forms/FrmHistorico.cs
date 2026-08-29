using QuizDaTI.Banco.Repositories;
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
    public partial class FrmHistorico : Form
    {
        private HistoricoRepository historicoRepository = new HistoricoRepository();
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
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
