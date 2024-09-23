using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutores._03
{
    class Senha
    {
        public string Valor { get; set; }

        public Senha(string valor)
        {
            this.Valor = valor;
        }

        public string VerificarForcaSenha()
        {
            if (Valor.Length < 8)
                return "Senha fraca: deve ter pelo menos 8 caracteres.";

            if (!Valor.Any(char.IsUpper))
                return "Senha fraca: deve conter pelo menos uma letra maiúscula.";

            if (!Valor.Any(char.IsLower))
                return "Senha fraca: deve conter pelo menos uma letra minúscula.";

            if (!Valor.Any(char.IsDigit))
                return "Senha fraca: deve conter pelo menos um número.";

            return "Senha forte.";
        }
    }
}
