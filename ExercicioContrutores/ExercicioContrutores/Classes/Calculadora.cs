using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContrutores.Classes
{
    class Calculadora
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public Calculadora(int numero1, int numero2)
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;
        }
        public string Somar()
        {
            int soma = Numero1+Numero2;
            return $"{Numero1} + {Numero2} = {soma}";
        }
        public string Subtrair()
        {
            int subtrair = Numero1 - Numero2;
            return $"{Numero1} - {Numero2} = {subtrair}";
        }
        public string Multiplicar()
        {
            int multiplicar = Numero1 * Numero2;
            return $"{Numero1} * {Numero2} = {multiplicar}";
        }
        public string Dividir()
        {
            int dividir = Numero1 / Numero2;
            return $"{Numero1} / {Numero2} = {dividir}";
        }

    }
}
