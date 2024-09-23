using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutores._02
{
    class Palindromo
    {
        // Propriedade que armazena a palavra
        public string Palavra { get; set; }

        // Construtor que inicializa a propriedade Palavra
        public Palindromo(string palavra)
        {
            Palavra = palavra;
        }

        // Método que verifica se a palavra é um palíndromo
        public bool EhPalindromo()
        {
            string palavraLimpa = Palavra.Replace(" ", "").ToLower();
            string palavraInvertida = new string(palavraLimpa.Reverse().ToArray());
            return palavraLimpa == palavraInvertida;
        }
    }
}
