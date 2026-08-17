using QuizDaTI.Banco.Repositories;
using QuizDaTI.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string Nome = txtNome.Text;
            string Nickname = txtNickName.Text;
            DateTime DataDeNascimento = DateTime.Parse(txtDataDeNascimento.Text);
            string Senha = txtSenha.Text;
            string hashParaSalvarNoBanco = BCrypt.Net.BCrypt.HashPassword(Senha);
            string ConfirmarSenha = txtConfirmarSenha.Text;
            var usuario = new Usuario(Nome, Nickname, DataDeNascimento, hashParaSalvarNoBanco);

            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            var contexto = new ValidationContext(usuario);
            Validator.TryValidateObject(usuario, contexto, listaDeErros, true);

            if (listaDeErros.Count > 0)
            {
                // adiciona os erros stringBuilder e exibe na tela
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                    //"o campo tal é obrigatorio"
                    //"o campo outro tal é obrigatorio"
                }
                lblErros.Text = stringBuilder.ToString();
            }
            else
            {
                await UsuarioRepository.Adicionar(usuario);
                this.Close();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
