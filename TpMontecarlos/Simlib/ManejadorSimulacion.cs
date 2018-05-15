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

        private Distribuciones<int> DistCantAutos;
        private Distribuciones<TipoAuto> DistTiposAuto;
        /*private Distribuciones DistComisionesLujo;
        private Distribuciones DistComisionesMediano;*/

        
        public ManejadorSimulacion(Distribuciones<int> CantidadAutos, Distribuciones<TipoAuto> TipoAuto)
        {
            this.DistCantAutos = CantidadAutos;
            this.DistTiposAuto = TipoAuto;
        }

        public DataTable Simular(int CantSemanas, int filasMostrar, int mostrarDesde, ref double promtotal, ref string textpromparcial)
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

            string[] vector = new string[35];

            for (int semana = 1; semana <= CantSemanas; semana++)
            {
                vector[0] = semana.ToString();

                var ven1 = SubVectorVendedor();
                var ven2 = SubVectorVendedor();
                var ven3 = SubVectorVendedor();
                var ven4 = SubVectorVendedor();

                // del 1 al 7
                agregarSubVendedor(ref vector, ref ven1, 1);
                vector[8] = "acum v1";
                
                //del 9 al 15
                agregarSubVendedor(ref vector, ref ven2, 15);
                vector[16] = "acum v2";

                //del 17 al 23
                agregarSubVendedor(ref vector, ref ven3, 17);
                vector[24] = "acum v3";

                //del 25 al 31
                agregarSubVendedor(ref vector, ref ven4, 25);
                vector[31] = "acum v4";

                vector[32] = "total_comisiones";
                vector[33] = "acum total_comisiones";

            }
            //Random r = new Random();
            /*double acumtotalvendedor = 0;
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

                    //vector[1] = rndCantAuto.ToString();
                    //vector[2] = cantautos.ObtenerValorAsociado(rndCantAuto).ToString();
                    String rndComisionTexto = "";
                    String rndtipoAutoTexto = "";
                    String tipoAutoTexto = "";
                    String comisionTexto = "";
                    double ComisionTotal = 0;
                    //Iteraciones por autos (Demanda)
                    for (int k = 0; k < int.Parse(vector[2]); k++)
                    {
                        double rndtipoAuto = tipoAuto.GenerarRnd();
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
            promtotal = acum / 4;*/
            return tabla;
        }

        private String[] SubVectorVendedor()
        {
            String[] subVector = new String[7];
            //Cantidad Auto (Rnd + Nro) - Tipo Autos (Rnd + nro) - Comisiones (Rnd + Nros) - Comision Total Ven

            RndValor<int> demanda = this.DistCantAutos.generar();

            string tipos_rnd_tx = "";
            string tipos_tx = "";
            string comisiones_rnd_tx = "";
            string comisiones_tx = "";
            double comision_total = 0;
            for (int i = 0; i < demanda.Valor; i++)
            {
                var tipo = this.DistTiposAuto.generar();
                tipos_tx += tipo.Valor.Nombre + "\n";
                tipos_rnd_tx += tipo.Random + "\n";
                var comision = tipo.Valor.DistribucionComision.generar();
                comisiones_tx += comision.Valor + "\n";
                comisiones_rnd_tx += comision.Random + "\n";
                comision_total += comision.Valor;
            }

            //Cantidad Auto (Rnd + Nro) - Tipo Autos (Rnd + nro) - Comisiones (Rnd + Nros) - Comision Total Ven
            subVector[0] = demanda.Random.ToString();
            subVector[1] = demanda.Valor.ToString();
            subVector[2] = tipos_rnd_tx;
            subVector[3] = tipos_tx;
            subVector[4] = comisiones_rnd_tx;
            subVector[5] = comisiones_tx;
            subVector[6] = comision_total.ToString();


            return subVector;
        }

        private void agregarSubVendedor(ref string[] vector,ref string[] vendedor, int desde)
        {
            for (int i = 0; i < vendedor.Length; i++)
            {
                vector[desde + i] = vendedor[i];
            }
        }

        /*public double buscarcomision(int tipo, double rnd, Distribuciones comisionAL, Distribuciones comisionAM)
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
        }*/
    }
}
