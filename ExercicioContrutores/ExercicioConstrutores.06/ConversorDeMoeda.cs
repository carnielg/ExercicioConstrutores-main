using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutores._06
{
    class ConversorDeMoeda
    {
        public double Valor { get; set; }
        public double TaxaDeCambio { get; set; }

        public ConversorDeMoeda(double Valor, double TaxaDeCambio)
        {
            this.Valor = Valor;
            this.TaxaDeCambio = TaxaDeCambio;
        }

        public double ConverterParaDolar()
        {
            return Valor * TaxaDeCambio;
        }
        public double ConverterMoedaOriginal()
        {
            return Valor / TaxaDeCambio;
        }
    }
}
