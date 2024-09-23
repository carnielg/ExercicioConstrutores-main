using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercicioConstrutores._05
{
    class Cronometro
    {
        public int TempoInicial { get; set; }
        public int TempoAtual { get; set; }
        public bool EmExecucao { get; set; }  // Mudei para bool para refletir melhor se está em execução ou não

        public Cronometro(int tempoInicial, int tempoAtual, bool emExecucao)
        {
            this.TempoInicial = tempoInicial;
            this.TempoAtual = tempoAtual;
            this.EmExecucao = emExecucao;
        }

        public void IniciarContagem()
        {
            for (int i = TempoAtual; i >= 0; i--)
            {
                if (!EmExecucao)
                    break;

                TempoAtual = i;
                Console.WriteLine($"Tempo restante: {TempoAtual} segundos");
                Thread.Sleep(1000);
            }

            if (TempoAtual == 0)
            {
                Console.WriteLine("Tempo esgotado!");
                EmExecucao = false;
            }
        }

        public void Pausar()
        {
            EmExecucao = false;
        }

        public void Reiniciar()
        {
            Pausar();
            TempoAtual = TempoInicial;
            EmExecucao = true;
            IniciarContagem();
            
        }
        


    }
}
