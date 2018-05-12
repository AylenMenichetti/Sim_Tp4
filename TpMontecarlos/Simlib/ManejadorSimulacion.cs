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

        public DataTable Simular(int CantSemanas, int filasMostrar, int mostrarDesde, Distribuciones cantautos, Distribuciones tipoAuto, Distribuciones ComisionesAL, Distribuciones ComisionesAM,ref double acumtotalvendedor)
        {
            DataTable tabla = new DataTable(); //Tabla que será devuelta
            tabla.Columns.Add("Semana Numero:");
            tabla.Columns.Add("RND");
            tabla.Columns.Add("Cantidad Autos");
            tabla.Columns.Add("RND");
            tabla.Columns.Add("Tipo Auto");
            tabla.Columns.Add("RND");
            tabla.Columns.Add("Comision");
            tabla.Columns.Add("Comision Total");
            tabla.Columns.Add("Comision Acumulada");
            tabla.Columns.Add("Comision Acumulada");

            int totalDias = 0;
            long limite = filasMostrar; //Límite por encima del cual debo empezar a almacenar en la tabla (cant. de renglones)
            
            
            //Intervalos intervalos = new Intervalos(); //Clase que me clasifica por intervalo y me devuelve el valor de la demanda o si pasa el inspector.
            //int totalDias = 0;

            //Random r = new Random();
            String[] vector = new String[9];
          
            for (int i = 0; i <= 4; i++) //Un bucle por vendedor
            {
               long vendedor = i + 1;


                for (int j = 0; j < CantSemanas; j++)//bucle por semana

                {


            //        Campos en común------------------------------ -
                   vector[0] = j.ToString();
                                      
                   double rndCantAuto = cantautos.GenerarRnd();
                   vector[1] = rndCantAuto.ToString();
                   vector[2] = cantautos.ObtenerValorAsociado(rndCantAuto).ToString();
                   String rndtipoAutoTexto = "";
                   String rndComisionTexto = "";
                    String tipoAutoTexto = "";
                   String comisionTexto = "";
                   double ComisionTotal = 0;
                    for (int k = 0; k < int.Parse(vector[2]); k++)
                    {
                        double rndtipoAuto = tipoAuto.GenerarRnd();
                        string tipoaut = tipoAuto.ObtenerValorAsociado(rndtipoAuto).ToString();
                        double rndcomision = new Random().NextDouble();
                        double comision = buscarcomision(tipoaut,rndcomision, ComisionesAL,ComisionesAM);

                        rndtipoAutoTexto += rndtipoAuto.ToString() + "\n";
                        tipoAutoTexto += tipoaut + "\n";
                        rndComisionTexto += rndcomision + "\n";
                        comisionTexto += comision + "\n";

                        ComisionTotal = ComisionTotal + comision;
                    }

                    vector[3] = rndtipoAutoTexto;
                    vector[4] = tipoAutoTexto;
                    vector[5] = rndComisionTexto;
                    vector[6] = comisionTexto;
                    vector[7] = ComisionTotal.ToString();
                    vector[8] = vector[7] +ComisionTotal.ToString();
                    vector[9] = vendedor.ToString();
                    totalDias++;
                }
                if (totalDias >= mostrarDesde && totalDias <= mostrarDesde + filasMostrar )
                    tabla.LoadDataRow(vector, true);

                if (totalDias == CantSemanas)
                {   tabla.LoadDataRow(vector, true);
                    acumtotalvendedor += double.Parse(vector[8]);
                }




            }
            
            return tabla;
        }

        public double buscarcomision(string tipo,double rnd,Distribuciones comisionAL, Distribuciones comisionAM) {
            switch (tipo)
            {
                case "C":
                    return 250;
                case "AM":
                
                    return comisionAM.ObtenerValorAsociado(rnd);
                case "AL":
                   
                    return comisionAL.ObtenerValorAsociado(rnd);
                    
                default:
                    return 0;
                   
            }
        }


    }
}
