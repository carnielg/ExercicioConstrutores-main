using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutores._03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Senha senha = new Senha("rob");
            string verificar = senha.VerificarForcaSenha();
            Console.WriteLine(verificar);
            Console.ReadKey();

            
        }
    }
}
