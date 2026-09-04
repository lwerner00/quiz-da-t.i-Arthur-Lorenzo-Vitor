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

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string nickUsuario = txtNick.Text.Trim();
            string senhaDigitada = txtSenha.Text;

            // Validação de campos vazios
            if (string.IsNullOrWhiteSpace(nickUsuario) || string.IsNullOrWhiteSpace(senhaDigitada))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Login Administrador
            if (nickUsuario == "admin" && senhaDigitada == "1234")
            {
                this.Hide();
                using (var frmAdmin = new FrmAdmin())
                {
                    frmAdmin.ShowDialog();
                }
                this.Show(); // Reexibe o login após fechar a tela de admin
                return;
            }

            // Busca no banco de dados
            usuarioAtual = await UsuarioRepository.ObterPorNickname(nickUsuario);

            if (usuarioAtual == null)
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro ao fazer login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tratamento do hash retornado do banco
            string hashDoBanco = usuarioAtual.Senha?
                .Replace("\r", "")
                .Replace("\n", "")
                .Trim() ?? "";

            // Validação do hash de senha com BCrypt
            bool senhaValida = BCrypt.Net.BCrypt.Verify(senhaDigitada, hashDoBanco);

            if (senhaValida)
            {
                this.Hide();
                using (var frmMenu = new FrmMenuPrincipal(usuarioAtual.Id))
                {
                    frmMenu.ShowDialog();
                }
                this.Close(); // Encerra o formulário de login ao fechar o menu principal
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro ao fazer login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Para trocar a senha sem estar logado, buscamos o usuário pelo texto informado no campo Nick
            string nickUsuario = txtNick.Text.Trim();

            if (string.IsNullOrWhiteSpace(nickUsuario))
            {
                MessageBox.Show("Digite seu NickName para alterar a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var usuario = await UsuarioRepository.ObterPorNickname(nickUsuario);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            using (var frmMudarSenha = new FrmMudarSenha(usuario.Id))
            {
                frmMudarSenha.ShowDialog();
            }
            this.Show(); // Reexibe a tela de login para que o usuário possa logar com a nova senha
        }
    }
}