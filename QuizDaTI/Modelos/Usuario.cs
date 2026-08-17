using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDaTI.Modelos
{
    public class Usuario
    {
        public Usuario(string nome, string nickName, DateTime dataDeNascimento, string senha)
        {
            Nome = nome;
            NickName = nickName;
            DataDeNascimento = dataDeNascimento;
            Senha = senha;
        }

        public Usuario()
        {

        }

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O campo 'Nome' deve ter entre 3 caracteres e 255.")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "O campo 'NickName' é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O campo 'Nickname' deve ter entre 3 caracteres e 255.")]
        public string NickName { get; private set; }

        [Required(ErrorMessage = "O campo 'Data de nascimento' é obrigatório.")]
        public DateTime DataDeNascimento { get; private set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório.")]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "O campo 'Senha' deve ter mais de 6 caracteres.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$",
        ErrorMessage = "A senha deve conter pelo menos 1 letra maiúscula, 1 letra minúscula, 1 número e 1 caractere especial.")]
        public string Senha { get; private set; }


    }
}
