namespace CapaDiseño
{
    partial class FrmJefeSaloneros
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
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnRecepcion = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPrincipal.Location = new System.Drawing.Point(12, 12);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(470, 42);
            this.btnPrincipal.TabIndex = 54;
            this.btnPrincipal.Text = "P R I N C I P A L";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.BtnPrincipal_Click);
            // 
            // btnRecepcion
            // 
            this.btnRecepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRecepcion.FlatAppearance.BorderSize = 0;
            this.btnRecepcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRecepcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepcion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepcion.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRecepcion.Location = new System.Drawing.Point(488, 12);
            this.btnRecepcion.Name = "btnRecepcion";
            this.btnRecepcion.Size = new System.Drawing.Size(511, 42);
            this.btnRecepcion.TabIndex = 55;
            this.btnRecepcion.Text = "R E C E P C I Ó N ";
            this.btnRecepcion.UseVisualStyleBackColor = false;
            this.btnRecepcion.Click += new System.EventHandler(this.BtnRecepcion_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 60);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1011, 700);
            this.pnlContenedor.TabIndex = 56;
            // 
            // FrmJefeSaloneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1011, 760);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.btnRecepcion);
            this.Controls.Add(this.btnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJefeSaloneros";
            this.Text = "FrmJefeSaloneros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Button btnRecepcion;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}