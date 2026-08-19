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
                 "
                 );
        }

    }
}
