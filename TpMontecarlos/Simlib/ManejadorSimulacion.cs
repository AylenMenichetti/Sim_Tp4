using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Simlib.Tabla_Probabilidades;

namespace Simlib
{
    public class ManejadorSimulacion
    {

        public ManejadorSimulacion()
        {
        }

        public DataTable Simular(int CantSemanas, int filasMostrar, int mostrarDesde, Distribuciones cantautos, Distribuciones tipoAuto, Distribuciones ComisionesAL, Distribuciones ComisionesAM, ref double promtotal, ref string textpromparcial)
        {
            DataTable tabla = new DataTable(); //Tabla que será devuelta
            tabla.Columns.Add("Semana Numero:");
            tabla.Columns.Add("RND Cant Autos");
            tabla.Columns.Add("Cantidad Autos");
            tabla.Columns.Add("RND Tipo Auto");
            tabla.Columns.Add("Tipo Auto");
            tabla.Columns.Add("RND Comision");
            tabla.Columns.Add("Comision");
            tabla.Columns.Add("Comision Total");
            tabla.Columns.Add("Comision Acumulada");
            tabla.Columns.Add("Vendedor");

            var mostrarHasta = mostrarDesde + filasMostrar;
            Random r = new Random();
            double acumtotalvendedor = 0;
            double acum = 0;
            textpromparcial += "Promedio por Semana:\n";
            for (int i = 0; i < 4; i++) //Un bucle por vendedor
            {

                String[] vector = new String[10];
                long vendedor = i + 1;
                double promparcial = 0;
              

                for (int j = 1; j <= CantSemanas; j++)//bucle por semana

                {
                    //        Campos en común------------------------------ -
                    vector[0] = j.ToString();

                    double rndCantAuto = cantautos.GenerarRnd(r);
                    vector[1] = rndCantAuto.ToString();
                    vector[2] = cantautos.ObtenerValorAsociado(rndCantAuto).ToString();
                    String rndComisionTexto = "";
                    String rndtipoAutoTexto = "";
                    String tipoAutoTexto = "";
                    String comisionTexto = "";
                    double ComisionTotal = 0;
                    //Iteraciones por autos (Demanda)
                    for (int k = 0; k < int.Parse(vector[2]); k++)
                    {
                        double rndtipoAuto = tipoAuto.GenerarRnd(r);
                        int tipoaut = (int)tipoAuto.ObtenerValorAsociado(rndtipoAuto);
                        
                        double rndcomision = Math.Truncate(r.NextDouble() * 100);
                        double comision = buscarcomision(tipoaut, rndcomision, ComisionesAL, ComisionesAM);

                        rndtipoAutoTexto += rndtipoAuto.ToString() + Environment.NewLine;
                        tipoAutoTexto += buscarTipo(tipoaut) + Environment.NewLine;
                        rndComisionTexto += (rndtipoAuto.Equals("1") ? " " : rndcomision.ToString())  + Environment.NewLine;
                        comisionTexto += comision + Environment.NewLine;

                        ComisionTotal = ComisionTotal + comision;
                    }

                    vector[3] = rndtipoAutoTexto.ToString();
                    vector[4] = tipoAutoTexto;
                    vector[5] = rndComisionTexto;
                    vector[6] = comisionTexto;
                    vector[7] = ComisionTotal.ToString();
                    vector[8] = string.IsNullOrEmpty(vector[8]) ? vector[7] : (double.Parse(vector[8]) + double.Parse(vector[7])).ToString();
                    vector[9] = vendedor.ToString();

                    if (j >= mostrarDesde && j <= mostrarHasta)
                        tabla.LoadDataRow(vector, true);
                }

                tabla.LoadDataRow(vector, true);


                
                promparcial = double.Parse(vector[8]) / CantSemanas;//acumulado/cantsemanas


                acumtotalvendedor += double.Parse(vector[8]);//suma los acumulados
                textpromparcial += "     Vendedor N°" + (i+1) + ": " + promparcial + "\n";
                acum += promparcial;
            }
            promtotal = acum / 4;
            return tabla;
        }

        public double buscarcomision(int tipo, double rnd, Distribuciones comisionAL, Distribuciones comisionAM)
        {
            switch (tipo)
            {

                case 1:
                    //Auto Compacto
                    return 250;

                case 2:
                    //Auto Mediano
                    return comisionAM.ObtenerValorAsociado(rnd);

                case 3:
                    //Auto De Lujo
                    return comisionAL.ObtenerValorAsociado(rnd);

                default:
                    return 0;

            }
        }

        public string buscarTipo(int tipo)
        {
            switch (tipo)
            {

                case 1:
                    //Auto Compacto
                    return "Compacto(C)";

                case 2:
                    //Auto Mediano
                    return "Auto Mediano(AM)";

                case 3:
                    //Auto De Lujo
                    return "Auto de Lujo(AL)";

                default:
                    return "n";

            }
        }
    }
}
