using Simlib.Tabla_Probabilidades;
namespace Simlib
{
    public class TipoAuto
    {
        public int Numero { get; set; }
        public Distribuciones<double> DistribucionComision { get; set; }
        public string Nombre { get; set; }
        
    }
}
