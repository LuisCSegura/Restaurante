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
    public partial class frmUsuarios : Form
    {
        LinkedList<Usuario> usuarios;
        UsuarioBOL usuBol;
        private Usuario seleccionado;
        public frmUsuarios()
        {
            InitializeComponent();
            usuBol = new UsuarioBOL();
            seleccionado = new Usuario();
            usuarios = new LinkedList<Usuario>();
            CargarTablaUsuarios();
        }


        /*
         * Method that loads the list of users in the table
         */
        private void CargarTablaUsuarios()
        {
            try
            {
                usuarios = usuBol.CargarTodos();
                dgvUsuarios.RowCount=0;
;                foreach (Usuario usuario in usuarios)
                {
                    int n = dgvUsuarios.Rows.Add();
                    dgvUsuarios.Rows[n].Cells[0].Value = usuario.nombre;
                    dgvUsuarios.Rows[n].Cells[1].Value = usuario.GetTipoNombre();
                    dgvUsuarios.Rows[n].Cells[2].Value = usuario.codigo;
                    dgvUsuarios.Rows[n].Cells[3].Value = usuario.cedula;

                }
            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }



        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblErrores.Text = "";
            if (e.RowIndex != -1)
            {
                Usuario u = usuarios.ElementAt(e.RowIndex);
                seleccionado.id = u.id;
                seleccionado.nombre = u.nombre;
                seleccionado.cedula = u.cedula;
                seleccionado.contrasenna = u.contrasenna;
                seleccionado.tipo = u.tipo;
                seleccionado.codigo= u.codigo;
                txtNombreUsuario.Text = seleccionado.nombre;
                txtCedula.Text = seleccionado.cedula;
                txtContrasenna.Text = DesEncriptar(seleccionado.contrasenna);
                cbxTipo.SelectedIndex = seleccionado.tipo;
            }
        }

        private void DgvUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblErrores.Text = "";
            if (e.RowIndex != -1)
            {
                Usuario u = usuarios.ElementAt(e.RowIndex);
                seleccionado.id = u.id;
                seleccionado.nombre = u.nombre;
                seleccionado.cedula = u.cedula;
                seleccionado.contrasenna = u.contrasenna;
                seleccionado.tipo = u.tipo;
                seleccionado.codigo = u.codigo;
                txtNombreUsuario.Text = seleccionado.nombre;
                txtCedula.Text = seleccionado.cedula;
                txtContrasenna.Text = DesEncriptar(seleccionado.contrasenna);
                cbxTipo.SelectedIndex = seleccionado.tipo;
            }
        }
        /*
         * Method that encrypts user passwords
         */
        public static string DesEncriptar(string contrasenna)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(contrasenna);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }



        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                if (seleccionado.id > 0)
                {
                    if (MessageBox.Show("Desea Eliminar el usuario: "+seleccionado.nombre,
                        "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        usuBol.Eliminar(seleccionado);
                        CargarTablaUsuarios();
                        seleccionado = new Usuario();
                        LimpiarDatos();
                    }
                        
                }
                else
                {
                    throw new Exception("Debe seleccionar un Usuario");
                }
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                LimpiarDatos();
                seleccionado = new Usuario();
            }
            catch (Exception ex)
            {

                lblErrores.Text = ex.Message;
            }
        }

        /*
         * Method that cleans data from text fields
         */
        private void LimpiarDatos()
        {
            seleccionado = new Usuario();
            txtNombreUsuario.Text = "";
            txtCedula.Text = "";
            txtContrasenna.Text = "";
            cbxTipo.SelectedIndex = -1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {


                seleccionado.nombre = txtNombreUsuario.Text;
                seleccionado.cedula = txtCedula.Text;
                seleccionado.contrasenna = txtContrasenna.Text;
                seleccionado.tipo = cbxTipo.SelectedIndex;

                if (usuBol.Autenticar(seleccionado))
                {
                    if (MessageBox.Show("El usuario: " + seleccionado.nombre + " ya existe en el sistema.\n\nDesea restaurarlo? ",
                       "Restaurar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        usuBol.Restaurar(seleccionado);
                        CargarTablaUsuarios();
                        seleccionado = new Usuario();
                        LimpiarDatos();

                    }

                }
                else
                {
                    if (seleccionado.id > 0)
                    {

                        usuBol.Editar(seleccionado);
                    }
                    else
                    {
                        usuBol.InsertarNuevo(seleccionado);
                    }
                    CargarTablaUsuarios();
                    seleccionado = new Usuario();
                    LimpiarDatos();

                }
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }




    }
}
