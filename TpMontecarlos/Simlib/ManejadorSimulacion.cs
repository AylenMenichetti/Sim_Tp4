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

        public DataTable Simular(int CantSemanas, int filasMostrar, int mostrarDesde, Distribuciones cantautos, Distribuciones tipoAuto, Distribuciones ComisionesAL, Distribuciones ComisionesAM)
        {
            DataTable tabla = new DataTable(); //Tabla que será devuelta
            tabla.Columns.Add("Semana Numero:");
            tabla.Columns.Add("Día");
            tabla.Columns.Add("RND");
            tabla.Columns.Add("Cantidad Autos");
            tabla.Columns.Add("RND");
            tabla.Columns.Add("Tipo Auto");
            tabla.Columns.Add("RND");
            tabla.Columns.Add("Comision");
            tabla.Columns.Add("Comision Total");
            tabla.Columns.Add("Comision Acumulada");
         

            long limite = ((CantSemanas * 7) - filasMostrar); //Límite por encima del cual debo empezar a almacenar en la tabla (cant. de renglones)
            
            
            //Intervalos intervalos = new Intervalos(); //Clase que me clasifica por intervalo y me devuelve el valor de la demanda o si pasa el inspector.
            //int totalDias = 0;

            //Random r = new Random();
            String[] vector = new String[9];

            for (int i = 0; i < CantSemanas; i++) //una semana por bucle
            {
               long nroSemana = i + 1;

            //    /* Vector con 15 posiciones:
            //     * 0 - Numero de semana: 1,2,3... n indica el numero de semana
            //     * 1 - Dias de la semana: 1,2,3 ... 7 es el dia de la respectiva semana
            //     * 2 - RND Demanda: [0,1] y es el random perteneciente a la semana
            //     * 3 - Demanda: 10,20,25 ... 100 según los intervalos y el RND anterior
            //     * 4 - RND Inspector: [0,1] sirve para conocer si hubo inspección
            //     * 5 - Inspector /pago: SI,NO es para saber si se paga multa ($300)
            //     * 6 - Diferencia fab-dem: + si fab>dem y - si fab<dem
            //     * 7 - Acum tortas no surtidas: acumula todas las tortas no fabricadas pero si demandadas (fab-dem<0)
            //     * 8 - Acum tortas tiradas: acumula todas las tortas fabricadas que no se vendieron (fab-dem>0)
            //     * 9 - Costo Fabricación: Cantidad de tortas * costo fabricación (50*10 = 500)
            //     * 10- Costo multa: $300 si la columna "Inspector /pago" es "SI"
            //     * 11- Costo permiso: $200 semanales 
            //     * 12- Venta: Cantidad de tortas vendidas por el precio (tener en cuenta la dif. fab-dem)
            //     * 13- Utilidad acum s/perm: Acumulado de utilidad sin pagar el permiso (Venta - C.multa - C.Fabricacion)
            //     * 14- Utilidad acum c/perm: Acumulado de utilidad pagando el permiso (Venta - C.perm - C.fabricacion)
            //     */

               for (int j = 0; j < 7; j++) //Un dia por bucle                    MODIFICAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAR A 7 DIAS
               {


            //        Campos en común------------------------------ -
                   vector[0] = nroSemana.ToString();
                   vector[1] = (j + 1).ToString();
                   
                  double rndCantAuto = cantautos.GenerarRnd();
                  vector[2] = rndCantAuto.ToString();
                  vector[3] = cantautos.ObtenerValorAsociado(rndCantAuto).ToString();
                    String rndtipoAutoTexto = "";
                    String tipoAutoTexto = "";
                    for (int k = 0; k < int.Parse(vector[3]); k++)
                    {
                        double rndtipoAuto = tipoAuto.GenerarRnd();
                        rndtipoAutoTexto += rndtipoAuto.ToString() + "\n";
                        tipoAutoTexto += tipoAuto.ObtenerValorAsociado(rndtipoAuto).ToString()+"\n";
                        //if ()
                        //{

                        //}
                    }

                    vector[4] = rndtipoAutoTexto;
                    vector[5] = tipoAutoTexto;
                    double rndComision = cantautos.GenerarRnd();
                    vector[6] = rndCantAuto.ToString();
                    vector[7] = cantautos.ObtenerValorAsociado(rndCantAuto).ToString();

                    //        double rndMulta = r.NextDouble();
                    //        vector[4] = rndMulta.ToString();
                    //        vector[5] = intervalos.pagoMulta(rndMulta);

                    //        int fabDem = prodDiaria - int.Parse(vector[3].ToString());
                    //        vector[6] = fabDem.ToString();

                    //        vector[12] = (prodDiaria * precioVenta).ToString(); //Vendió todo lo producido si no es así entra en el if;
                    //        vector[9] = (prodDiaria * costoFabricacion).ToString();

                    //        if (vector[5].ToString().Equals("SI"))//Si cobraron multa o no
                    //            vector[10] = costoMulta.ToString();
                    //        else
                    //            vector[10] = "0";

                    //        ----------------------------------------------
                    //        if (j == 0 && i == 0) //TRUE: es el primer dia de la semana, FALSE: el resto de los dias
                    //        {
                    //            vector[7] = "0";
                    //            vector[8] = "0";

                    //            if (fabDem < 0) //Si la fab-dem es negativa
                    //            {
                    //                vector[7] = (-fabDem).ToString(); //Modifico la col tortas no surtidas
                    //            }
                    //            else //la fab-dem es positiva
                    //            {
                    //                vector[12] = (int.Parse(vector[3]) * precioVenta).ToString(); //modifica ya que en realidad no vendió todo
                    //                vector[8] = fabDem.ToString(); //Modifico la col tortas tiradas
                    //            }

                    //            vector[11] = costoPerm.ToString();

                    //            double venta = double.Parse(vector[12].ToString());
                    //            double multa = double.Parse(vector[10].ToString());
                    //            double perm = double.Parse(vector[11].ToString());
                    //            double fab = double.Parse(vector[9].ToString());

                    //            vector[13] = (venta - multa - fab).ToString();
                    //            vector[14] = (venta - perm - fab).ToString();
                    //            totalDias++;
                    //        }
                    //        else
                    //        {
                    //            if (fabDem < 0) //Si la fab-dem es negativa
                    //            {
                    //                long anterior = long.Parse(vector[7]);
                    //                anterior = anterior + (-fabDem);
                    //                vector[7] = anterior.ToString(); //Modifico la col tortas no surtidas
                    //            }
                    //            else //la fab-dem es positiva
                    //            {
                    //                vector[12] = (int.Parse(vector[3]) * precioVenta).ToString(); //modifica ya que en realidad no vendió todo
                    //                long anterior = long.Parse(vector[8]);
                    //                anterior = anterior + fabDem;
                    //                vector[8] = anterior.ToString(); //Modifico la col tortas tiradas
                    //            }

                    //            if (j == 0)
                    //                vector[11] = "200";
                    //            else
                    //                vector[11] = "0";

                    //            double venta = double.Parse(vector[12].ToString());
                    //            double multa = double.Parse(vector[10].ToString());
                    //            double perm = double.Parse(vector[11].ToString());
                    //            double fab = double.Parse(vector[9].ToString());
                    //            double utilSinPermAnt = double.Parse(vector[13].ToString());
                    //            double utilConPermAnt = double.Parse(vector[14].ToString());

                    //            vector[13] = (utilSinPermAnt + venta - multa - fab).ToString();
                    //            vector[14] = (utilConPermAnt + venta - perm - fab).ToString();
                    //            totalDias++;
                    //        }

                    //        if (totalDias > limite)
                    //            tabla.LoadDataRow(vector, true);
                }


            }
            //totalNoSurtidas += double.Parse(vector[7]);
            //totalTiradas += double.Parse(vector[8]);
            //uTotalSinPer += double.Parse(vector[13]);
            //uTotalConPer += double.Parse(vector[14]);
            return tabla;
        }


    }
}
