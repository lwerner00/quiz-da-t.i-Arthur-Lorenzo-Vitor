using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using Npgsql;
using QuizDaTI.Banco.Repositories.QuizDaTI.Repositories;

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
            throw new NotImplementedException();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


    public partial class Historico : Form
    {
        //    public Historico()
        //    {
        //    InitializeComponent();
        //        CarregarHistorico();
        //    }


        //    private void CarregarHistorico()
        //    {
        //        HistoricoRepository repository = new HistoricoRepository();

        //    dataGridView1.DataSource = repository.BuscarHistorico();
        //    }
        //}





    }

}



//public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//{

//}


