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
    }
}
