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
            // Usando using para garantir que a conexão será fechada corretamente
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



    }
}
