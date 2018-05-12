namespace AgenciaAutos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rad_v1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_v4 = new System.Windows.Forms.RadioButton();
            this.rad_v3 = new System.Windows.Forms.RadioButton();
            this.rad_v2 = new System.Windows.Forms.RadioButton();
            this.txt_cantSemanas = new System.Windows.Forms.TextBox();
            this.txt_mostrarDesde = new System.Windows.Forms.TextBox();
            this.txtComisionAC = new System.Windows.Forms.TextBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.dgw_simulacion = new System.Windows.Forms.DataGridView();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndcantau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantAut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndtipoAut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoauto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDcomision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comacum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcRSimulacion = new System.Windows.Forms.TabControl();
            this.TpParametros = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantMostrar = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgwcomisionAM = new System.Windows.Forms.DataGridView();
            this.comisionAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgwcomisionAL = new System.Windows.Forms.DataGridView();
            this.comisonAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgwTipoAuto = new System.Windows.Forms.DataGridView();
            this.tiposAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgwcantautos = new System.Windows.Forms.DataGridView();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TpRSimulacion = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_simulacion)).BeginInit();
            this.TcRSimulacion.SuspendLayout();
            this.TpParametros.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwcomisionAM)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwcomisionAL)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTipoAuto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwcantautos)).BeginInit();
            this.TpRSimulacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Semanas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mostrar Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Auto Compacto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(694, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // rad_v1
            // 
            this.rad_v1.AutoSize = true;
            this.rad_v1.Checked = true;
            this.rad_v1.Location = new System.Drawing.Point(6, 19);
            this.rad_v1.Name = "rad_v1";
            this.rad_v1.Size = new System.Drawing.Size(80, 17);
            this.rad_v1.TabIndex = 5;
            this.rad_v1.TabStop = true;
            this.rad_v1.Text = "Vendedor 1";
            this.rad_v1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_v4);
            this.groupBox1.Controls.Add(this.rad_v3);
            this.groupBox1.Controls.Add(this.rad_v2);
            this.groupBox1.Controls.Add(this.rad_v1);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 56);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendedores";
            // 
            // rad_v4
            // 
            this.rad_v4.AutoSize = true;
            this.rad_v4.Location = new System.Drawing.Point(268, 19);
            this.rad_v4.Name = "rad_v4";
            this.rad_v4.Size = new System.Drawing.Size(80, 17);
            this.rad_v4.TabIndex = 8;
            this.rad_v4.Text = "Vendedor 4";
            this.rad_v4.UseVisualStyleBackColor = true;
            // 
            // rad_v3
            // 
            this.rad_v3.AutoSize = true;
            this.rad_v3.Location = new System.Drawing.Point(172, 19);
            this.rad_v3.Name = "rad_v3";
            this.rad_v3.Size = new System.Drawing.Size(80, 17);
            this.rad_v3.TabIndex = 7;
            this.rad_v3.Text = "Vendedor 3";
            this.rad_v3.UseVisualStyleBackColor = true;
            // 
            // rad_v2
            // 
            this.rad_v2.AutoSize = true;
            this.rad_v2.Location = new System.Drawing.Point(89, 19);
            this.rad_v2.Name = "rad_v2";
            this.rad_v2.Size = new System.Drawing.Size(80, 17);
            this.rad_v2.TabIndex = 6;
            this.rad_v2.Text = "Vendedor 2";
            this.rad_v2.UseVisualStyleBackColor = true;
            // 
            // txt_cantSemanas
            // 
            this.txt_cantSemanas.Location = new System.Drawing.Point(130, 36);
            this.txt_cantSemanas.Name = "txt_cantSemanas";
            this.txt_cantSemanas.Size = new System.Drawing.Size(52, 20);
            this.txt_cantSemanas.TabIndex = 7;
            // 
            // txt_mostrarDesde
            // 
            this.txt_mostrarDesde.Location = new System.Drawing.Point(130, 67);
            this.txt_mostrarDesde.Name = "txt_mostrarDesde";
            this.txt_mostrarDesde.Size = new System.Drawing.Size(52, 20);
            this.txt_mostrarDesde.TabIndex = 8;
            // 
            // txtComisionAC
            // 
            this.txtComisionAC.Location = new System.Drawing.Point(105, 402);
            this.txtComisionAC.Name = "txtComisionAC";
            this.txtComisionAC.Size = new System.Drawing.Size(100, 20);
            this.txtComisionAC.TabIndex = 9;
            // 
            // btn_simular
            // 
            this.btn_simular.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_simular.Location = new System.Drawing.Point(712, 191);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(138, 60);
            this.btn_simular.TabIndex = 10;
            this.btn_simular.Text = "SIMULAR";
            this.btn_simular.UseVisualStyleBackColor = false;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // dgw_simulacion
            // 
            this.dgw_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_simulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.rndcantau,
            this.cantAut,
            this.rndtipoAut,
            this.tipoauto,
            this.RNDcomision,
            this.comision,
            this.ComTotal,
            this.comacum});
            this.dgw_simulacion.Location = new System.Drawing.Point(20, 83);
            this.dgw_simulacion.Name = "dgw_simulacion";
            this.dgw_simulacion.Size = new System.Drawing.Size(963, 379);
            this.dgw_simulacion.TabIndex = 11;
            // 
            // dia
            // 
            this.dia.HeaderText = "Día";
            this.dia.Name = "dia";
            // 
            // rndcantau
            // 
            this.rndcantau.HeaderText = "RND";
            this.rndcantau.Name = "rndcantau";
            // 
            // cantAut
            // 
            this.cantAut.HeaderText = "Cant. Autos Vendidos";
            this.cantAut.Name = "cantAut";
            // 
            // rndtipoAut
            // 
            this.rndtipoAut.HeaderText = "RND";
            this.rndtipoAut.Name = "rndtipoAut";
            // 
            // tipoauto
            // 
            this.tipoauto.HeaderText = "Tipo Auto";
            this.tipoauto.Name = "tipoauto";
            // 
            // RNDcomision
            // 
            this.RNDcomision.HeaderText = "RND";
            this.RNDcomision.Name = "RNDcomision";
            // 
            // comision
            // 
            this.comision.HeaderText = "comision";
            this.comision.Name = "comision";
            // 
            // ComTotal
            // 
            this.ComTotal.HeaderText = "Comision Total";
            this.ComTotal.Name = "ComTotal";
            // 
            // comacum
            // 
            this.comacum.HeaderText = "Comision Acumulada";
            this.comacum.Name = "comacum";
            // 
            // TcRSimulacion
            // 
            this.TcRSimulacion.Controls.Add(this.TpParametros);
            this.TcRSimulacion.Controls.Add(this.TpRSimulacion);
            this.TcRSimulacion.Location = new System.Drawing.Point(16, 10);
            this.TcRSimulacion.Margin = new System.Windows.Forms.Padding(2);
            this.TcRSimulacion.Name = "TcRSimulacion";
            this.TcRSimulacion.SelectedIndex = 0;
            this.TcRSimulacion.Size = new System.Drawing.Size(994, 491);
            this.TcRSimulacion.TabIndex = 12;
            // 
            // TpParametros
            // 
            this.TpParametros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TpParametros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TpParametros.Controls.Add(this.groupBox8);
            this.TpParametros.Controls.Add(this.groupBox7);
            this.TpParametros.Controls.Add(this.groupBox6);
            this.TpParametros.Controls.Add(this.groupBox3);
            this.TpParametros.Controls.Add(this.btn_simular);
            this.TpParametros.Location = new System.Drawing.Point(4, 22);
            this.TpParametros.Margin = new System.Windows.Forms.Padding(2);
            this.TpParametros.Name = "TpParametros";
            this.TpParametros.Padding = new System.Windows.Forms.Padding(2);
            this.TpParametros.Size = new System.Drawing.Size(986, 465);
            this.TpParametros.TabIndex = 0;
            this.TpParametros.Text = "Parametros";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.txt_cantMostrar);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.txt_cantSemanas);
            this.groupBox8.Controls.Add(this.txt_mostrarDesde);
            this.groupBox8.Location = new System.Drawing.Point(650, 21);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(218, 141);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Configuracion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad a Mostrar";
            // 
            // txt_cantMostrar
            // 
            this.txt_cantMostrar.Location = new System.Drawing.Point(130, 97);
            this.txt_cantMostrar.Name = "txt_cantMostrar";
            this.txt_cantMostrar.Size = new System.Drawing.Size(53, 20);
            this.txt_cantMostrar.TabIndex = 10;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.Controls.Add(this.txtComisionAC);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(338, 5);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(308, 447);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Comisión";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgwcomisionAM);
            this.groupBox5.Location = new System.Drawing.Point(15, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(292, 165);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Autos Medianos";
            // 
            // dgwcomisionAM
            // 
            this.dgwcomisionAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwcomisionAM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comisionAM,
            this.dataGridViewTextBoxColumn3});
            this.dgwcomisionAM.Location = new System.Drawing.Point(14, 32);
            this.dgwcomisionAM.Margin = new System.Windows.Forms.Padding(2);
            this.dgwcomisionAM.Name = "dgwcomisionAM";
            this.dgwcomisionAM.RowTemplate.Height = 24;
            this.dgwcomisionAM.Size = new System.Drawing.Size(263, 122);
            this.dgwcomisionAM.TabIndex = 0;
            // 
            // comisionAM
            // 
            this.comisionAM.HeaderText = "Comision";
            this.comisionAM.Name = "comisionAM";
            this.comisionAM.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Probabilidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgwcomisionAL);
            this.groupBox4.Location = new System.Drawing.Point(10, 186);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(292, 164);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comision Autos de Lujo";
            // 
            // dgwcomisionAL
            // 
            this.dgwcomisionAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwcomisionAL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comisonAL,
            this.dataGridViewTextBoxColumn1});
            this.dgwcomisionAL.Location = new System.Drawing.Point(14, 32);
            this.dgwcomisionAL.Margin = new System.Windows.Forms.Padding(2);
            this.dgwcomisionAL.Name = "dgwcomisionAL";
            this.dgwcomisionAL.RowTemplate.Height = 24;
            this.dgwcomisionAL.Size = new System.Drawing.Size(263, 122);
            this.dgwcomisionAL.TabIndex = 0;
            // 
            // comisonAL
            // 
            this.comisonAL.HeaderText = "Comisión";
            this.comisonAL.Name = "comisonAL";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Probabilidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgwTipoAuto);
            this.groupBox6.Location = new System.Drawing.Point(24, 191);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(298, 164);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo Autos Vendidos";
            // 
            // dgwTipoAuto
            // 
            this.dgwTipoAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTipoAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tiposAuto,
            this.dataGridViewTextBoxColumn5});
            this.dgwTipoAuto.Location = new System.Drawing.Point(14, 32);
            this.dgwTipoAuto.Margin = new System.Windows.Forms.Padding(2);
            this.dgwTipoAuto.Name = "dgwTipoAuto";
            this.dgwTipoAuto.RowTemplate.Height = 24;
            this.dgwTipoAuto.Size = new System.Drawing.Size(268, 122);
            this.dgwTipoAuto.TabIndex = 0;
            // 
            // tiposAuto
            // 
            this.tiposAuto.HeaderText = "Tipo de Auto";
            this.tiposAuto.Name = "tiposAuto";
            this.tiposAuto.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Probabilidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgwcantautos);
            this.groupBox3.Location = new System.Drawing.Point(24, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(298, 165);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad Autos Vendidos";
            // 
            // dgwcantautos
            // 
            this.dgwcantautos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwcantautos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.probabilidad});
            this.dgwcantautos.Location = new System.Drawing.Point(14, 32);
            this.dgwcantautos.Margin = new System.Windows.Forms.Padding(2);
            this.dgwcantautos.Name = "dgwcantautos";
            this.dgwcantautos.RowTemplate.Height = 24;
            this.dgwcantautos.Size = new System.Drawing.Size(268, 122);
            this.dgwcantautos.TabIndex = 0;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // probabilidad
            // 
            this.probabilidad.HeaderText = "Probabilidad";
            this.probabilidad.Name = "probabilidad";
            // 
            // TpRSimulacion
            // 
            this.TpRSimulacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TpRSimulacion.Controls.Add(this.groupBox2);
            this.TpRSimulacion.Controls.Add(this.groupBox1);
            this.TpRSimulacion.Controls.Add(this.dgw_simulacion);
            this.TpRSimulacion.Location = new System.Drawing.Point(4, 22);
            this.TpRSimulacion.Margin = new System.Windows.Forms.Padding(2);
            this.TpRSimulacion.Name = "TpRSimulacion";
            this.TpRSimulacion.Padding = new System.Windows.Forms.Padding(2);
            this.TpRSimulacion.Size = new System.Drawing.Size(986, 465);
            this.TpRSimulacion.TabIndex = 1;
            this.TpRSimulacion.Text = "Resultado Simulacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultado);
            this.groupBox2.Location = new System.Drawing.Point(390, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 56);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conclusiones";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(28, 23);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(40, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "           ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 522);
            this.Controls.Add(this.TcRSimulacion);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_simulacion)).EndInit();
            this.TcRSimulacion.ResumeLayout(false);
            this.TpParametros.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwcomisionAM)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwcomisionAL)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTipoAuto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwcantautos)).EndInit();
            this.TpRSimulacion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rad_v1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_v4;
        private System.Windows.Forms.RadioButton rad_v3;
        private System.Windows.Forms.RadioButton rad_v2;
        private System.Windows.Forms.TextBox txt_cantSemanas;
        private System.Windows.Forms.TextBox txt_mostrarDesde;
        private System.Windows.Forms.TextBox txtComisionAC;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.DataGridView dgw_simulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndcantau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantAut;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndtipoAut;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoauto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDcomision;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn comacum;
        private System.Windows.Forms.TabControl TcRSimulacion;
        private System.Windows.Forms.TabPage TpParametros;
        private System.Windows.Forms.TabPage TpRSimulacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgwcantautos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgwcomisionAL;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgwcomisionAM;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgwTipoAuto;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cantMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisonAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblResultado;
    }
}

