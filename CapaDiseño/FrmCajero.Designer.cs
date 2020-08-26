namespace CapaDiseño
{
    partial class FrmCajero
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
            this.lstComandas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOrdenes = new System.Windows.Forms.ListBox();
            this.bSeleccionarComanda = new System.Windows.Forms.Button();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbFactura = new System.Windows.Forms.RichTextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstComandas
            // 
            this.lstComandas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstComandas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstComandas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComandas.ForeColor = System.Drawing.Color.DarkGray;
            this.lstComandas.FormattingEnabled = true;
            this.lstComandas.ItemHeight = 22;
            this.lstComandas.Location = new System.Drawing.Point(55, 101);
            this.lstComandas.Name = "lstComandas";
            this.lstComandas.Size = new System.Drawing.Size(209, 550);
            this.lstComandas.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(55, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 52);
            this.label3.TabIndex = 22;
            this.label3.Text = "C O M A N D A S";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrores
            // 
            this.lblErrores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(0, 708);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(1011, 52);
            this.lblErrores.TabIndex = 23;
            this.lblErrores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(270, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "O R D E N E S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstOrdenes
            // 
            this.lstOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrdenes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.lstOrdenes.ForeColor = System.Drawing.Color.DarkGray;
            this.lstOrdenes.FormattingEnabled = true;
            this.lstOrdenes.ItemHeight = 22;
            this.lstOrdenes.Location = new System.Drawing.Point(270, 101);
            this.lstOrdenes.Name = "lstOrdenes";
            this.lstOrdenes.Size = new System.Drawing.Size(312, 550);
            this.lstOrdenes.TabIndex = 24;
            // 
            // bSeleccionarComanda
            // 
            this.bSeleccionarComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bSeleccionarComanda.FlatAppearance.BorderSize = 0;
            this.bSeleccionarComanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bSeleccionarComanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSeleccionarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSeleccionarComanda.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionarComanda.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bSeleccionarComanda.Location = new System.Drawing.Point(55, 650);
            this.bSeleccionarComanda.Name = "bSeleccionarComanda";
            this.bSeleccionarComanda.Size = new System.Drawing.Size(209, 55);
            this.bSeleccionarComanda.TabIndex = 26;
            this.bSeleccionarComanda.Text = "S E L E C C I O N A R";
            this.bSeleccionarComanda.UseVisualStyleBackColor = false;
            this.bSeleccionarComanda.Click += new System.EventHandler(this.BSeleccionarComanda_Click);
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarOrden.FlatAppearance.BorderSize = 0;
            this.btnAgregarOrden.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarOrden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarOrden.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOrden.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregarOrden.Location = new System.Drawing.Point(270, 650);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(312, 55);
            this.btnAgregarOrden.TabIndex = 27;
            this.btnAgregarOrden.Text = "A G R E G A R   A   F A C T U R A";
            this.btnAgregarOrden.UseVisualStyleBackColor = false;
            this.btnAgregarOrden.Click += new System.EventHandler(this.BtnAgregarOrden_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(588, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 52);
            this.label2.TabIndex = 29;
            this.label2.Text = "F A C T U R A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbFactura
            // 
            this.rtbFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtbFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFactura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFactura.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbFactura.Location = new System.Drawing.Point(588, 101);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.ReadOnly = true;
            this.rtbFactura.Size = new System.Drawing.Size(366, 543);
            this.rtbFactura.TabIndex = 28;
            this.rtbFactura.Text = "     Seleccione una Comanda";
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFacturar.Location = new System.Drawing.Point(773, 650);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(181, 55);
            this.btnFacturar.TabIndex = 30;
            this.btnFacturar.Text = "F A C T U R A R";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelarFactura.FlatAppearance.BorderSize = 0;
            this.btnCancelarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFactura.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFactura.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelarFactura.Location = new System.Drawing.Point(588, 650);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(179, 55);
            this.btnCancelarFactura.TabIndex = 31;
            this.btnCancelarFactura.Text = "C A N C E L A R";
            this.btnCancelarFactura.UseVisualStyleBackColor = false;
            this.btnCancelarFactura.Click += new System.EventHandler(this.BtnCancelarFactura_Click);
            // 
            // FrmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1011, 760);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbFactura);
            this.Controls.Add(this.btnAgregarOrden);
            this.Controls.Add(this.bSeleccionarComanda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOrdenes);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstComandas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCajero";
            this.Text = "FrmCajero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstComandas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOrdenes;
        private System.Windows.Forms.Button bSeleccionarComanda;
        private System.Windows.Forms.Button btnAgregarOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbFactura;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCancelarFactura;
    }
}