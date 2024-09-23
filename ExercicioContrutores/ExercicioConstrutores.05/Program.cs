using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioConstrutores._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cronometro cronometro = new Cronometro(15, 15, false);  // Inicializa com 10 segundos
            cronometro.EmExecucao = true;
            cronometro.IniciarContagem();

            Thread.Sleep(5000);  // Espera 5 segundos
            cronometro.Pausar(); // Pausa o cronômetro

            Thread.Sleep(2000);  // Espera 2 segundos
            cronometro.Reiniciar(); // Reinicia o cronômetro

            Console.ReadLine(); // Para manter a aplicação aberta
        }
    }
}
