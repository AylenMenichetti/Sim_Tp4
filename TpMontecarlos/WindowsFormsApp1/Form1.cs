using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simlib.Tabla_Probabilidades;
using Simlib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;


namespace AgenciaAutos
{
    public partial class Form1 : Form
    {
        Distribuciones CantAutosVendidos;
        Distribuciones TipoAuto;
        Distribuciones ComisionAM;
        Distribuciones ComisionAL;
        ManejadorSimulacion manejador = new ManejadorSimulacion();

        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            Probabilidades pr;
            List<Probabilidades> ListaCantAutos = new List<Probabilidades>();
            List<Probabilidades> ListatiposAutos = new List<Probabilidades>();
            List<Probabilidades> ListaComisionAL = new List<Probabilidades>();
            List<Probabilidades> ListaComisionAM = new List<Probabilidades>();
            //CargaTablaCantAutos
            for (int i = 0; i < dgwcantautos.RowCount; i++)
            {
                pr = new Probabilidades((int)dgwcantautos.Rows[i].Cells[0].Value, (float)dgwcantautos.Rows[i].Cells[1].Value);
                ListaCantAutos.Add(pr);
            }
            //CargaTablaTipoAuto
            for (int i = 0; i < dgwTipoAuto.RowCount; i++)
            {
                pr = new Probabilidades((int)dgwTipoAuto.Rows[i].Cells[0].Value, (float)dgwTipoAuto.Rows[i].Cells[1].Value);
                ListatiposAutos.Add(pr);
            }
            //CargaTablaComisionAL
            for (int i = 0; i < dgwcomisionAL.RowCount; i++)
            {
                pr = new Probabilidades((int)dgwcomisionAL.Rows[i].Cells[0].Value, (float)dgwcomisionAL.Rows[i].Cells[1].Value);
                ListaComisionAL.Add(pr);
            }
            //CargaTablaComisionAM
            for (int i = 0; i < dgwcomisionAM.RowCount; i++)
            {
                pr = new Probabilidades((int)dgwcomisionAM.Rows[i].Cells[0].Value, (float)dgwcomisionAM.Rows[i].Cells[1].Value);
                ListaComisionAM.Add(pr);
            }


            //Genera distribuciones
            CantAutosVendidos = new Distribuciones(ListaCantAutos);
            TipoAuto = new Distribuciones(ListatiposAutos);
            ComisionAL = new Distribuciones(ListaComisionAL);
            ComisionAM = new Distribuciones(ListaComisionAM);


            if (rad_v1.Checked)
            {
                Simular();

            }

            else if (rad_v2.Checked)
            {
                Simular();
            }

            else if (rad_v3.Checked)
            {
                Simular();
            }
            else if (rad_v4.Checked)
            {
                Simular();
            }
        }


        private void Simular()
        {
         double acumtotalporvendedor = 0;
         dgw_simulacion.DataSource = manejador.Simular(int.Parse(txt_cantSemanas.Text), int.Parse(txt_cantMostrar.Text), int.Parse(txt_mostrarDesde.Text),CantAutosVendidos,TipoAuto,ComisionAL,ComisionAM,ref acumtotalporvendedor);

         acumtotalporvendedor = acumtotalporvendedor / 4;
         lblResultado.Text = "Comisión promedio de los vendedores en una semana: " + acumtotalporvendedor.ToString();

        }
      
    }
}
