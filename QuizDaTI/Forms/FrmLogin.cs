using QuizDaTI.Banco.Repositories;
using QuizDaTI.Modelos;

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
            string senhaDigita = txtSenha.Text;

            if (txtNick.Text == "admin" && txtSenha.Text == "1234")
            {
                this.Hide();
                new FrmAdmin().ShowDialog();
                return;
            }

            usuarioAtual = await UsuarioRepository.ObterPorNickname(nickUsuario);
            string hashDoBanco = usuarioAtual.Senha;
            bool senhaValida = BCrypt.Net.BCrypt.Verify(senhaDigita, hashDoBanco);

            if (txtNick.Text == usuarioAtual.NickName && senhaValida)
            {
                this.Hide();
                this.Close();
                new FrmMenuPrincipal(usuarioAtual.Id).ShowDialog();
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
