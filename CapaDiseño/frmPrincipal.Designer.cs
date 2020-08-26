namespace CapaDiseño
{
    partial class frmPrincipal
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.btnUusarios = new System.Windows.Forms.Button();
            this.btnComidas = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnSalon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnExpandir);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.lblUsuario);
            this.pnlMenu.Controls.Add(this.lblTipoUsuario);
            this.pnlMenu.Controls.Add(this.btnUusarios);
            this.pnlMenu.Controls.Add(this.btnComidas);
            this.pnlMenu.Controls.Add(this.btnBebidas);
            this.pnlMenu.Controls.Add(this.btnSalon);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(340, 760);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMenu_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.Image = global::CapaDiseño.Properties.Resources.home_icon_64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-7, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "                         I N I C I O";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnExpandir
            // 
            this.btnExpandir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExpandir.FlatAppearance.BorderSize = 0;
            this.btnExpandir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExpandir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpandir.Location = new System.Drawing.Point(0, 694);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(340, 66);
            this.btnExpandir.TabIndex = 8;
            this.btnExpandir.Text = "        ◄            M I N I M I Z A R";
            this.btnExpandir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpandir.UseVisualStyleBackColor = false;
            this.btnExpandir.Click += new System.EventHandler(this.BtnExpandir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 53);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = " ————          ●          ————";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaDiseño.Properties.Resources.RestaurantIcon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSalir.Image = global::CapaDiseño.Properties.Resources.exit_icon_64;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(-7, 568);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(347, 70);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "                         S A L I R";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblUsuario.Location = new System.Drawing.Point(121, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(219, 47);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTipoUsuario.Location = new System.Drawing.Point(129, 77);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(211, 19);
            this.lblTipoUsuario.TabIndex = 2;
            this.lblTipoUsuario.Text = "TIPO USUARIO";
            this.lblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTipoUsuario.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // btnUusarios
            // 
            this.btnUusarios.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUusarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUusarios.FlatAppearance.BorderSize = 0;
            this.btnUusarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUusarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUusarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUusarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUusarios.Image = global::CapaDiseño.Properties.Resources.user_icon_64;
            this.btnUusarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUusarios.Location = new System.Drawing.Point(-7, 492);
            this.btnUusarios.Name = "btnUusarios";
            this.btnUusarios.Size = new System.Drawing.Size(347, 70);
            this.btnUusarios.TabIndex = 4;
            this.btnUusarios.Text = "                         U S U A R I O S";
            this.btnUusarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUusarios.UseVisualStyleBackColor = false;
            this.btnUusarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnComidas
            // 
            this.btnComidas.BackColor = System.Drawing.Color.DarkCyan;
            this.btnComidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnComidas.FlatAppearance.BorderSize = 0;
            this.btnComidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnComidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComidas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnComidas.Image = global::CapaDiseño.Properties.Resources.food_icon_64;
            this.btnComidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComidas.Location = new System.Drawing.Point(-7, 416);
            this.btnComidas.Name = "btnComidas";
            this.btnComidas.Size = new System.Drawing.Size(347, 70);
            this.btnComidas.TabIndex = 5;
            this.btnComidas.Text = "                         C O M I D A S";
            this.btnComidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComidas.UseVisualStyleBackColor = false;
            this.btnComidas.Click += new System.EventHandler(this.btnComidas_click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBebidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBebidas.FlatAppearance.BorderSize = 0;
            this.btnBebidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBebidas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBebidas.Image = global::CapaDiseño.Properties.Resources.drink_icon_64;
            this.btnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBebidas.Location = new System.Drawing.Point(-7, 340);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(347, 70);
            this.btnBebidas.TabIndex = 6;
            this.btnBebidas.Text = "                         B E B I D A S ";
            this.btnBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBebidas.UseVisualStyleBackColor = false;
            this.btnBebidas.Click += new System.EventHandler(this.BtnBebidas_Click);
            // 
            // btnSalon
            // 
            this.btnSalon.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSalon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalon.FlatAppearance.BorderSize = 0;
            this.btnSalon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSalon.Image = global::CapaDiseño.Properties.Resources.table_icon_64;
            this.btnSalon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalon.Location = new System.Drawing.Point(-7, 264);
            this.btnSalon.Name = "btnSalon";
            this.btnSalon.Size = new System.Drawing.Size(347, 70);
            this.btnSalon.TabIndex = 7;
            this.btnSalon.Text = "                         S A L O N ";
            this.btnSalon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalon.UseVisualStyleBackColor = false;
            this.btnSalon.Click += new System.EventHandler(this.BtnSalon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 56);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = " ————          ●          ————";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(340, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1011, 760);
            this.pnlContenedor.TabIndex = 1;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 760);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUusarios;
        private System.Windows.Forms.Button btnSalon;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnComidas;
        private System.Windows.Forms.Button btnExpandir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}