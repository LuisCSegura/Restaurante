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
    public partial class FrmCocinero : Form
    {
        LinkedList<OrdenComida> ordenesComida;
        CocinaBOL cocBol = new CocinaBOL();
        ComandaBOL comBol = new ComandaBOL();
        public FrmCocinero()
        {
            InitializeComponent();
            ordenesComida = new LinkedList<OrdenComida>();
            CargarLista();
        }


        /*
         * Method that loads the list of foods from the database.
         */
        private void CargarLista()
        {
            try
            {
                ordenesComida = cocBol.CargarOrdenesCocina();
                lstOrdenesComida.Items.Clear();
                foreach (OrdenComida orden in ordenesComida)
                {
                    lstOrdenesComida.Items.Add(orden);
                }
            }
            catch (Exception e)
            {

                lblErrores.Text=e.Message;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            CargarLista();
        }

        private void BtnListo_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                
                if (lstOrdenesComida.SelectedIndex >= 0)
                {
                    OrdenComida sel = (OrdenComida)(lstOrdenesComida.SelectedItem);
                    sel.preparado = true;
                    comBol.ActualizarOrdenComida(sel);
                    CargarLista();
                }
                else
                {
                    throw new Exception("Debe seleccionar una orden");
                }
                

            }
            catch (Exception ex)
            {

                lblErrores.Text=ex.Message;
            }
        }
    }
}
