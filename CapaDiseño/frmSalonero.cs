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
    public partial class frmSalonero : Form
    {
        ComidaBOL comBol;
        BebidaBOL bebBol;
        SalonBOL salBol;
        ComandaBOL comandaBol;
        Usuario salonero; 
        Seccion seccion;
        Comanda comanda;
        Mesa mesa;
        LinkedList<Comida> comidas;
        LinkedList<Bebida> bebidas;
        public frmSalonero(Usuario usuario)
        {
            comBol = new ComidaBOL();
            bebBol = new BebidaBOL();
            salBol = new SalonBOL();
            comandaBol = new ComandaBOL();
            comanda = null;
            mesa = null;
            salonero = usuario;
            bebidas = bebBol.CargarTodos();
            comidas = comBol.CargarTodos();
            InitializeComponent();
            CargarSeccion();
            CargarComidasBebidas();
            CargarNotificaciones();
        }

        /*
         * Method that loads the notifications in the label
         */

        private void CargarNotificaciones()
        {
            try
            {
                if (seccion != null && seccion.id>0)
                {
                    LinkedList<OrdenComida> coms = comandaBol.CargarNotificacionesComidas(seccion);
                    LinkedList<OrdenBebida> bebs = comandaBol.CargarNotificacionesBebidas(seccion);
                    lvNotificaciones.Items.Clear();
                    foreach (OrdenComida orden in coms)
                    {
                        lvNotificaciones.Items.Add(orden.ToStatusString());
                    }
                    foreach (OrdenBebida orden in bebs)
                    {
                        lvNotificaciones.Items.Add(orden.ToStatusString());
                    }

                }
                
            }
            catch (Exception e)
            {

                lblErrores.Text=e.Message;
            }
        }

        /*
         * method that loads the tables of the respective sections
         */

        private void CargarSeccion()
        {
            try
            {
                seccion = salBol.CargarSeccionSalonero(salonero);
                if (seccion != null)
                {
                    lblSeccion.Text += seccion.numero;
                    btnMesa1.AccessibleName = 0.ToString();
                    btnMesa1.Text = (seccion.mesas.ElementAt(0)).ToString();
                    btnMesa2.AccessibleName = 1.ToString();
                    btnMesa2.Text = (seccion.mesas.ElementAt(1)).ToString();
                    btnMesa3.AccessibleName = 2.ToString();
                    btnMesa3.Text = (seccion.mesas.ElementAt(2)).ToString();
                    btnMesa4.AccessibleName = 3.ToString();
                    btnMesa4.Text = (seccion.mesas.ElementAt(3)).ToString();
                    btnMesa5.AccessibleName = 4.ToString();
                    btnMesa5.Text = (seccion.mesas.ElementAt(4)).ToString();
                    btnMesa6.AccessibleName = 5.ToString();
                    btnMesa6.Text = (seccion.mesas.ElementAt(5)).ToString();
                }
            }
            catch (Exception e)
            {

                lblErrores.Text=e.Message;
            }
            
        }

        /*
         * Method that loads the list of food and drinks.
         */
        private void CargarComidasBebidas()
        {
            foreach (Comida comida in comidas)
            {
                lstComidas.Items.Add(comida);
            }
            foreach (Bebida bebida in bebidas)
            {
                lstBebidas.Items.Add(bebida);
            }
        }

        /*
         * Method that loads the command with the orders.
         */
        private void CargarComanda()
        {
            try
            {
                if (mesa != null)
                {
                    comanda = comandaBol.CargarComandaMesa(mesa);
                    if (comanda != null)
                    {
                        comanda.mesa = mesa;
                        rtbComanda.Text = comanda.GetTexto();
                    }
                    else
                    {
                        Comanda c = new Comanda();
                        c.salonero = salonero;
                        c.mesa = mesa;
                        comandaBol.InsertarComanda(c);
                        CargarComanda();
                    }
                }
                else
                {
                    throw new Exception("Debe seleccionar una mesa");
                }
                
            }
            catch (Exception exe)
            {

                throw new Exception(exe.Message);
            }
        }



        private void LblSeccion_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgrgarBebida_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                if (comanda != null)
                {
                    if (lstBebidas.SelectedIndex >= 0)
                    {
                        Bebida sel = (Bebida)(lstBebidas.SelectedItem);
                        OrdenBebida ob = new OrdenBebida();
                        ob.bebida = sel;
                        ob.comanda = comanda;
                        comandaBol.InsertarOrdenBebida(ob);
                        CargarComanda();
                    }
                    else
                    {
                        throw new Exception("Debe seleccionar una bebida de la lista");
                    }
                }
                else
                {
                    throw new Exception("Debe seleccionar una mesa");
                }
            }
            catch (Exception exe)
            {

                lblErrores.Text = exe.Message;
            }
        }

        private void BtnMesa1_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (seccion != null)
            {
                try
                {
                    mesa = seccion.mesas.ElementAt(int.Parse(btnMesa1.AccessibleName));
                    CargarComanda();
                }
                catch (Exception ex)
                {
                    lblErrores.Text = ex.Message;;
                }
            }
            else
            {
                lblErrores.Text = "No se ha asignado ninguna sección";
            }
        }

        private void BtnMesa2_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (seccion != null)
            {
                try
                {
                    mesa = seccion.mesas.ElementAt(int.Parse(btnMesa2.AccessibleName));
                    CargarComanda();
                }
                catch (Exception ex)
                {
                    lblErrores.Text = ex.Message; ;
                }
            }
            else
            {
                lblErrores.Text = "No se ha asignido ninguna sección";
            }
        }

        private void BtnMesa5_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (seccion != null)
            {
                try
                {
                    mesa = seccion.mesas.ElementAt(int.Parse(btnMesa5.AccessibleName));
                    CargarComanda();
                }
                catch (Exception ex)
                {
                    lblErrores.Text = ex.Message; ;
                }
            }
            else
            {
                lblErrores.Text = "No se ha asignido ninguna sección";
            }
        }

        private void BtnMesa3_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (seccion != null)
            {
                try
                {
                    mesa = seccion.mesas.ElementAt(int.Parse(btnMesa3.AccessibleName));
                    CargarComanda();
                }
                catch (Exception ex)
                {
                    lblErrores.Text = ex.Message; ;
                }
            }
            else
            {
                lblErrores.Text = "No se ha asignido ninguna sección";
            }
        }

        private void BtnMesa4_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (seccion != null)
            {
                try
                {
                    mesa = seccion.mesas.ElementAt(int.Parse(btnMesa4.AccessibleName));
                    CargarComanda();
                }
                catch (Exception ex)
                {
                    lblErrores.Text = ex.Message; ;
                }
            }
            else
            {
                lblErrores.Text = "No se ha asignido ninguna sección";
            }
        }

        private void BtnMesa6_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            if (seccion != null)
            {
                try
                {
                    mesa = seccion.mesas.ElementAt(int.Parse(btnMesa6.AccessibleName));
                    CargarComanda();
                }
                catch (Exception ex)
                {
                    lblErrores.Text = ex.Message; ;
                }
            }
            else
            {
                lblErrores.Text = "No se ha asignido ninguna sección";
            }
        }

        private void BtnAgregarComida_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                if (comanda != null)
                {
                    if (lstComidas.SelectedIndex >= 0)
                    {
                        Comida sel = (Comida)(lstComidas.SelectedItem);
                        OrdenComida oc = new OrdenComida();
                        oc.comida = sel;
                        oc.comanda = comanda;
                        comandaBol.InsertarOrdenComida(oc);
                        CargarComanda();
                    }
                    else
                    {
                        throw new Exception("Debe seleccionar una comida de la lista");
                    }
                }
                else
                {
                    throw new Exception("Debe seleccionar una mesa");
                }
            }
            catch (Exception exe)
            {

                lblErrores.Text=exe.Message;
            }
        }

        private void BtnEnviarComanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (comanda != null)
                {
                    comanda.tiempo = DateTime.Now;
                    comandaBol.ActualizarComanda(comanda);
                    CargarComanda();
                }
                else
                {
                    throw new Exception("Debe seleccionar una mesa");
                }
            }
            catch (Exception exep)
            {

                lblErrores.Text=exep.Message;
            }
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
