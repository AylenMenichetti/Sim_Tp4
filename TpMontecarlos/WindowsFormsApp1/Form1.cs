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
            this.cargarTablasTipoAuto();
            this.cargarTablasCantAutos();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            Probabilidades pr;
            List<Probabilidades> ListaCantAutos = new List<Probabilidades>();
            List<Probabilidades> ListatiposAutos = new List<Probabilidades>();
            List<Probabilidades> ListaComisionAL = new List<Probabilidades>();
            List<Probabilidades> ListaComisionAM = new List<Probabilidades>();

            this.generarProbabilidades(dgwcantautos, ListaCantAutos);
            this.generarProbabilidades(dgwTipoAuto, ListatiposAutos);
            this.generarProbabilidades(dgwcomisionAL, ListaComisionAL);
            this.generarProbabilidades(dgwcomisionAM, ListaComisionAM);

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
        private void cargarTablasCantAutos()
        {

            dgwcantautos.Columns.Add("cantidad", "Cantidad");
            dgwcantautos.Columns.Add("probabilidad", "Probabilidad");

            for (int i = 0; i < 5; i++)
            {
                dgwcantautos.Rows.Add(i, null);
                dgwcantautos.Rows[i].Cells[0].ReadOnly = true;
            }

        }

        private void cargarTablasTipoAuto()
        {

            dgwTipoAuto.Columns.Add("cantidad", "Cantidad");
            dgwTipoAuto.Columns.Add("probabilidad", "Probabilidad");
            dgwTipoAuto.Columns.Add("index", "Index");
            dgwTipoAuto.Columns[2].Visible = false;

            dgwTipoAuto.Rows.Add("Compacto(C)", null, 1);
            dgwTipoAuto.Rows[0].Cells[0].ReadOnly = true;

            dgwTipoAuto.Rows.Add("Auto Mediano (AM)", null, 2);
            dgwTipoAuto.Rows[1].Cells[0].ReadOnly = true;

            dgwTipoAuto.Rows.Add("Auto de Lujo(AL)", null, 3);
            dgwTipoAuto.Rows[2].Cells[0].ReadOnly = true;

        }
        private List<Probabilidades> generarProbabilidades(DataGridView dt, List<Probabilidades> probabilidades)
        {
            Probabilidades pr;
            var nombre = dt.Name;
            var c = 0;
            if (nombre.Equals("dgwTipoAuto"))
            {
                c = 2;
            }
            for (int i = 0; i < dt.RowCount - 1; i++)
            {
                var z = dt.Rows[i].Cells[c].Value.ToString();
                var b = dt.Rows[i].Cells[1].Value.ToString();
                pr = new Probabilidades(int.Parse(z), double.Parse(b));

                probabilidades.Add(pr);
            }

            return probabilidades;
        }

        private void VerificarProbComisionAutosMedianos(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hola VerificarProbComisionAutosMedianos Autos Medianos");
        }
    }
}
