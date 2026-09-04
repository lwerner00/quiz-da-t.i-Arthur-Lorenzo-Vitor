using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using QuizDaTI.Forms;
using QuizDaTI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDaTI.Banco.Repositories.Recursos
{
    public class ConquistaRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();

        public static async Task<List<Conquista>> ObterTodas()
        {
            var conquistas = await ConexaoBanco.CriarConexao().QueryAsync<Conquista>(
                @"
                SELECT
                    Id,
                    Nome,
                    Descricao
                FROM Conquista
                ORDER BY Id
                "
            );

            return conquistas.ToList();
        }

        public static async Task<bool> PossuiConquista(int idUsuario, int idConquista)
        {
            var resultado = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<int?>(
                @"
        SELECT Id
        FROM UsuarioConquista
        WHERE IdUsuario = @IdUsuario
        AND IdConquista = @IdConquista
        ",
                new
                {
                    IdUsuario = idUsuario,
                    IdConquista = idConquista
                }
            );

            return resultado.HasValue;
        }

        public static async Task Desbloquear(int idUsuario, int idConquista)
        {
            await ConexaoBanco.CriarConexao().ExecuteAsync(
                @"
        INSERT INTO UsuarioConquista (IdUsuario, IdConquista)
        VALUES (@IdUsuario, @IdConquista)
        ON CONFLICT (IdUsuario, IdConquista) DO NOTHING
        ",
                new
                {
                    IdUsuario = idUsuario,
                    IdConquista = idConquista
                }
            );
        }



    }
}
