using Dapper;
using GerenciamentoDeFuncionarios.Banco.Configuracao;
using QuizDaTI.Modelos;

namespace QuizDaTI.Banco.Repositories
{
    public class UsuarioRepository
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();
        public static async Task Adicionar(Usuario usuario)
        {
            //conectar com o banco e inserir funcionario

            await ConexaoBanco.CriarConexao().QueryAsync(
                 @"
                    INSERT INTO Usuario (Nome, Nickname, DataDeNascimento, Senha)
                    VALUES (@Nome, @NickName, @DataDeNascimento, @Senha)

                ",
                 usuario
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
    }
}
