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

            this.txtComisionAC.Text = "250";
            this.txt_cantMostrar.Text = "2";
            this.txt_cantSemanas.Text = "5";
            this.txt_mostrarDesde.Text = "1";

            dgwcomisionAM.Rows.Add(500, 50);
            dgwcomisionAM.Rows.Add(750, 50);

            dgwcomisionAL.Rows.Add(1500, 50);
            dgwcomisionAL.Rows.Add(2500, 50);

            dgwTipoAuto.Rows.Add("Compacto(C)", 50, 1);
            dgwTipoAuto.Rows.Add("Auto Mediano (AM)", 30, 2);
            dgwTipoAuto.Rows.Add("Auto de Lujo(AL)", 20, 3);

            dgwcantautos.Rows.Add(0, 10);
            dgwcantautos.Rows.Add(1, 25);
            dgwcantautos.Rows.Add(2, 15);
            dgwcantautos.Rows.Add(3, 30);
            dgwcantautos.Rows.Add(4, 20);
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

            if (rad_VerTodos.Checked)
            {
                Simular();
            }

            else if (rad_v1.Checked)
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
            dgw_simulacion.DataSource = manejador.Simular(int.Parse(txt_cantSemanas.Text), int.Parse(txt_cantMostrar.Text), int.Parse(txt_mostrarDesde.Text), CantAutosVendidos, TipoAuto, ComisionAL, ComisionAM, ref acumtotalporvendedor);

            acumtotalporvendedor = acumtotalporvendedor / 4;
            lblResultado.Text = "Comisión promedio de los vendedores en una semana: " + acumtotalporvendedor.ToString();

            TcRSimulacion.SelectTab(TpRSimulacion);
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
                pr = new Probabilidades(int.Parse(z), (double.Parse(b) / 100));

                probabilidades.Add(pr);
            }

            return probabilidades;
        }

        private void VerificarProbComisionAutosMedianos(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Hola VerificarProbComisionAutosMedianos Autos Medianos");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
