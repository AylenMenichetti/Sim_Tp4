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

            dgwcantautos.Rows.Add(0, 20);
            dgwcantautos.Rows.Add(1, 30);
            dgwcantautos.Rows.Add(2, 30);
            dgwcantautos.Rows.Add(3, 15);
            dgwcantautos.Rows.Add(4, 5);

            dgwcomisionAM.Rows.Add(400, 40);
            dgwcomisionAM.Rows.Add(500, 60);

            dgwcomisionAL.Rows.Add(1000, 35);
            dgwcomisionAL.Rows.Add(1500, 40);
            dgwcomisionAL.Rows.Add(2000, 25);

            dgwTipoAuto.Rows.Add("Compacto(C)", 50, 1);
            dgwTipoAuto.Rows.Add("Auto Mediano (AM)", 35, 2);
            dgwTipoAuto.Rows.Add("Auto de Lujo(AL)", 15, 3);

            this.txtComisionAC.Text = "250";
            this.txt_cantMostrar.Text = "50";
            this.txt_cantSemanas.Text = "1000";
            this.txt_mostrarDesde.Text = "1";

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
            dgw_simulacion.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
                pr = new Probabilidades(int.Parse(z), (double.Parse(b)));

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
