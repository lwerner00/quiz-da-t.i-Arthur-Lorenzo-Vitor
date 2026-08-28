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

            await conexaoBanco.CriarConexao().QueryAsync(
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
            return await conexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Usuario>(
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
            return await conexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Usuario>(
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

        public static async Task AdicionarPontos(int pontos, int id)
        {
            using (var conexao = conexaoBanco.CriarConexao())
            {
                await conexao.ExecuteAsync(
                    @"
                UPDATE Usuario 
                SET PontuacaoTotal = PontuacaoTotal + @Pontos 
                WHERE Id = @Id;
            ",
                    new { Pontos = pontos, Id = id }
                );
            }
        }


        public static async Task<bool> PodeJogarHoje(int idUsuario)
        {
            using (var conexao = conexaoBanco.CriarConexao())
            {
                var dataUltimoQuiz = await conexao.QueryFirstOrDefaultAsync<DateTime?>(@"
            SELECT DataUltimoQuiz
            FROM Usuario
            WHERE Id = @Id
        ", new { Id = idUsuario });

                if (!dataUltimoQuiz.HasValue || dataUltimoQuiz.Value.Date < DateTime.Today)
                {
                    return true;
                }

                return false;
            }
        }


        public static async Task RegistrarJogada(int idUsuario)
        {
            using (var conexao = conexaoBanco.CriarConexao())
            {
                await conexao.ExecuteAsync(@"
            UPDATE Usuario
            SET DataUltimoQuiz = @Agora
            WHERE Id = @Id
        ", 
                new
        {       Agora = DateTime.Now, Id = idUsuario });
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
                        AcertoOuErrou,
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
                using var conexao = new ConexaoBanco().CriarConexao();

                string sql = @"
        INSERT INTO Historico
        (DataEHora, IdPergunta, TemaPergunta, AcertoOuErro, PontosGanhos)
        VALUES
        (@DataEHora, @IdPergunta, @TemaPergunta, @AcertoOuErro, @PontosGanhos);
    ";

                await conexao.ExecuteAsync(sql, new
                {
                    DataHora = DateTime.Now,
                    IdPergunta = idPergunta,
                    TemaPergunta = temaPergunta,
                    AcertoOuErro = acertoOuErro,
                    PontosGanhos = pontosGanhos
                });
            }




        }  
    

}

