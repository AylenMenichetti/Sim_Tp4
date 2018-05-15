using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simlib
{
    public class RndValor<T>
    {
        public int Random { get;protected set; }
        public T Valor  { get;protected set; }
        public RndValor(int rnd, T valor)
        {
            this.Valor = valor;
            this.Random = rnd;
        }
    }
}
