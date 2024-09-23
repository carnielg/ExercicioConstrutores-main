using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutores._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura(27.00);

            Console.WriteLine(temperatura.ConversorUnidade());
            Console.ReadKey();

        }
    }
}
