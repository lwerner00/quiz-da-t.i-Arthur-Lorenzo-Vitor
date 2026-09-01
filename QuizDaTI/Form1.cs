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

namespace QuizDaTI
{
    public partial class FrmMudarSenha : Form
    {
        private int idUsuario;
        public FrmMudarSenha(int id)
        {
            InitializeComponent();
            idUsuario = id;
        }

        private async void btnMudarSenha_Click(object sender, EventArgs e)
        {
           
            
                string senhaAtual = txtSenhaAtual.Text;
                string novaSenha = txtNovaSenha.Text;
                string confirmarSenha = txtConfirmarSenha.Text;
         

                if (string.IsNullOrWhiteSpace(senhaAtual) ||
                    string.IsNullOrWhiteSpace(novaSenha) ||
                    string.IsNullOrWhiteSpace(confirmarSenha))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }

                if (novaSenha != confirmarSenha)
                {
                    MessageBox.Show("As novas senhas não coincidem.");
                    return;
                }

                var usuario = await UsuarioRepository.ObterPorId(idUsuario);

                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                bool senhaValida = BCrypt.Net.BCrypt.Verify(
                    senhaAtual,
                    usuario.Senha
                );

                if (!senhaValida)
                {
                    MessageBox.Show("A senha atual está incorreta.");
                    return;
                }

                bool atualizou = await UsuarioRepository.AtualizarSenha(
                    idUsuario,  
                    novaSenha
                );

                if (atualizou)
                {
                    MessageBox.Show("Senha alterada com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar a senha.");
                }
            
        }
    }
}
