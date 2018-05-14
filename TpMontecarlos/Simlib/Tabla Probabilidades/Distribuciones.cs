using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Simlib.Tabla_Probabilidades
{
    public class Distribuciones
    {
        public List<Probabilidades> Valores { get; set; }
        public List<double> intervaloHasta { get; set; }

        public Distribuciones(List<Probabilidades> Valores)
        {
            this.Valores = Valores ?? new List<Probabilidades>();

            GenerarTabla();
        }
        //genera rnd
        public double GenerarRnd(Random rnd)
        {
            var random = rnd.NextDouble();
            random=Math.Truncate(random*100);
            return random;
        }

        //apartir del rnd, devuelve el valor asociado
        public double ObtenerValorAsociado(double rnd)
        {
            
            for (var i = 1; i < intervaloHasta.Count; i++)
            {
                if (rnd < intervaloHasta[i])
                    return Valores[i - 1].ValorAsociado;
            }

            return Valores.Last().ValorAsociado;
        }


        //Genera la tabla con los intervalos
        private void GenerarTabla()
        {   //ordena las p(x)
            Valores = Valores.OrderBy(v => v.ValorAsociado).ToList();

            intervaloHasta = new List<double> { 0 };

            //setea los intervalos
            for (var i = 1; i < Valores.Count; i++)
            {
                intervaloHasta.Add(intervaloHasta[i - 1] + Valores[i - 1].ProbabilidadAsociada);
            }
        }


    }
}
