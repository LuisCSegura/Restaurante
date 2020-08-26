using CapaLogica;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño
{
    public partial class FrmRecepcion : Form
    {

        private RecepcionBOL rbo;
        private SalonBOL sbo;
        private Seccion s;
        private Mesa m;
        LinkedList<Mesa> mesas;
        LinkedList<Seccion> secciones;
         

        public FrmRecepcion()
        {
            InitializeComponent();
            s = new Seccion();
            m = new Mesa();
            rbo = new RecepcionBOL();
            sbo = new SalonBOL();
            CargarTablaReservas();
            CargarSecciones();
        }
        private void FrmRecepcion_Load(object sender, EventArgs e)
        {
            s = new Seccion();
            m = new Mesa();
            rbo = new RecepcionBOL();
            sbo = new SalonBOL();

        }
        /*
         * method that loads the reservation list in the table
         */
        private void CargarTablaReservas()
        {
            try
            {
                mesas = rbo.CargarTodos();
                dgvReservas.RowCount = 0;
                foreach (Mesa mesa in mesas)
                {

                    int n = dgvReservas.Rows.Add();
                    dgvReservas.Rows[n].Cells[0].Value = mesa.id;
                    dgvReservas.Rows[n].Cells[1].Value = mesa.seccion.numero;
                    dgvReservas.Rows[n].Cells[2].Value = mesa.numero;
                    dgvReservas.Rows[n].Cells[3].Value = mesa.seccion.id;
                }
            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }

        }


        /*
         * Method that loads the list of tables in the combo box.
         */
        public void CargarMesas(Seccion s)
        {
            lblErrores.Text = "";
            try
            {

                List<Mesa> listaMesa = new List<Mesa>();

                mesas = rbo.CargarMesas(s, DateTime.Now.Date, DateTime.Now.ToString("hh:00 tt", CultureInfo.InvariantCulture));

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
         * Method that loads the list of sections in the combo box.
         */
        public void CargarSecciones()
        {

            try
            {

                List<Seccion> listas = new List<Seccion>();
                secciones = sbo.CargarTodas();

                foreach (Seccion seccion in secciones)
                {
                    listas.Add(seccion);


                }
                cbxSeccion.ValueMember = "id";
                cbxSeccion.DisplayMember = "numero";
                cbxSeccion.DataSource = listas;

            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }


        }




        private void BtnReservar_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    Mesa m = new Mesa();
            //    Seccion sec = new Seccion();

            //    if (cbxSeccion.SelectedValue != null && cbxMesas.SelectedValue != null)
            //    {
            //        sec.id = (int)cbxSeccion.SelectedValue;
            //        m.id = (int)cbxMesas.SelectedValue;
            //        m.numero = int.Parse(cbxMesas.GetItemText(cbxMesas.SelectedItem));
            //        sec.numero = int.Parse(cbxSeccion.GetItemText(cbxSeccion.SelectedItem));


            //        m.seccion = sec;
            //    }

            //    if (m != null)
            //    {
            //        rbo.Guardar(m);
            //        CargarTablaReservas();
            //        m = new Mesa();
            //        CargarDatos();


            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}





        }

        private void BtnLiberar_Click(object sender, EventArgs e)
        {

        }

        private void CbxSeccion_SelectedIndexChanged(object sender, EventArgs e)
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


    }
}
