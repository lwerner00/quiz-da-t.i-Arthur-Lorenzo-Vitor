using QuizDaTI.Banco.Repositories;
using QuizDaTI.Modelos;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuizDaTI.Forms
{
    public partial class FrmCriarConta : Form
    {
        public FrmCriarConta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCriarConta_Load(object sender, EventArgs e)
        {

        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            lblErros.Text = "";

            string nome = txtNome.Text;
            string nickname = txtNickName.Text.Trim();
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (senha != confirmarSenha)
            {
                lblErros.Text = "As senhas não coincidem.";
                return;
            }

            if (!DateTime.TryParse(txtDataDeNascimento.Text, out DateTime dataNascimento))
            {
                lblErros.Text = "Data de nascimento inválida.";
                return;
            }

            // 1. Gera o Hash PRIMEIRO
            string hashParaSalvar = BCrypt.Net.BCrypt.HashPassword(senha)
                .Replace("\r", "")
                .Replace("\n", "")
                .Trim();

            // 2. Instancia o Usuário JÁ COM O HASH
            var usuario = new Usuario(nome, nickname, dataNascimento, hashParaSalvar);

            // 3. Validação dos DataAnnotations (valida apenas Nome, Nickname, Data, etc.)
            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();
            var contexto = new ValidationContext(usuario);

            Validator.TryValidateObject(usuario, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.AppendLine(erro.ErrorMessage);
                }
                lblErros.Text = stringBuilder.ToString();
                return;
            }

            // 4. Salva no banco de dados
            await UsuarioRepository.Adicionar(usuario);

            MessageBox.Show("Conta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}