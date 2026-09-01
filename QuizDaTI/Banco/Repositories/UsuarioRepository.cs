using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using Npgsql;
using QuizDaTI.Modelos;
using System.Data;
using System;


namespace QuizDaTI.Banco.Repositories
{
    public class UsuarioRepository
    {
        private static ConexaoBanco conexaoBanco = new ConexaoBanco();
        public static async Task Adicionar(Usuario usuario)
        {
            string senhaHash = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

            await ConexaoBanco.CriarConexao().QueryAsync(
                 @"
                    INSERT INTO Usuario (Nome, Nickname, DataDeNascimento, Senha)
                    VALUES (@Nome, @NickName, @DataDeNascimento, @Senha)

                ",
                 new
                 {
                     usuario.Nome,
                     usuario.NickName,
                     usuario.DataDeNascimento,
                     Senha = senhaHash
                 }
                
                 );
        }


        internal static async Task<Usuario> ObterPorNickname(string nickUsuario)
        {
            return await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Usuario>(
                  @"
                    SELECT *
                    FROM Usuario
                    WHERE Nickname = @Nickname
                 ",
                  new
                  {
                      Nickname = nickUsuario
                  }
                 );

        }

        internal static async Task<Usuario> ObterPorId(int IdUsuarioAtual)
        {
            return await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Usuario>(
                  @"
                    SELECT *
                    FROM Usuario
                    WHERE Id = @IdUsuario
                 ",

                  new
                  {
                      IdUsuario = IdUsuarioAtual
                  }
                 );
        }

        public static async Task AdicionarPontos(int idUsuario, int pontos)
        {
            using (var conexao = ConexaoBanco.CriarConexao())
            {
                await conexao.ExecuteAsync(
                    @"
                UPDATE Usuario
                SET PontuacaoTotal = COALESCE(PontuacaoTotal, 0) + @Pontos
                WHERE Id = @IdUsuario;
            ",
                    new
                    {
                        Pontos = pontos,
                        IdUsuario = idUsuario
                    }
                );
            }
        }


        public static async Task<bool> PodeJogarHoje(int idUsuario)
        {
            using (var conexao = ConexaoBanco.CriarConexao())
            {
                // Busca a data em que o usuário jogou pela última vez
                var dataUltimoQuiz = await conexao.QueryFirstOrDefaultAsync<DateTime?>(@"
            SELECT DataUltimoQuiz
            FROM Usuario
            WHERE Id = @Id
        ", new { Id = idUsuario });

                // Se nunca jogou (null) OU a data for anterior a hoje, está liberado!
                if (!dataUltimoQuiz.HasValue || dataUltimoQuiz.Value.Date < DateTime.Today)
                {
                    return true;
                }

                return false; // Já jogou hoje
            }
        }

        internal static async Task RegistrarJogada(object idUsuario)
        {
            using (var conexao = ConexaoBanco.CriarConexao())
            {
                await conexao.ExecuteAsync(@"
            UPDATE Usuario
            SET DataUltimoQuiz = @Agora
            WHERE Id = @Id
        ", new { Agora = DateTime.Now, Id = idUsuario });
            }
        }
    }


    
        public class HistoricoRepository
        {
            private readonly string conexao =
                "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=admin;";
            
            public DataTable BuscarHistorico()
            {
                DataTable tabela = new DataTable();

                using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
                {
                    conn.Open();

                    string sql = @"
                    SELECT
                        Id,
                        DataEHora,
                        IdPergunta,
                        TemaPergunta,
                        AcertoOuErro,
                        PontosGanhos
                    FROM Historico
                    ORDER BY DataEHora DESC;
                ";

                    using (NpgsqlDataAdapter adapter =
                           new NpgsqlDataAdapter(sql, conn))
                    {
                        adapter.Fill(tabela);
                    }
                }

                return tabela;
            }

            public async Task SalvarHistorico(
       int idPergunta,
       string temaPergunta,
       bool acertoOuErro,
       int pontosGanhos)
            {
                using var conexao = ConexaoBanco.CriarConexao();

                string sql = @"
        INSERT INTO Historico
        ( DataEHora, IdPergunta, TemaPergunta, AcertoOuErro, PontosGanhos)
        VALUES
        (@DataEHora, @IdPergunta, @TemaPergunta, @AcertoOuErro, @PontosGanhos);
    ";

                await conexao.ExecuteAsync(sql, new
                {
                    DataEHora = DateTime.Now,
                    IdPergunta = idPergunta,
                    TemaPergunta = temaPergunta,
                    AcertoOuErro = acertoOuErro,
                    PontosGanhos = pontosGanhos
                });
            }




        }  
    

}
