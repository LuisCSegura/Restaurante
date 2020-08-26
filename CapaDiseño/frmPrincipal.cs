using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CapaDiseño
{
    public partial class frmPrincipal : Form
    {
        Usuario usuario;
        Form inicio;
        Form parent;
        public frmPrincipal(Usuario u,Form parent)
        {
            InitializeComponent();
            usuario = u;
            inicio = new Form();
            this.parent = parent;
            AsignarPermisosForm();
            AgregarFormEnPanel(inicio);
        }
        private void AsignarPermisosForm()
        {
            lblUsuario.Text = usuario.nombre;
            lblTipoUsuario.Text = usuario.GetTipoNombre().ToUpper();
            if (usuario.tipo == 0)
            {
                inicio = new FrmCajero();
            }
            else
            {
                btnSalon.Enabled = false;
                btnBebidas.Enabled = false;
                btnComidas.Enabled = false;
                btnUusarios.Enabled = false;
                switch (usuario.tipo)
                {
                    case 1:
                        inicio = new  FrmCajero();
                        break;
                    case 2:
                        inicio = new FrmJefeSaloneros();
                        break;
                    case 3:
                        inicio = new frmSalonero(usuario);
                        break;
                    case 4:
                        inicio = new FrmBartender(usuario);
                        break;
                    case 5:
                        inicio = new FrmCocinero();
                        break;
                }
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void LblPlus_Click(object sender, EventArgs e)
        {
        }

        private void PbxSalir_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void PbxSalir_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExpandir_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 255)
            {
                pnlMenu.Width = 100;
                btnExpandir.Text = "        ►";
            }
            else
            {
                pnlMenu.Width = 255;
                btnExpandir.Text = "        ◄            M I N I M I Z A R";
            }
        }
        private void AgregarFormEnPanel(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form frm = formHijo;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(frm);
            this.pnlContenedor.Tag=frm;
            frm.Show(); 
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AgregarFormEnPanel(new frmUsuarios());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir de su cuenta?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                parent.Visible = true;
            }
        }

        private void btnComidas_click(object sender, EventArgs e)
        {
            AgregarFormEnPanel(new FrmComida());
        }

        private void BtnBebidas_Click(object sender, EventArgs e)
        {
            AgregarFormEnPanel(new FrmBebida());
        }

        private void BtnSalon_Click(object sender, EventArgs e)
        {
            AgregarFormEnPanel(new frmSalon());
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            AgregarFormEnPanel(inicio);
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
