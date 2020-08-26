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
    public partial class frmSalon : Form
    {
        LinkedList<Seccion> secciones;
        SalonBOL salBol;
        UsuarioBOL usuBol;
        Seccion seleccionada;
        LinkedList<Usuario> saloneros;
        public frmSalon()
        {
            InitializeComponent();
            secciones = new LinkedList<Seccion>();
            salBol = new SalonBOL();
            usuBol = new UsuarioBOL();
            seleccionada = new Seccion();
            saloneros = new LinkedList<Usuario>();
            CargarTablaSecciones();
            CargarSaloneros();
        }

        /*
         * Method that loads the list of waiters in the combo box
         */
        private void CargarSaloneros()
        {
            try
            {
                saloneros = usuBol.CargarSaloneros();
                foreach (Usuario salonero in saloneros)
                {
                    cbxSalonero.Items.Add(salonero);
                }
            }
            catch (Exception e)
            {

                lblErrores.Text=e.Message;
            }
        }

        /*
         * Method that loads the list of sections in the table
         */
        private void CargarTablaSecciones()
        {
            try
            {
                secciones = salBol.CargarTodas();
                dgvSeccion.RowCount = 0;
                foreach (Seccion seccion in secciones)
                {
                    int n = dgvSeccion.Rows.Add();
                    dgvSeccion.Rows[n].Cells[0].Value = seccion.numero;
                    dgvSeccion.Rows[n].Cells[1].Value = seccion.cantidadMesas;
                    dgvSeccion.Rows[n].Cells[2].Value = seccion.salonero.ToString();

                }

            }
            catch (Exception e )
            {

                lblErrores.Text=e.Message;
            }

        }




        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {

                lblErrores.Text = ex.Message;
            }
        }
        private void LimpiarDatos()
        {
            seleccionada = new Seccion();
            nudNumeroSeccion.Value=0;
            cbxSalonero.SelectedIndex = -1;
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }



        /*
         * method that loads the data of the selected section into a new object
         */
        private void CargarDatosSelec(int select)
        {
            Seccion s = secciones.ElementAt(select);
            seleccionada.id = s.id;
            seleccionada.numero = s.numero;
            seleccionada.cantidadMesas = s.cantidadMesas;
            seleccionada.salonero = s.salonero;
            seleccionada.mesas = s.mesas;
            nudNumeroSeccion.Value = seleccionada.numero;
            for (int i = 0; i < saloneros.Count; i++)
            {
                if (saloneros.ElementAt(i).Equals(seleccionada.salonero))
                {
                    cbxSalonero.SelectedIndex = i;
                } 
            }
        }
        private void DgvSeccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblErrores.Text = "";
            if (e.RowIndex != -1)
            {
                CargarDatosSelec(e.RowIndex);
                
            }
        }

        private void DgvSeccion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblErrores.Text = "";
            if (e.RowIndex != -1)
            {
                CargarDatosSelec(e.RowIndex);

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                foreach (Seccion seccion in secciones)
                {
                    if (seccion.salonero.Equals((Usuario)cbxSalonero.SelectedItem)&&seccion.id!=seleccionada.id)
                    {
                        throw new Exception("Este salonero ya está encargado de una sección");
                    }
                }
                if (seleccionada.id > 0)
                {
                    seleccionada.numero = (int)nudNumeroSeccion.Value;
                    if (cbxSalonero.SelectedIndex >= 0)
                    {
                        seleccionada.salonero = (Usuario)cbxSalonero.SelectedItem;
                    }
                    else
                    {
                        throw new Exception("Debe seleccionar un Salonero");
                    }
                    salBol.Actualizar(seleccionada);
                    CargarTablaSecciones();
                    LimpiarDatos();
                }
                else
                {
                    Seccion s = new Seccion();
                    s.numero = (int)nudNumeroSeccion.Value;
                    if (cbxSalonero.SelectedIndex >= 0)
                    {
                        s.salonero = (Usuario)cbxSalonero.SelectedItem;
                    }
                    else
                    {
                        throw new Exception("Debe seleccionar un Salonero");
                    }
                    salBol.InsertarNuevo(s);
                    CargarTablaSecciones();
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {

                lblErrores.Text=ex.Message;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (seleccionada.id > 0)
            {
                try
                {
                    salBol.Eliminar(seleccionada);
                    LimpiarDatos();
                    CargarTablaSecciones();
                }
                catch (Exception exe)
                {

                    lblErrores.Text=exe.Message;
                }
            }
            else
            {
                throw new Exception("Debe seleccionar una seccion");
            }
            
        }
    }
}
