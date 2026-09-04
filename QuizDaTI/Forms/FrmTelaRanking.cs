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
    public partial class FrmTelaRanking : Form
    {
        public FrmTelaRanking()
        {
            InitializeComponent();

            ConfigurarTabela();

            Load += FrmTelaRanking_Load;
        }

        private async void FrmTelaRanking_Load(object? sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        private void ConfigurarTabela()
        {
            dgvRankingJogadores.Columns.Clear();

            dgvRankingJogadores.Columns.Add(
                "Posicao",
                "Posição"
            );

            dgvRankingJogadores.Columns.Add(
                "Nickname",
                "Nickname"
            );

            dgvRankingJogadores.Columns.Add(
                "PontosTotais",
                "Pontos Totais"
            );

            dgvRankingJogadores.Columns.Add(
                "Acertos",
                "Acertos"
            );

            dgvRankingJogadores.Columns.Add(
                "PerguntasRespondidas",
                "Perguntas Respondidas"
            );

            dgvRankingJogadores.Columns.Add(
                "Tema",
                "Tema"
            );

            dgvRankingJogadores.Columns.Add(
                "AcertosConsecutivos",
                "Acertos Consecutivos"
            );

            dgvRankingJogadores.AutoGenerateColumns = false;
        }

        private async Task AtualizarTabela()
        {
            try
            {
                var ranking = await UsuarioRepository.ObterRanking();

                dgvRankingJogadores.Rows.Clear();

                int posicao = 1;

                foreach (var jogador in ranking)
                {
                    dgvRankingJogadores.Rows.Add(
                        posicao,
                        jogador.Nickname,
                        jogador.PontosTotais,
                        jogador.Acertos,
                        jogador.PerguntasRespondidas,
                        jogador.Tema,
                        jogador.AcertosConsecutivos
                    );

                    posicao++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar o ranking:\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtProcurarJogador.Text.Trim();

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                await AtualizarTabela();
                return;
            }

            var ranking = await UsuarioRepository.ObterRanking();

            var jogadoresEncontrados = ranking
                .Where(j => j.Nickname.Contains(
                    pesquisa,
                    StringComparison.OrdinalIgnoreCase
                ))
                .ToList();

            dgvRankingJogadores.Rows.Clear();

            int posicao = 1;

            foreach (var jogador in jogadoresEncontrados)
            {
                dgvRankingJogadores.Rows.Add(
                    posicao,
                    jogador.Nickname,
                    jogador.PontosTotais,
                    jogador.Acertos,
                    jogador.PerguntasRespondidas,
                    jogador.Tema,
                    jogador.AcertosConsecutivos
                );

                posicao++;
            }

            if (jogadoresEncontrados.Count == 0)
            {
                MessageBox.Show(
                    "Nenhum jogador encontrado.",
                    "Pesquisa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private async void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProcurarJogador.Clear();

            await AtualizarTabela();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string jogadores = (string)dgvRankingJogadores.SelectedRows[0].Cells[0].Value;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnVerPerfil_ClickAsync(object sender, EventArgs e)
        {
            if (dgvRankingJogadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um jogador.");
                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvRankingJogadores.SelectedRows[0].Cells["IdUsuario"].Value
            );

            Usuario usuario = await UsuarioRepository.ObterPorId(idUsuario);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado.");
                return;
            }


            FrmTelaPerfilUsuario frm = new FrmTelaPerfilUsuario(usuario);

            frm.ShowDialog();
        }

        private void dgvRankingJogadores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRankingJogadores.SelectedRows.Count > 0)
            {
                btnVerPerfil.Visible = true;
            }
            else
            {
                btnVerPerfil.Visible = false;
            }
        }


    }
}

