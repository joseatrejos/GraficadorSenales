using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalSenoidal
    {
        double Amplitud { get; set; }
        double Fase { get; set; }
        double Frecuencia { get; set; }

        public SeñalSenoidal()
        {
            Amplitud = 1;
            Fase = 0;
            Frecuencia = 1;
        }

        public SeñalSenoidal(double amplitud, double fase, double frecuencia) // Los constructores se llaman como la clase
        {                       // Éstas de arriba son variables internas
            Amplitud = amplitud;
            Fase = fase;
            Frecuencia = frecuencia;
        }

        public double evaluar(double tiempo)
        {
            double resultado;

            resultado = Amplitud * Math.Sin((2 * Math.PI * Frecuencia * tiempo) + Fase);

            return resultado;
        }
    }
}
