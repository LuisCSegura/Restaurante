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
    public partial class FrmBartender : Form
    {
        ComidaBOL comiBol;
        BebidaBOL bebBol;
        ComandaBOL comanBol;
        Usuario bartender;
        Comanda comanda;
        Seccion seccion;
        Mesa mesa;
        LinkedList<OrdenBebida> ordenesBebida;
        LinkedList<Comida> comidas;
        LinkedList<Bebida> bebidas;
        BarBOL barBol = new BarBOL();
        ComandaBOL comBol = new ComandaBOL();
        public FrmBartender(Usuario usuario)
        {
            InitializeComponent();
            comiBol = new ComidaBOL();
            bebBol = new BebidaBOL();
            comanBol = new ComandaBOL();
            bartender = usuario;
            comanda = null;
            seccion = new Seccion();
            seccion.id = 7;
            seccion.numero = 0;
            seccion.cantidadMesas = 1;
            seccion.salonero = bartender;
            mesa = new Mesa();
            mesa.id = 31;
            mesa.numero = 1;
            mesa.seccion = seccion;
            ordenesBebida = new LinkedList<OrdenBebida>();
            CargarLista();
            bebidas = bebBol.CargarTodos();
            comidas = comiBol.CargarTodos();
            CargarComidasBebidas();
            CargarComanda();

        }

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
         * method that loads the orders of drinks
         * */
        private void CargarLista()
        {
            try
            {
                ordenesBebida = barBol.CargarOrdenesBar();
                lstOrdenesBebida.Items.Clear();
                foreach (OrdenBebida orden in ordenesBebida)
                {
                    lstOrdenesBebida.Items.Add(orden);
                }
            }
            catch (Exception e)
            {

                lblErrores.Text = e.Message;
            }
        }
        private void CargarComanda()
        {
            try
            {
                if (mesa != null)
                {
                    comanda = comanBol.CargarComandaMesa(mesa);
                    if (comanda != null)
                    {
                        comanda.mesa = mesa;
                        rtbComanda.Text = comanda.GetTexto();
                    }
                    else
                    {
                        Comanda c = new Comanda();
                        c.salonero = bartender;
                        c.mesa = mesa;
                        comanBol.InsertarComanda(c);
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

                if (lstOrdenesBebida.SelectedIndex >= 0)
                {
                    OrdenBebida sel = (OrdenBebida)(lstOrdenesBebida.SelectedItem);
                    sel.preparado = true;
                    comBol.ActualizarOrdenBebida(sel);
                    CargarLista();
                }
                else
                {
                    throw new Exception("Debe seleccionar una orden");
                }


            }
            catch (Exception ex)
            {

                lblErrores.Text = ex.Message;
            }
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
                        comanBol.InsertarOrdenBebida(ob);
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
                        comanBol.InsertarOrdenComida(oc);
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

                lblErrores.Text = exe.Message;
            }
        }

        private void BtnEnviarComanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (comanda != null)
                {
                    comanda.tiempo = DateTime.Now;
                    comanBol.ActualizarComanda(comanda);
                    CargarComanda();
                }
                else
                {
                    throw new Exception("Debe seleccionar una mesa");
                }
            }
            catch (Exception exep)
            {

                lblErrores.Text = exep.Message;
            }
        }
    }
}
