using CapaLogica;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño
{
    public partial class FrmReservas : Form
    {
        private ReservaBOL rbo;
        private Reserva reserva;
        private SalonBOL sbo;
        private Seccion s;
        private Mesa m;
        LinkedList<Reserva> reservas;
        LinkedList<Mesa> mesas;
        LinkedList<Seccion> secciones;
        LinkedList<Seccion> seccionesTabla;
        SalonBOL salBol;
        UsuarioBOL usuBol;
        Seccion seleccionada;
        LinkedList<Usuario> saloneros;
        public FrmReservas()
        {
            InitializeComponent();
            rbo = new ReservaBOL();
            reserva = new Reserva();
            sbo = new SalonBOL();
            s = new Seccion();
            m = new Mesa();
            seccionesTabla = new LinkedList<Seccion>();
            salBol = new SalonBOL();
            usuBol = new UsuarioBOL();
            seleccionada = new Seccion();
            saloneros = new LinkedList<Usuario>();
            CargarTablaSecciones();
            CargarSaloneros();
            liberar_mesa();
            CargarTablaReservas();
            
            // CargarSecciones();
            txtFecha.MinDate = DateTime.Now.Date;

        }
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

                lblErrores.Text = e.Message;
            }
        }
        private void CargarTablaSecciones()
        {
            try
            {
                seccionesTabla = salBol.CargarTodas();
                dgvSeccion.RowCount = 0;
                foreach (Seccion seccion in seccionesTabla)
                {
                    int n = dgvSeccion.Rows.Add();
                    dgvSeccion.Rows[n].Cells[0].Value = seccion.numero;
                    dgvSeccion.Rows[n].Cells[1].Value = seccion.cantidadMesas;
                    dgvSeccion.Rows[n].Cells[2].Value = seccion.salonero.ToString();

                }

            }
            catch (Exception e)
            {

                lblErrores.Text = e.Message;
            }

        }

        private void FrmJefeSaloneros_Load(object sender, EventArgs e)
        {
            rbo = new ReservaBOL();
            reserva = new Reserva();
            sbo = new SalonBOL();
            s = new Seccion();
            m = new Mesa();
            txtFecha.MinDate = DateTime.Now.Date;
        }

        /*
         * Method that validates if the table can be released.
         */
        public void liberar_mesa()
        {

            reservas = rbo.CargarTodos();
            
            foreach (Reserva reserva in reservas)
            {
                if (reserva != null)
                {
                    DateTime f = new DateTime();
                    f = Convert.ToDateTime(reserva.hora);
                    int horaCbx = f.Hour;

                    int hora = int.Parse(DateTime.Now.Hour.ToString());
                   
                    if (f.Hour == 0)
                    {
                        horaCbx = 12;

                    }
                    if (hora == 0)
                    {
                        hora = 12;
                    }
                    if(reserva.fecha == DateTime.Now.Date)
                    {

                    }else if ((DateTime.Now.AddDays(+1).Date == reserva.fecha_reser && reserva.estado == "Pendiente" && hora == 23) 
                        || (DateTime.Now.Date == reserva.fecha_reser && hora > horaCbx) || (DateTime.Now.Date > reserva.fecha_reser))
                    {
                        rbo.Eliminar(reserva);
                        CargarTablaReservas();

                    }
                }

            }
        }

        /*
         * Method that loads the reservations in the table.
         */
        private void CargarTablaReservas()
        {
            try
            {
                reservas = rbo.CargarTodos();
                dgvReservas.RowCount = 0;
                foreach (Reserva reserva in reservas)
                {
                    int n = dgvReservas.Rows.Add();
                    dgvReservas.Rows[n].Cells[0].Value = reserva.id;
                    dgvReservas.Rows[n].Cells[1].Value = reserva.cedula;
                    dgvReservas.Rows[n].Cells[2].Value = reserva.nombre;
                    dgvReservas.Rows[n].Cells[3].Value = reserva.fecha;
                    dgvReservas.Rows[n].Cells[4].Value = reserva.fecha_reser;
                    dgvReservas.Rows[n].Cells[5].Value = reserva.hora;
                    dgvReservas.Rows[n].Cells[6].Value = reserva.cant_personas;
                    dgvReservas.Rows[n].Cells[7].Value = reserva.telefono;
                    dgvReservas.Rows[n].Cells[8].Value = reserva.seccion;
                    dgvReservas.Rows[n].Cells[9].Value = reserva.mesa;
                    dgvReservas.Rows[n].Cells[10].Value = reserva.estado;
                    dgvReservas.Rows[n].Cells[11].Value = reserva.activo;
                    dgvReservas.Rows[n].Cells[12].Value = reserva.id_seccion;
                    dgvReservas.Rows[n].Cells[13].Value = reserva.id_mesa;
                }
            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }

        }

        /*
         * method that loads the tables in the combo box
         */
        public void CargarMesas(Seccion s)
        {
            lblErrores.Text = "";
            try
            {

                List<Mesa> listaMesa = new List<Mesa>();

                if (cbxHora.Text == "")
                {
                    throw new Exception("Seleccione una hora");
                }
                else
                {
                    mesas = rbo.CargarMesas(s, Convert.ToDateTime(txtFecha.Text), cbxHora.Text);

                }


                foreach (Mesa mesa in mesas)
                {

                    listaMesa.Add(mesa);
                }
                cbxMesas.ValueMember = "id";
                cbxMesas.DisplayMember = "numero";
                cbxMesas.DataSource = listaMesa;
                
                


            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }


        }
        /*
         * Method that loads the sections in the combo box.
         */

        public void CargarSecciones()
        {

            try
            {
                if (cbxHora.Text == "")
                {
                    throw new Exception("Seleccione una hora");
                }
                else
                {
                    List<Seccion> lista = new List<Seccion>();
                    secciones = sbo.CargarTodas();

                    foreach (Seccion seccion in secciones)
                    {
                        lista.Add(seccion);


                    }
                    cbxSeccion.ValueMember = "id";
                    cbxSeccion.DisplayMember = "numero";
                    cbxSeccion.DataSource = lista;
                }
            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }


        }





        /*
         * Method that loads the reservation data in the text fields.
         */


        public void CargarDatos()
        {

           
            txtCedula.Text = reserva.cedula;
            txtNombre.Text = reserva.nombre;
            txtFecha.Value = DateTime.Now;
            txtTelefono.Text = reserva.telefono;
            txtPersonas.Value = 1;
            cbxEstado.Text = reserva.estado;
            //cbxHora.Text = reserva.hora;
            cbxHora.SelectedIndex = -1;
            if (reserva.seccion != null && reserva.mesa != null)
            {
                cbxSeccion.Text = reserva.seccion;
                cbxMesas.Text = reserva.mesa;
            }

        }

        

        private void CbxHora_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                DateTime f = new DateTime();
                if (cbxHora.Text != "")
                {
                    f = Convert.ToDateTime(cbxHora.Text);
                }
                int horaCbx = f.Hour;

                int hora = int.Parse(DateTime.Now.Hour.ToString());

                if (f.Hour == 0)
                {
                    horaCbx = 12;

                }
                if (hora == 0)
                {
                    hora = 12;
                }
                

                if (Convert.ToDateTime(txtFecha.Text) == DateTime.Now.Date && horaCbx < hora)
                {

                    lblErrores.Text="Hora menor a la actual";
                }
                else
                {
                    CargarSecciones();
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtFecha_ValueChanged_1(object sender, EventArgs e)
        {

            //try
            //{
            //    if (Convert.ToDateTime(txtFecha.Text) < DateTime.Now.Date)
            //    {
            //        throw new Exception("Fecha menor a la actual");
            //    }
                

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void DgvReservas_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = dgvReservas.SelectedRows.Count > 0 ? dgvReservas.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                reserva = new Reserva();
                reserva.id = int.Parse(dgvReservas.CurrentRow.Cells[0].Value.ToString());
                reserva.cedula = dgvReservas.CurrentRow.Cells[1].Value.ToString();
                reserva.nombre = dgvReservas.CurrentRow.Cells[2].Value.ToString();
                reserva.fecha = Convert.ToDateTime(dgvReservas.CurrentRow.Cells[3].Value.ToString());
                reserva.fecha_reser = Convert.ToDateTime(dgvReservas.CurrentRow.Cells[4].Value.ToString());
                reserva.hora = dgvReservas.CurrentRow.Cells[5].Value.ToString();
                reserva.cant_personas = int.Parse(dgvReservas.CurrentRow.Cells[6].Value.ToString());
                reserva.telefono = dgvReservas.CurrentRow.Cells[7].Value.ToString();
                reserva.seccion = dgvReservas.CurrentRow.Cells[8].Value.ToString();
                reserva.mesa = dgvReservas.CurrentRow.Cells[9].Value.ToString();
                reserva.estado = dgvReservas.CurrentRow.Cells[10].Value.ToString();
                reserva.activo = bool.Parse(dgvReservas.CurrentRow.Cells[11].Value.ToString());
                reserva.id_seccion = int.Parse(dgvReservas.CurrentRow.Cells[12].Value.ToString());
                reserva.id_mesa = int.Parse(dgvReservas.CurrentRow.Cells[13].Value.ToString());

                if (reserva != null)
                {
                    //  CargarDatos();
                }
            }
        }

        private void BtnReservar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Reserva reserva = new Reserva();
                reserva.cedula = txtCedula.Text;
                reserva.nombre = txtNombre.Text;
                reserva.fecha = DateTime.Today.Date;
                DateTime f = new DateTime();

                if (cbxHora.Text != "")
                {
                    f = Convert.ToDateTime(cbxHora.Text);
                }
                int horaCbx = f.Hour;

                int hora = int.Parse(DateTime.Now.Hour.ToString());

                if (f.Hour == 0)
                {
                    horaCbx = 12;

                }
                if (hora == 0)
                {
                    hora = 12;
                }

                if (Convert.ToDateTime(txtFecha.Text) == DateTime.Now.Date && horaCbx < hora)
                {
                    throw new Exception("Fecha y hora menor a la actual");
                }
                else
                {
                    reserva.fecha_reser = Convert.ToDateTime(txtFecha.Text);

                }

                reserva.hora = cbxHora.Text;
                reserva.telefono = txtTelefono.Text;
                reserva.cant_personas = (int)txtPersonas.Value;

                if (cbxSeccion.SelectedValue != null && cbxMesas.SelectedValue != null)
                {
                    reserva.id_seccion = (int)cbxSeccion.SelectedValue;
                    reserva.id_mesa = (int)cbxMesas.SelectedValue;
                    reserva.seccion = cbxSeccion.GetItemText(cbxSeccion.SelectedItem);
                    reserva.mesa = cbxMesas.GetItemText(cbxMesas.SelectedItem);
                }
                
                 reserva.estado = cbxEstado.Text;

                if(reserva != null)
                {
                    rbo.Guardar(reserva);
                    CargarTablaReservas();

                    reserva = new Reserva();
                    CargarDatos();

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbxSeccion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                s.id = (int)cbxSeccion.SelectedValue;
                CargarMesas(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (reserva != null)
                {
                    reserva.estado = "Confirmado";
                    rbo.Confirmar(reserva);
                    CargarTablaReservas();

                }

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (reserva != null)
                {
                    
                    rbo.Eliminar(reserva);
                    CargarTablaReservas();
                }



                }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void CargarDatosSelec(int select)
        {
            Seccion s = seccionesTabla.ElementAt(select);
            seleccionada.id = s.id;
            seleccionada.numero = s.numero;
            seleccionada.cantidadMesas = s.cantidadMesas;
            seleccionada.salonero = s.salonero;
            seleccionada.mesas = s.mesas;
            for (int i = 0; i < saloneros.Count; i++)
            {
                if (saloneros.ElementAt(i).Equals(seleccionada.salonero))
                {
                    cbxSalonero.SelectedIndex = i;
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                foreach (Seccion seccion in seccionesTabla)
                {
                    if (seccion.salonero.Equals((Usuario)cbxSalonero.SelectedItem) && seccion.id != seleccionada.id)
                    {
                        throw new Exception("Este salonero ya está encargado de una sección");
                    }
                }
                if (seleccionada.id > 0)
                {
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
                }
                else
                {
                   throw new Exception("Debe seleccionar una Sección"); 
                }
            }
            catch (Exception ex)
            {

                lblErrores.Text = ex.Message;
            }
        }
    }
    }

