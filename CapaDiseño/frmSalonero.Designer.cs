namespace CapaDiseño
{
    partial class frmSalonero
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvNotificaciones = new System.Windows.Forms.ListView();
            this.btnMesa6 = new System.Windows.Forms.Button();
            this.btnMesa5 = new System.Windows.Forms.Button();
            this.btnMesa4 = new System.Windows.Forms.Button();
            this.btnMesa3 = new System.Windows.Forms.Button();
            this.btnMesa2 = new System.Windows.Forms.Button();
            this.btnMesa1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEnviarComanda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgrgarBebida = new System.Windows.Forms.Button();
            this.btnAgregarComida = new System.Windows.Forms.Button();
            this.lstBebidas = new System.Windows.Forms.ListBox();
            this.lstComidas = new System.Windows.Forms.ListBox();
            this.rtbComanda = new System.Windows.Forms.RichTextBox();
            this.lblErrores = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(956, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 759);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 759);
            this.panel2.TabIndex = 6;
            // 
            // lblSeccion
            // 
            this.lblSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.ForeColor = System.Drawing.Color.Gray;
            this.lblSeccion.Location = new System.Drawing.Point(0, 106);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(900, 53);
            this.lblSeccion.TabIndex = 7;
            this.lblSeccion.Text = "S E C C I Ó N    ";
            this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeccion.Click += new System.EventHandler(this.LblSeccion_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvNotificaciones);
            this.panel3.Controls.Add(this.btnMesa6);
            this.panel3.Controls.Add(this.btnMesa5);
            this.panel3.Controls.Add(this.btnMesa4);
            this.panel3.Controls.Add(this.btnMesa3);
            this.panel3.Controls.Add(this.btnMesa2);
            this.panel3.Controls.Add(this.btnMesa1);
            this.panel3.Controls.Add(this.lblSeccion);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(55, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 238);
            this.panel3.TabIndex = 6;
            // 
            // lvNotificaciones
            // 
            this.lvNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lvNotificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvNotificaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNotificaciones.ForeColor = System.Drawing.Color.Gray;
            this.lvNotificaciones.Location = new System.Drawing.Point(0, 49);
            this.lvNotificaciones.Name = "lvNotificaciones";
            this.lvNotificaciones.Size = new System.Drawing.Size(901, 50);
            this.lvNotificaciones.TabIndex = 13;
            this.lvNotificaciones.UseCompatibleStateImageBehavior = false;
            this.lvNotificaciones.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnMesa6
            // 
            this.btnMesa6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMesa6.FlatAppearance.BorderSize = 0;
            this.btnMesa6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMesa6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMesa6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesa6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMesa6.Location = new System.Drawing.Point(756, 165);
            this.btnMesa6.Name = "btnMesa6";
            this.btnMesa6.Size = new System.Drawing.Size(145, 73);
            this.btnMesa6.TabIndex = 9;
            this.btnMesa6.Text = "M E S A   ";
            this.btnMesa6.UseVisualStyleBackColor = false;
            this.btnMesa6.Click += new System.EventHandler(this.BtnMesa6_Click);
            // 
            // btnMesa5
            // 
            this.btnMesa5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMesa5.FlatAppearance.BorderSize = 0;
            this.btnMesa5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMesa5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMesa5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesa5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMesa5.Location = new System.Drawing.Point(605, 165);
            this.btnMesa5.Name = "btnMesa5";
            this.btnMesa5.Size = new System.Drawing.Size(145, 73);
            this.btnMesa5.TabIndex = 12;
            this.btnMesa5.Text = "M E S A   ";
            this.btnMesa5.UseVisualStyleBackColor = false;
            this.btnMesa5.Click += new System.EventHandler(this.BtnMesa5_Click);
            // 
            // btnMesa4
            // 
            this.btnMesa4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMesa4.FlatAppearance.BorderSize = 0;
            this.btnMesa4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMesa4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMesa4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesa4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMesa4.Location = new System.Drawing.Point(454, 165);
            this.btnMesa4.Name = "btnMesa4";
            this.btnMesa4.Size = new System.Drawing.Size(145, 73);
            this.btnMesa4.TabIndex = 11;
            this.btnMesa4.Text = "M E S A   ";
            this.btnMesa4.UseVisualStyleBackColor = false;
            this.btnMesa4.Click += new System.EventHandler(this.BtnMesa4_Click);
            // 
            // btnMesa3
            // 
            this.btnMesa3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMesa3.FlatAppearance.BorderSize = 0;
            this.btnMesa3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMesa3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMesa3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesa3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMesa3.Location = new System.Drawing.Point(303, 165);
            this.btnMesa3.Name = "btnMesa3";
            this.btnMesa3.Size = new System.Drawing.Size(145, 73);
            this.btnMesa3.TabIndex = 10;
            this.btnMesa3.Text = "M E S A   ";
            this.btnMesa3.UseVisualStyleBackColor = false;
            this.btnMesa3.Click += new System.EventHandler(this.BtnMesa3_Click);
            // 
            // btnMesa2
            // 
            this.btnMesa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMesa2.FlatAppearance.BorderSize = 0;
            this.btnMesa2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMesa2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMesa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesa2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMesa2.Location = new System.Drawing.Point(151, 165);
            this.btnMesa2.Name = "btnMesa2";
            this.btnMesa2.Size = new System.Drawing.Size(146, 73);
            this.btnMesa2.TabIndex = 9;
            this.btnMesa2.Text = "M E S A   ";
            this.btnMesa2.UseVisualStyleBackColor = false;
            this.btnMesa2.Click += new System.EventHandler(this.BtnMesa2_Click);
            // 
            // btnMesa1
            // 
            this.btnMesa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMesa1.FlatAppearance.BorderSize = 0;
            this.btnMesa1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMesa1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMesa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesa1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMesa1.Location = new System.Drawing.Point(0, 165);
            this.btnMesa1.Name = "btnMesa1";
            this.btnMesa1.Size = new System.Drawing.Size(145, 73);
            this.btnMesa1.TabIndex = 8;
            this.btnMesa1.Text = "M E S A   ";
            this.btnMesa1.UseVisualStyleBackColor = false;
            this.btnMesa1.Click += new System.EventHandler(this.BtnMesa1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnEnviarComanda);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnAgrgarBebida);
            this.panel4.Controls.Add(this.btnAgregarComida);
            this.panel4.Controls.Add(this.lstBebidas);
            this.panel4.Controls.Add(this.lstComidas);
            this.panel4.Controls.Add(this.rtbComanda);
            this.panel4.Controls.Add(this.lblErrores);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(55, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 521);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // btnEnviarComanda
            // 
            this.btnEnviarComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEnviarComanda.FlatAppearance.BorderSize = 0;
            this.btnEnviarComanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEnviarComanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnviarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarComanda.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarComanda.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEnviarComanda.Location = new System.Drawing.Point(0, 397);
            this.btnEnviarComanda.Name = "btnEnviarComanda";
            this.btnEnviarComanda.Size = new System.Drawing.Size(409, 73);
            this.btnEnviarComanda.TabIndex = 21;
            this.btnEnviarComanda.Text = "E N V I A R   C O M A N D A";
            this.btnEnviarComanda.UseVisualStyleBackColor = false;
            this.btnEnviarComanda.Click += new System.EventHandler(this.BtnEnviarComanda_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(661, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 48);
            this.label3.TabIndex = 20;
            this.label3.Text = "C O M I D A S";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(415, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 48);
            this.label2.TabIndex = 19;
            this.label2.Text = "B E B I D A S";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "C O M A N D A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgrgarBebida
            // 
            this.btnAgrgarBebida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgrgarBebida.FlatAppearance.BorderSize = 0;
            this.btnAgrgarBebida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgrgarBebida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgrgarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrgarBebida.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrgarBebida.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgrgarBebida.Location = new System.Drawing.Point(415, 397);
            this.btnAgrgarBebida.Name = "btnAgrgarBebida";
            this.btnAgrgarBebida.Size = new System.Drawing.Size(240, 73);
            this.btnAgrgarBebida.TabIndex = 17;
            this.btnAgrgarBebida.Text = "A G R E G A R";
            this.btnAgrgarBebida.UseVisualStyleBackColor = false;
            this.btnAgrgarBebida.Click += new System.EventHandler(this.BtnAgrgarBebida_Click);
            // 
            // btnAgregarComida
            // 
            this.btnAgregarComida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarComida.FlatAppearance.BorderSize = 0;
            this.btnAgregarComida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarComida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarComida.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarComida.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregarComida.Location = new System.Drawing.Point(661, 397);
            this.btnAgregarComida.Name = "btnAgregarComida";
            this.btnAgregarComida.Size = new System.Drawing.Size(240, 73);
            this.btnAgregarComida.TabIndex = 13;
            this.btnAgregarComida.Text = "A G R E G A R";
            this.btnAgregarComida.UseVisualStyleBackColor = false;
            this.btnAgregarComida.Click += new System.EventHandler(this.BtnAgregarComida_Click);
            // 
            // lstBebidas
            // 
            this.lstBebidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstBebidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBebidas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBebidas.ForeColor = System.Drawing.Color.DarkGray;
            this.lstBebidas.FormattingEnabled = true;
            this.lstBebidas.ItemHeight = 19;
            this.lstBebidas.Location = new System.Drawing.Point(415, 57);
            this.lstBebidas.Name = "lstBebidas";
            this.lstBebidas.Size = new System.Drawing.Size(240, 342);
            this.lstBebidas.TabIndex = 16;
            // 
            // lstComidas
            // 
            this.lstComidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstComidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstComidas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComidas.ForeColor = System.Drawing.Color.DarkGray;
            this.lstComidas.FormattingEnabled = true;
            this.lstComidas.ItemHeight = 19;
            this.lstComidas.Location = new System.Drawing.Point(661, 57);
            this.lstComidas.Name = "lstComidas";
            this.lstComidas.Size = new System.Drawing.Size(240, 342);
            this.lstComidas.TabIndex = 15;
            // 
            // rtbComanda
            // 
            this.rtbComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtbComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbComanda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbComanda.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbComanda.Location = new System.Drawing.Point(0, 57);
            this.rtbComanda.Name = "rtbComanda";
            this.rtbComanda.ReadOnly = true;
            this.rtbComanda.Size = new System.Drawing.Size(409, 335);
            this.rtbComanda.TabIndex = 14;
            this.rtbComanda.Text = "     Seleccione una Mesa ";
            // 
            // lblErrores
            // 
            this.lblErrores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(0, 479);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(901, 42);
            this.lblErrores.TabIndex = 13;
            this.lblErrores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSalonero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1011, 759);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalonero";
            this.Text = "frmSalonero";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtbComanda;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Button btnMesa6;
        private System.Windows.Forms.Button btnMesa5;
        private System.Windows.Forms.Button btnMesa4;
        private System.Windows.Forms.Button btnMesa3;
        private System.Windows.Forms.Button btnMesa2;
        private System.Windows.Forms.Button btnMesa1;
        private System.Windows.Forms.ListBox lstComidas;
        private System.Windows.Forms.ListBox lstBebidas;
        private System.Windows.Forms.Button btnAgrgarBebida;
        private System.Windows.Forms.Button btnAgregarComida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviarComanda;
        private System.Windows.Forms.ListView lvNotificaciones;
    }
}