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
using CapaLogica;

namespace CapaDiseño
{
    public partial class frmLogin : Form
    {
        UsuarioBOL usuBol = new UsuarioBOL();
        public frmLogin()
        {
            InitializeComponent();
        }

       
        private void TxtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TxtContra_Enter(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (txtContra.Text == "CONTRASEÑA")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.LightGray;
                txtContra.UseSystemPasswordChar = true;

            }
        }

        private void TxtContra_Leave(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (txtContra.Text == "")
            {
                txtContra.Text = "CONTRASEÑA";
                txtContra.ForeColor = Color.DimGray;
                txtContra.UseSystemPasswordChar = false;

            }
        }

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                Usuario usuario = new Usuario();
                usuario.nombre = txtUsuario.Text;
                usuario.contrasenna = txtContra.Text;
                usuario.cedula = "000000000";
                usuBol.Loguear(usuario);
                if (usuario.id > 0)
                {
                    frmPrincipal p = new frmPrincipal(usuario,this);
                    p.Visible = true;
                    txtUsuario.Text = "USUARIO";
                    txtContra.Text = "CONTRASEÑA";
                    txtContra.ForeColor = Color.DimGray;
                    txtUsuario.ForeColor = Color.DimGray;
                    txtContra.UseSystemPasswordChar = false;
                    this.Visible = false;
                }
                else
                {
                    throw new Exception("Los datos ingresados no coinciden con ningun usuario");
                }
            }
            catch (Exception ex)
            {

                lblErrores.Text=ex.Message;
            }
        }
    }
}
