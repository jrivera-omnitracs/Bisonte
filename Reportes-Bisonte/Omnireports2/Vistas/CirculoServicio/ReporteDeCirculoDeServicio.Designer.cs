namespace Omnireports2.Vistas
{
    partial class formReporteDeCirculoDeServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReporteDeCirculoDeServicio));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpExcesoVelocidad = new System.Windows.Forms.TabPage();
            this.datagvExcesosVelocidad = new System.Windows.Forms.DataGridView();
            this.tpFrenadasBruscas = new System.Windows.Forms.TabPage();
            this.datagvFrenadasBruscas = new System.Windows.Forms.DataGridView();
            this.tpKilometrosRecorridos = new System.Windows.Forms.TabPage();
            this.datagvKmRecorridos = new System.Windows.Forms.DataGridView();
            this.tpRendimientoCombustible = new System.Windows.Forms.TabPage();
            this.datagvRendimientoCombustible = new System.Windows.Forms.DataGridView();
            this.tpEstadisticas = new System.Windows.Forms.TabPage();
            this.datagvEstadisticas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dthFinal = new System.Windows.Forms.DateTimePicker();
            this.dthInicial = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtEconomico = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpExcesoVelocidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvExcesosVelocidad)).BeginInit();
            this.tpFrenadasBruscas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvFrenadasBruscas)).BeginInit();
            this.tpKilometrosRecorridos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvKmRecorridos)).BeginInit();
            this.tpRendimientoCombustible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvRendimientoCombustible)).BeginInit();
            this.tpEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvEstadisticas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Location = new System.Drawing.Point(741, 456);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Exportar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpExcesoVelocidad);
            this.tabControl1.Controls.Add(this.tpFrenadasBruscas);
            this.tabControl1.Controls.Add(this.tpKilometrosRecorridos);
            this.tabControl1.Controls.Add(this.tpRendimientoCombustible);
            this.tabControl1.Controls.Add(this.tpEstadisticas);
            this.tabControl1.Location = new System.Drawing.Point(13, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 368);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpExcesoVelocidad
            // 
            this.tpExcesoVelocidad.Controls.Add(this.datagvExcesosVelocidad);
            this.tpExcesoVelocidad.Location = new System.Drawing.Point(4, 22);
            this.tpExcesoVelocidad.Name = "tpExcesoVelocidad";
            this.tpExcesoVelocidad.Padding = new System.Windows.Forms.Padding(3);
            this.tpExcesoVelocidad.Size = new System.Drawing.Size(795, 342);
            this.tpExcesoVelocidad.TabIndex = 1;
            this.tpExcesoVelocidad.Text = "Excesos de Vel.";
            this.tpExcesoVelocidad.UseVisualStyleBackColor = true;
            // 
            // datagvExcesosVelocidad
            // 
            this.datagvExcesosVelocidad.AllowUserToAddRows = false;
            this.datagvExcesosVelocidad.AllowUserToDeleteRows = false;
            this.datagvExcesosVelocidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvExcesosVelocidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvExcesosVelocidad.Location = new System.Drawing.Point(3, 3);
            this.datagvExcesosVelocidad.Name = "datagvExcesosVelocidad";
            this.datagvExcesosVelocidad.ReadOnly = true;
            this.datagvExcesosVelocidad.Size = new System.Drawing.Size(789, 336);
            this.datagvExcesosVelocidad.TabIndex = 0;
            // 
            // tpFrenadasBruscas
            // 
            this.tpFrenadasBruscas.Controls.Add(this.datagvFrenadasBruscas);
            this.tpFrenadasBruscas.Location = new System.Drawing.Point(4, 22);
            this.tpFrenadasBruscas.Name = "tpFrenadasBruscas";
            this.tpFrenadasBruscas.Padding = new System.Windows.Forms.Padding(3);
            this.tpFrenadasBruscas.Size = new System.Drawing.Size(795, 342);
            this.tpFrenadasBruscas.TabIndex = 2;
            this.tpFrenadasBruscas.Text = "Frenadas Bruscas";
            this.tpFrenadasBruscas.UseVisualStyleBackColor = true;
            // 
            // datagvFrenadasBruscas
            // 
            this.datagvFrenadasBruscas.AllowUserToAddRows = false;
            this.datagvFrenadasBruscas.AllowUserToDeleteRows = false;
            this.datagvFrenadasBruscas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvFrenadasBruscas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvFrenadasBruscas.Location = new System.Drawing.Point(3, 3);
            this.datagvFrenadasBruscas.Name = "datagvFrenadasBruscas";
            this.datagvFrenadasBruscas.ReadOnly = true;
            this.datagvFrenadasBruscas.Size = new System.Drawing.Size(789, 336);
            this.datagvFrenadasBruscas.TabIndex = 0;
            // 
            // tpKilometrosRecorridos
            // 
            this.tpKilometrosRecorridos.Controls.Add(this.datagvKmRecorridos);
            this.tpKilometrosRecorridos.Location = new System.Drawing.Point(4, 22);
            this.tpKilometrosRecorridos.Name = "tpKilometrosRecorridos";
            this.tpKilometrosRecorridos.Padding = new System.Windows.Forms.Padding(3);
            this.tpKilometrosRecorridos.Size = new System.Drawing.Size(795, 342);
            this.tpKilometrosRecorridos.TabIndex = 3;
            this.tpKilometrosRecorridos.Text = "Km. Recorridos";
            this.tpKilometrosRecorridos.UseVisualStyleBackColor = true;
            // 
            // datagvKmRecorridos
            // 
            this.datagvKmRecorridos.AllowUserToAddRows = false;
            this.datagvKmRecorridos.AllowUserToDeleteRows = false;
            this.datagvKmRecorridos.AllowUserToOrderColumns = true;
            this.datagvKmRecorridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvKmRecorridos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvKmRecorridos.Location = new System.Drawing.Point(3, 3);
            this.datagvKmRecorridos.Name = "datagvKmRecorridos";
            this.datagvKmRecorridos.ReadOnly = true;
            this.datagvKmRecorridos.Size = new System.Drawing.Size(789, 336);
            this.datagvKmRecorridos.TabIndex = 0;
            // 
            // tpRendimientoCombustible
            // 
            this.tpRendimientoCombustible.Controls.Add(this.datagvRendimientoCombustible);
            this.tpRendimientoCombustible.Location = new System.Drawing.Point(4, 22);
            this.tpRendimientoCombustible.Name = "tpRendimientoCombustible";
            this.tpRendimientoCombustible.Padding = new System.Windows.Forms.Padding(3);
            this.tpRendimientoCombustible.Size = new System.Drawing.Size(795, 342);
            this.tpRendimientoCombustible.TabIndex = 4;
            this.tpRendimientoCombustible.Text = "Rend. Combustible";
            this.tpRendimientoCombustible.UseVisualStyleBackColor = true;
            // 
            // datagvRendimientoCombustible
            // 
            this.datagvRendimientoCombustible.AllowUserToAddRows = false;
            this.datagvRendimientoCombustible.AllowUserToDeleteRows = false;
            this.datagvRendimientoCombustible.AllowUserToOrderColumns = true;
            this.datagvRendimientoCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvRendimientoCombustible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvRendimientoCombustible.Location = new System.Drawing.Point(3, 3);
            this.datagvRendimientoCombustible.Name = "datagvRendimientoCombustible";
            this.datagvRendimientoCombustible.ReadOnly = true;
            this.datagvRendimientoCombustible.Size = new System.Drawing.Size(789, 336);
            this.datagvRendimientoCombustible.TabIndex = 0;
            // 
            // tpEstadisticas
            // 
            this.tpEstadisticas.Controls.Add(this.datagvEstadisticas);
            this.tpEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tpEstadisticas.Name = "tpEstadisticas";
            this.tpEstadisticas.Size = new System.Drawing.Size(795, 342);
            this.tpEstadisticas.TabIndex = 7;
            this.tpEstadisticas.Text = "Estadísticas";
            this.tpEstadisticas.UseVisualStyleBackColor = true;
            // 
            // datagvEstadisticas
            // 
            this.datagvEstadisticas.AllowUserToAddRows = false;
            this.datagvEstadisticas.AllowUserToDeleteRows = false;
            this.datagvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.datagvEstadisticas.Name = "datagvEstadisticas";
            this.datagvEstadisticas.ReadOnly = true;
            this.datagvEstadisticas.Size = new System.Drawing.Size(795, 342);
            this.datagvEstadisticas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(98, 9);
            this.dtpInicio.MinDate = new System.DateTime(2015, 7, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 3;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de termino";
            // 
            // dtpFin
            // 
            this.dtpFin.CausesValidation = false;
            this.dtpFin.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dtpFin.Location = new System.Drawing.Point(98, 35);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 5;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dthFinal);
            this.panel1.Controls.Add(this.dthInicial);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(202, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 64);
            this.panel1.TabIndex = 6;
            // 
            // dthFinal
            // 
            this.dthFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dthFinal.Location = new System.Drawing.Point(305, 34);
            this.dthFinal.Name = "dthFinal";
            this.dthFinal.ShowUpDown = true;
            this.dthFinal.Size = new System.Drawing.Size(99, 20);
            this.dthFinal.TabIndex = 7;
            // 
            // dthInicial
            // 
            this.dthInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dthInicial.Location = new System.Drawing.Point(305, 8);
            this.dthInicial.Name = "dthInicial";
            this.dthInicial.ShowUpDown = true;
            this.dthInicial.Size = new System.Drawing.Size(99, 20);
            this.dthInicial.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(779, 41);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(26, 27);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtEconomico
            // 
            this.txtEconomico.Location = new System.Drawing.Point(626, 48);
            this.txtEconomico.Name = "txtEconomico";
            this.txtEconomico.Size = new System.Drawing.Size(147, 20);
            this.txtEconomico.TabIndex = 10;
            // 
            // formReporteDeCirculoDeServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(828, 490);
            this.Controls.Add(this.txtEconomico);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formReporteDeCirculoDeServicio";
            this.Text = "Reporte de Circulo de Servicio";
            this.tabControl1.ResumeLayout(false);
            this.tpExcesoVelocidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvExcesosVelocidad)).EndInit();
            this.tpFrenadasBruscas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvFrenadasBruscas)).EndInit();
            this.tpKilometrosRecorridos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvKmRecorridos)).EndInit();
            this.tpRendimientoCombustible.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvRendimientoCombustible)).EndInit();
            this.tpEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvEstadisticas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dthFinal;
        private System.Windows.Forms.DateTimePicker dthInicial;
        private System.Windows.Forms.TabPage tpExcesoVelocidad;
        private System.Windows.Forms.DataGridView datagvExcesosVelocidad;
        private System.Windows.Forms.TabPage tpFrenadasBruscas;
        private System.Windows.Forms.DataGridView datagvFrenadasBruscas;
        private System.Windows.Forms.TabPage tpKilometrosRecorridos;
        private System.Windows.Forms.DataGridView datagvKmRecorridos;
        private System.Windows.Forms.TabPage tpRendimientoCombustible;
        private System.Windows.Forms.DataGridView datagvRendimientoCombustible;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtEconomico;
        private System.Windows.Forms.TabPage tpEstadisticas;
        private System.Windows.Forms.DataGridView datagvEstadisticas;
    }
}