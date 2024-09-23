using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutores._06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso: Convertendo de Real para Dólar
            ConversorDeMoeda conversor = new ConversorDeMoeda(100, 5); // 100 Reais, com uma taxa de câmbio de 5.0 (1 Real = 0.20 Dólar)

            double valorConvertido = conversor.ConverterParaDolar();
            Console.WriteLine($"Valor convertido para outra moeda: {valorConvertido}"); // Deve imprimir 500.0 (100 * 5)

            double valorOriginal = conversor.ConverterMoedaOriginal();
            Console.WriteLine($"Valor convertido de volta para a moeda original: {valorOriginal}"); // Deve imprimir 20.0 (100 / 5)

            Console.ReadLine(); // Para manter a aplicação aberta
        }
    }
}
