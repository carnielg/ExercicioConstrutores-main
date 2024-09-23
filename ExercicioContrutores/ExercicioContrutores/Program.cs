using ExercicioContrutores.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora(9,3);
            Console.WriteLine(calculadora.Somar());
            Console.WriteLine(calculadora.Subtrair());
            Console.WriteLine(calculadora.Dividir());
            Console.WriteLine(calculadora.Multiplicar());
            Console.ReadKey();

        }
    }
}
