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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmTelaRanking().ShowDialog();
            this.Show();
        }

        private void btnCadastrarPergunta_Click(object sender, EventArgs e)
        {

            new CadastrarPergunta().ShowDialog();

        }
    }
}
