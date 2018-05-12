using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simlib.Tabla_Probabilidades
{
    public class Probabilidades
    {
        public int ValorAsociado { get; set; }
        public double ProbabilidadAsociada { get; set; }

        public Probabilidades(int Valor, double probabilidad)
        { 
            ValorAsociado = Valor;
            ProbabilidadAsociada = probabilidad;
        }

    }
}
