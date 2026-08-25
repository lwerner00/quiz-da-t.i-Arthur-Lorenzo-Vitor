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

