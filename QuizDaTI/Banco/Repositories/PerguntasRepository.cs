using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using QuizDaTI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDaTI.Banco.Repositories
{
    public class PerguntasRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();

        internal static async Task<Pergunta> ObterPerguntas()
        {
            return await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Pergunta>(
                  @"
                    SELECT *
                    FROM Pergunta
                    ORDER BY RANDOM()
                    LIMIT 10
                 "
                 );
        }

        public static async Task ResponderPergunta(string resposta, int id)
        {
            await ConexaoBanco.CriarConexao().ExecuteAsync(
                 @"
                    UPDATE Pergunta
                    SET Resposta = @Resposta
                    WHERE Id = @Id;
                ",
                    new 
                    { Resposta = resposta, Id = id }
                 );
        }

        public static async Task<List<Pergunta>> ObterUltimasRespondidas()
        {
            using var conexao = ConexaoBanco.CriarConexao();

            string sql = @"
                SELECT * FROM Pergunta
                WHERE Resposta IS NOT NULL
                ORDER BY Id DESC
                LIMIT 10;
    ";

            var resultado = await conexao.QueryAsync<Pergunta>(sql);
            return resultado.ToList();
        }

        public static async Task LimparResposta()
        {
            await ConexaoBanco.CriarConexao().ExecuteAsync(
                 @"
                    UPDATE Pergunta
                    SET Resposta = NULL;
                "
                 );
        }

        public static async Task<int> SomarPontuacao()
        {
            return await ConexaoBanco.CriarConexao().ExecuteScalarAsync<int>(
                @"
            SELECT COALESCE(SUM(Pontuacao), 0) AS TotalUltimas10
            FROM (
                SELECT Pontuacao
                FROM Pergunta
                WHERE resposta = 'Correta'
                LIMIT 10
            ) AS ultimas_perguntas;
                 "
            );
        }

        public static async Task<bool> VerificarTresAcertosSeguidos()
        {
            using (var conexao = ConexaoBanco.CriarConexao())
            {
                return await conexao.ExecuteScalarAsync<bool>(@"
            SELECT COUNT(*) = 3
            FROM (
                SELECT resposta
                FROM Pergunta
                ORDER BY Id DESC
                LIMIT 3
            ) AS ultimas
            WHERE resposta = 'correta';
        ");
            }
        }


        public static async Task<bool> VerificarCincoAcertosSeguidos()
        {
            using (var conexao = ConexaoBanco.CriarConexao())
            {
                return await conexao.ExecuteScalarAsync<bool>(@"
            SELECT COUNT(*) = 5
            FROM (
                SELECT resposta
                FROM Pergunta
                ORDER BY Id DESC
                LIMIT 5
            ) AS ultimas
            WHERE resposta = 'correta';
        ");
            }
        }



        public static async Task Adicionar(Pergunta pergunta)
        {

            await ConexaoBanco.CriarConexao().QueryAsync(
                 @"
                    INSERT INTO Pergunta (Enunciado, Tipo, AlternativaCorreta, AlternativaIncorreta1, AlternativaIncorreta2, AlternativaIncorreta3, VerdadeiroOuFalso, Nivel, Pontuacao, Tema)
                    VALUES (@Enunciado, @Tipo, @AlternativaCorreta, @AlternativaIncorreta1, @AlternativaIncorreta2, @AlternativaIncorreta3, @VerdadeiroOuFalso, @Nivel, @Pontuacao, @Tema)

                ",
                 new
                 {
                        pergunta.Enunciado,
                        pergunta.Tipo,
                        pergunta.AlternativaCorreta,
                        pergunta.AlternativaIncorreta1,
                        pergunta.AlternativaIncorreta2,
                        pergunta.AlternativaIncorreta3,
                        pergunta.VerdadeiroOuFalso,
                        pergunta.Nivel,
                        pergunta.Pontuacao,
                        pergunta.Tema
                 }

                 );
        }



    }
}
