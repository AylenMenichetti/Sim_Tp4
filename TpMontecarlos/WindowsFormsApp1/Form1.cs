﻿using System;
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

namespace AgenciaAutos
{
    public partial class Form1 : Form
    {
        Distribuciones<int> CantAutosVendidos;
        Distribuciones<TipoAuto> TipoAuto;
        Distribuciones<double> ComisionAM;
        Distribuciones<double> ComisionAL;
        Distribuciones<double> ComisionComp;
        ManejadorSimulacion manejador;

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

        private bool validar()
        {
            int acum = 0;
            foreach(DataGridViewRow row in dgwcantautos.Rows)
            {
                acum += Convert.ToInt32(row.Cells[1].Value);
            }
            if (acum != 100) return false;
            acum = 0;
            foreach (DataGridViewRow row in dgwTipoAuto.Rows)
            {
                acum += Convert.ToInt32(row.Cells[1].Value);
            }
            if (acum != 100) return false;
            acum = 0;
            foreach (DataGridViewRow row in dgwcomisionAL.Rows)
            {
                acum += Convert.ToInt32(row.Cells[1].Value);
            }
            if (acum != 100) return false;
            acum = 0;
            foreach (DataGridViewRow row in dgwcomisionAM.Rows)
            {
                acum += Convert.ToInt32(row.Cells[1].Value);
            }
            if (acum != 100) return false;
            return true;
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Los numeros no cierran");
                return;
            }

            //Crea Distribucion de Cantidad de Autos.
            this.generarDistribucionCantidad();


            //Crea Distribucion de Comisiones.
            this.generarDistrivucionesTipos();

            //Crea Distribucion de Tipo de Autos
            this.generarDistribucionTipoAuto();
            

            /*this.generarProbabilidades(dgwcantautos, ListaCantAutos);
            this.generarProbabilidades(dgwTipoAuto, ListatiposAutos);
            this.generarProbabilidades(dgwcomisionAL, ListaComisionAL);
            this.generarProbabilidades(dgwcomisionAM, ListaComisionAM);

            CantAutosVendidos = new Distribuciones(ListaCantAutos);
            TipoAuto = new Distribuciones(ListaTiposAutos);
            ComisionAM = new Distribuciones(ListaComisionAM);*/


            Simular();
            //dgw_simulacion.Columns[9].Visible = false;

        }

        private void generarDistribucionCantidad()
        {
            List<Probabilidades<int>> ListaCantAutos = new List<Probabilidades<int>>();
            foreach (DataGridViewRow r in dgwcantautos.Rows)
            {
                var valor = r.Cells[0].Value;
                var probabilidad = r.Cells[1].Value;
                ListaCantAutos.Add(new Probabilidades<int>(Convert.ToInt32(valor), Convert.ToDouble(probabilidad)));
            }
            this.CantAutosVendidos = new Distribuciones<int>(ListaCantAutos);
        }
        private void generarDistrivucionesTipos()
        {
            List<Probabilidades<double>> ListaComisionAL = new List<Probabilidades<double>>();
            List<Probabilidades<double>> ListaComisionAM = new List<Probabilidades<double>>();
            List<Probabilidades<double>> ListaComisionComp = new List<Probabilidades<double>>();
            foreach (DataGridViewRow r in dgwcomisionAL.Rows)
            {
                var valor = r.Cells[0].Value;
                var probabilidad = r.Cells[1].Value;
                ListaComisionAL.Add(new Probabilidades<double>(Convert.ToDouble(valor), Convert.ToDouble(probabilidad)));
            }
            this.ComisionAL = new Distribuciones<double>(ListaComisionAL);
            foreach (DataGridViewRow r in dgwcomisionAM.Rows)
            {
                var valor = r.Cells[0].Value;
                var probabilidad = r.Cells[1].Value;
                ListaComisionAM.Add(new Probabilidades<double>(Convert.ToDouble(valor), Convert.ToDouble(probabilidad)));
            }
            this.ComisionAM = new Distribuciones<double>(ListaComisionAM);

            var comison_comp = txtComisionAC.Text;
            ListaComisionComp.Add(new Probabilidades<double>(Convert.ToDouble(comison_comp), 100));
            this.ComisionComp = new Distribuciones<double>(ListaComisionComp);
        }
        private void generarDistribucionTipoAuto()
        {
            List<Probabilidades<TipoAuto>> ListaTiposAutos = new List<Probabilidades<TipoAuto>>();
            Probabilidades<TipoAuto> p;
            foreach (DataGridViewRow r in dgwTipoAuto.Rows)
            {
                var nombre = r.Cells[0].Value.ToString();
                var prob = r.Cells[1].Value;
                var tipo = new TipoAuto();
                tipo.Nombre = nombre;
                if (nombre == "Compacto(C)")
                {
                    tipo.DistribucionComision = ComisionComp;
                    tipo.Numero = 1;
                }
                else if (nombre == "Auto Mediano (AM)")
                {
                    tipo.DistribucionComision = ComisionAM;
                    tipo.Numero = 2;
                }
                else
                {
                    tipo.DistribucionComision = ComisionAL;
                    tipo.Numero = 3;
                }

                p = new Probabilidades<TipoAuto>(tipo, Convert.ToDouble(prob));
                ListaTiposAutos.Add(p);
            }
            this.TipoAuto = new Distribuciones<TipoAuto>(ListaTiposAutos);
        }

        /*private List<Probabilidades> generarProbabilidades(DataGridView dt, List<Probabilidades> probabilidades)
        {
            Probabilidades pr;
            var nombre = dt.Name;
            var c = 0;
            if (nombre.Equals("dgwTipoAuto"))
            {
                c = 2;
            }
            for (int i = 0; i < dt.RowCount; i++)
            {
                var z = dt.Rows[i].Cells[c].Value.ToString();
                var b = dt.Rows[i].Cells[1].Value.ToString();
                pr = new Probabilidades(int.Parse(z), (double.Parse(b)));

                probabilidades.Add(pr);
            }

            return probabilidades;
        }*/


        private void Simular()
        {
            double promtotal = 0;
            string textpromparc = "";

            ManejadorSimulacion manejador = new ManejadorSimulacion(this.CantAutosVendidos, this.TipoAuto);

            dgw_simulacion.DataSource = manejador.Simular(
                int.Parse(txt_cantSemanas.Text), 
                int.Parse(txt_cantMostrar.Text), 
                int.Parse(txt_mostrarDesde.Text), 
                /*CantAutosVendidos, 
                TipoAuto, ComisionAL, 
                ComisionAM, */
                ref promtotal, 
                ref textpromparc);


            dgw_simulacion.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
            lblResultado.Text = "Comisión promedio de los vendedores en una semana: " + promtotal.ToString();
            lblpromparcial.Text = textpromparc;
            TcRSimulacion.SelectTab(TpRSimulacion);

         
        }

       

        private void VerificarProbComisionAutosMedianos(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Hola VerificarProbComisionAutosMedianos Autos Medianos");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblpromparcial_Click(object sender, EventArgs e)
        {

        }

        private void filtrar(int vendedor) {


            foreach (DataGridViewRow row in dgw_simulacion.Rows)
            {
                if (Convert.ToInt32(row.Cells[9].Value) != vendedor)
                {

                    CurrencyManager cm = (CurrencyManager)BindingContext[dgw_simulacion.DataSource];
                    cm.SuspendBinding();
                    row.Visible = false;
                }



            }
        }




        //DataTable dt = manejador.Simular(int.Parse(txt_cantSemanas.Text), int.Parse(txt_cantMostrar.Text), int.Parse(txt_mostrarDesde.Text), CantAutosVendidos, TipoAuto, ComisionAL, ComisionAM, ref promtotal, ref textpromparc);
        //dgw_simulacion.DataSource = dt;
        //DataView view = dt.DefaultView;
        //view.RowFilter = "";
        //dgw_simulacion.DataSource = view;




        private void traertodos()
        {
            foreach (DataGridViewRow row in dgw_simulacion.Rows)
            {        
                    row.Visible = true;
            
            }
        }




        private void rad_v1_CheckedChanged(object sender, EventArgs e)
        {
            traertodos();
            filtrar(1);
        }

        private void rad_VerTodos_CheckedChanged(object sender, EventArgs e)
        {
            traertodos();


        }

        private void rad_v2_CheckedChanged(object sender, EventArgs e)
        {
            traertodos();
            filtrar(2);
        }

        private void rad_v3_CheckedChanged(object sender, EventArgs e)
        {
            traertodos();
            filtrar(3);
        }

        private void rad_v4_CheckedChanged(object sender, EventArgs e)
        {
            traertodos();
            filtrar(4);
        }

        private void sim_btn_fede_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Los numeros no cierran");
                return;
            }
            /*List<Probabilidades> ListaCantAutos = new List<Probabilidades>();
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

            ManejadorAlt handler = new ManejadorAlt();
            handler.Simular(int.Parse(txt_cantSemanas.Text), int.Parse(txt_cantMostrar.Text), int.Parse(txt_mostrarDesde.Text), CantAutosVendidos, TipoAuto, ComisionAL, ComisionAM);

            dgw_simulacion.DataSource = handler.info;
            dgw_simulacion.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgw_simulacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //MessageBox.Show($@"Promedio: ${handler.Promedio}");
            lblpromparcial.Text = $"Promedio Individual: {handler.PromedioIndividual.ToString("C")}";
            lblResultado.Text = $"Promedio Grupal: {handler.PromedioGrupal.ToString("C")}";
            TcRSimulacion.SelectTab(TpRSimulacion);*/

        }
    }
}
