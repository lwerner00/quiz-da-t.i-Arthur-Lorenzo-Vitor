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
    public partial class FrmLogin : Form
    {

        private Usuario usuarioAtual;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtNick_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string nickUsuario = txtNick.Text;

            usuarioAtual = await UsuarioRepository.ObterPorNickname(nickUsuario);

            string senhaDigita = txtSenha.Text;
            string hashDoBanco = usuarioAtual.Senha;

            bool senhaValida = BCrypt.Net.BCrypt.Verify(senhaDigita, hashDoBanco);

            if (txtNick.Text == "admin" && txtSenha.Text == "1234")
            {
                this.Hide();
                new FrmAdmin().ShowDialog();
            }
            else if (txtNick.Text == usuarioAtual.NickName && senhaValida)
            {

            }
            else
            {
                MessageBox.Show("NickName ou senha incorretas.",
                 "Erro ao fazer login",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
