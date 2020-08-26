namespace CapaDiseño
{
    partial class FrmBartender
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrores = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lstOrdenesBebida = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviarComanda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgrgarBebida = new System.Windows.Forms.Button();
            this.btnAgregarComida = new System.Windows.Forms.Button();
            this.lstBebidas = new System.Windows.Forms.ListBox();
            this.lstComidas = new System.Windows.Forms.ListBox();
            this.rtbComanda = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 760);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(956, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 760);
            this.panel1.TabIndex = 27;
            // 
            // lblErrores
            // 
            this.lblErrores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(55, 705);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(901, 55);
            this.lblErrores.TabIndex = 29;
            this.lblErrores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnListo.FlatAppearance.BorderSize = 0;
            this.btnListo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnListo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListo.Location = new System.Drawing.Point(59, 307);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(458, 60);
            this.btnListo.TabIndex = 31;
            this.btnListo.Text = "L  I  S  T  O ";
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.BtnListo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnActualizar.Location = new System.Drawing.Point(523, 307);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(433, 60);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "A  C  T  U  A  L  I  Z  A  R";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // lstOrdenesBebida
            // 
            this.lstOrdenesBebida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstOrdenesBebida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrdenesBebida.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrdenesBebida.ForeColor = System.Drawing.Color.DarkGray;
            this.lstOrdenesBebida.FormattingEnabled = true;
            this.lstOrdenesBebida.ItemHeight = 22;
            this.lstOrdenesBebida.Location = new System.Drawing.Point(59, 91);
            this.lstOrdenesBebida.Name = "lstOrdenesBebida";
            this.lstOrdenesBebida.Size = new System.Drawing.Size(897, 220);
            this.lstOrdenesBebida.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(59, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(897, 46);
            this.label2.TabIndex = 34;
            this.label2.Text = "O R D E N E S   D E   B E B I D A S";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnEnviarComanda.Location = new System.Drawing.Point(59, 657);
            this.btnEnviarComanda.Name = "btnEnviarComanda";
            this.btnEnviarComanda.Size = new System.Drawing.Size(405, 49);
            this.btnEnviarComanda.TabIndex = 43;
            this.btnEnviarComanda.Text = "E N V I A R   C O M A N D A";
            this.btnEnviarComanda.UseVisualStyleBackColor = false;
            this.btnEnviarComanda.Click += new System.EventHandler(this.BtnEnviarComanda_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(716, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 48);
            this.label3.TabIndex = 42;
            this.label3.Text = "C O M I D A S";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(470, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 48);
            this.label4.TabIndex = 41;
            this.label4.Text = "B E B I D A S";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(59, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 48);
            this.label5.TabIndex = 40;
            this.label5.Text = "C O M A N D A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAgrgarBebida.Location = new System.Drawing.Point(470, 657);
            this.btnAgrgarBebida.Name = "btnAgrgarBebida";
            this.btnAgrgarBebida.Size = new System.Drawing.Size(240, 51);
            this.btnAgrgarBebida.TabIndex = 39;
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
            this.btnAgregarComida.Location = new System.Drawing.Point(716, 657);
            this.btnAgregarComida.Name = "btnAgregarComida";
            this.btnAgregarComida.Size = new System.Drawing.Size(240, 51);
            this.btnAgregarComida.TabIndex = 35;
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
            this.lstBebidas.Location = new System.Drawing.Point(470, 421);
            this.lstBebidas.Name = "lstBebidas";
            this.lstBebidas.Size = new System.Drawing.Size(240, 247);
            this.lstBebidas.TabIndex = 38;
            // 
            // lstComidas
            // 
            this.lstComidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstComidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstComidas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComidas.ForeColor = System.Drawing.Color.DarkGray;
            this.lstComidas.FormattingEnabled = true;
            this.lstComidas.ItemHeight = 19;
            this.lstComidas.Location = new System.Drawing.Point(716, 421);
            this.lstComidas.Name = "lstComidas";
            this.lstComidas.Size = new System.Drawing.Size(240, 247);
            this.lstComidas.TabIndex = 37;
            // 
            // rtbComanda
            // 
            this.rtbComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtbComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbComanda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbComanda.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbComanda.Location = new System.Drawing.Point(59, 421);
            this.rtbComanda.Name = "rtbComanda";
            this.rtbComanda.ReadOnly = true;
            this.rtbComanda.Size = new System.Drawing.Size(405, 230);
            this.rtbComanda.TabIndex = 36;
            this.rtbComanda.Text = "";
            // 
            // FrmBartender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1011, 760);
            this.Controls.Add(this.btnEnviarComanda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgrgarBebida);
            this.Controls.Add(this.btnAgregarComida);
            this.Controls.Add(this.lstBebidas);
            this.Controls.Add(this.lstComidas);
            this.Controls.Add(this.rtbComanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstOrdenesBebida);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBartender";
            this.Text = "FrmBartender";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListBox lstOrdenesBebida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviarComanda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgrgarBebida;
        private System.Windows.Forms.Button btnAgregarComida;
        private System.Windows.Forms.ListBox lstBebidas;
        private System.Windows.Forms.ListBox lstComidas;
        private System.Windows.Forms.RichTextBox rtbComanda;
    }
}