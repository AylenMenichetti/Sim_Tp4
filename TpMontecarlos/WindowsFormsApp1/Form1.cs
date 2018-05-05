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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Distribuciones CantAutosVendidos;
        Distribuciones TipoAuto;
        Distribuciones Comision;

        public Form1()
        {
            InitializeComponent();

            Probabilidades pr1 = new Probabilidades(0, 0.200);
            Probabilidades pr2 = new Probabilidades(0, 0.300);
            Probabilidades pr3 = new Probabilidades(0, 0.300);
            Probabilidades pr4 = new Probabilidades(0, 0.150);
            Probabilidades pr5 = new Probabilidades(0, 0.050);
            List<Probabilidades> ListaCantAutos = new List<Probabilidades>();
            ListaCantAutos.Add(pr1);
            ListaCantAutos.Add(pr2);
            ListaCantAutos.Add(pr3);
            ListaCantAutos.Add(pr4);
            ListaCantAutos.Add(pr5);
            CantAutosVendidos = new Distribuciones(ListaCantAutos);       


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
