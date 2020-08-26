namespace CapaDiseño
{
    partial class FrmReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.segundoRepo = new System.Windows.Forms.LinkLabel();
            this.tercerRepo = new System.Windows.Forms.LinkLabel();
            this.QuintoRepo = new System.Windows.Forms.LinkLabel();
            this.sextoRepo = new System.Windows.Forms.LinkLabel();
            this.CuartoRepo = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblErrores = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // segundoRepo
            // 
            this.segundoRepo.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.segundoRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.segundoRepo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.segundoRepo.Location = new System.Drawing.Point(18, 27);
            this.segundoRepo.Name = "segundoRepo";
            this.segundoRepo.Size = new System.Drawing.Size(416, 30);
            this.segundoRepo.TabIndex = 13;
            this.segundoRepo.TabStop = true;
            this.segundoRepo.Text = " Cantidad de personas atendidas por día en el salón";
            this.segundoRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.segundoRepo_LinkcCicked);
            // 
            // tercerRepo
            // 
            this.tercerRepo.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.tercerRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tercerRepo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tercerRepo.Location = new System.Drawing.Point(18, 125);
            this.tercerRepo.Name = "tercerRepo";
            this.tercerRepo.Size = new System.Drawing.Size(416, 26);
            this.tercerRepo.TabIndex = 14;
            this.tercerRepo.TabStop = true;
            this.tercerRepo.Text = "Cantidad de personas atendidas por día en el bar";
            this.tercerRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tercerRepo_LinkClicked);
            // 
            // QuintoRepo
            // 
            this.QuintoRepo.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.QuintoRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.QuintoRepo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.QuintoRepo.Location = new System.Drawing.Point(18, 76);
            this.QuintoRepo.Name = "QuintoRepo";
            this.QuintoRepo.Size = new System.Drawing.Size(416, 28);
            this.QuintoRepo.TabIndex = 15;
            this.QuintoRepo.TabStop = true;
            this.QuintoRepo.Text = "Cantidad de comandas que fueron atendidas en el bar";
            this.QuintoRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quinto_LinkcCicked);
            // 
            // sextoRepo
            // 
            this.sextoRepo.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.sextoRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sextoRepo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sextoRepo.Location = new System.Drawing.Point(18, 215);
            this.sextoRepo.Name = "sextoRepo";
            this.sextoRepo.Size = new System.Drawing.Size(451, 39);
            this.sextoRepo.TabIndex = 16;
            this.sextoRepo.TabStop = true;
            this.sextoRepo.Text = "Cantidad de comandas que fueron atendidas en la cocina,";
            this.sextoRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SextoRepo_LinkClicked);
            // 
            // CuartoRepo
            // 
            this.CuartoRepo.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.CuartoRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CuartoRepo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CuartoRepo.Location = new System.Drawing.Point(18, 169);
            this.CuartoRepo.Name = "CuartoRepo";
            this.CuartoRepo.Size = new System.Drawing.Size(451, 30);
            this.CuartoRepo.TabIndex = 17;
            this.CuartoRepo.TabStop = true;
            this.CuartoRepo.Text = "Cantidad de comandas que se realizaron en el bar.";
            this.CuartoRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CuartoRepo_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.segundoRepo);
            this.groupBox2.Controls.Add(this.CuartoRepo);
            this.groupBox2.Controls.Add(this.QuintoRepo);
            this.groupBox2.Controls.Add(this.tercerRepo);
            this.groupBox2.Controls.Add(this.sextoRepo);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(282, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 276);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reportes";
            // 
            // lblErrores
            // 
            this.lblErrores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(0, 678);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(1011, 28);
            this.lblErrores.TabIndex = 51;
            this.lblErrores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFecha
            // 
            this.txtFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtFecha.CustomFormat = "dd-MM-yyyy";
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(417, 27);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(277, 28);
            this.txtFecha.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(300, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 67;
            this.label3.Text = "Fecha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkCyan;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.CadetBlue;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(282, 383);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.LabelForeColor = System.Drawing.Color.DarkGray;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(476, 276);
            this.chart1.TabIndex = 68;
            this.chart1.Text = "chart1";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1011, 706);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel segundoRepo;
        private System.Windows.Forms.LinkLabel tercerRepo;
        private System.Windows.Forms.LinkLabel QuintoRepo;
        private System.Windows.Forms.LinkLabel sextoRepo;
        private System.Windows.Forms.LinkLabel CuartoRepo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}