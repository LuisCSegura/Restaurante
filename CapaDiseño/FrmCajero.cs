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
    public partial class FrmCajero : Form
    {
        Factura factura;
        Comanda comanda;
        ComandaBOL comanBol;
        FacturaBOL facBol;
        public FrmCajero()
        {
            InitializeComponent();
            factura = null;
            comanda = null;
            comanBol = new ComandaBOL();
            facBol = new FacturaBOL();
            CargarComandas();
        }
        private void CargarComandas()
        {
            try
            {
                LinkedList<Comanda> comandas = comanBol.CargarComandas();
                foreach (Comanda comanda in comandas)
                {
                    if(comanda.comidas.Count==0 && comanda.bebidas.Count == 0)
                    {
                        comanda.pagado = true;
                        comanBol.ActualizarComanda(comanda);
                    }
                }
                comandas = comanBol.CargarComandas();
                lstComandas.Items.Clear();
                foreach (Comanda comanda in comandas)
                {
                    lstComandas.Items.Add(comanda);
                }
            }
            catch (Exception e)
            {

                lblErrores.Text=e.Message;
            }
        }
        private void CargarFactura(Comanda c)
        {
            try
            {
                    factura = facBol.CargarFacturaComanda(c);
                    if (factura != null)
                    {
                    factura.totalSinImpuesto = factura.GetPrecio();
                    factura.total = factura.GetPrecio() + (factura.GetPrecio()*0.13);
                        rtbFactura.Text = factura.GetTexto();
                    }
                    else
                    {
                        Factura f = new Factura();
                        f.comanda = c;
                        facBol.InsertarFactura(f);
                        CargarFactura(c);
                    }
            }
            catch (Exception exe)
            {

                throw new Exception(exe.Message);
            }
        }

        private void BSeleccionarComanda_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                if (lstComandas.SelectedIndex >= 0)
                {
                    
                    Comanda c = (Comanda)(lstComandas.SelectedItem);
                    comanda = c;
                    lstOrdenes.Items.Clear();
                    foreach (OrdenComida orden in c.comidas)
                    {
                        lstOrdenes.Items.Add(orden);
                    }
                    foreach (OrdenBebida orden in c.bebidas)
                    {
                        lstOrdenes.Items.Add(orden);
                    }
                    CargarFactura(c);
                }
                else
                {
                    throw new Exception("Debe seleccionar una comanda");
                }
            }
            catch (Exception ex)
            {

                lblErrores.Text=ex.Message;
            }
        }

        private void BtnAgregarOrden_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                if (factura != null)
                {
                    if (lstOrdenes.SelectedIndex >= 0)
                    {
                        
                        DetalleFactura df = new DetalleFactura();
                        if(lstOrdenes.SelectedItem is OrdenBebida)
                        {
                            OrdenBebida ob = (OrdenBebida)(lstOrdenes.SelectedItem);
                            df.ordenRefer = ob.id;
                            df.detalle = ob.ToShortString();
                            df.precio = ob.GetPrecio();
                        }
                        else
                        {
                            OrdenComida ob = (OrdenComida)(lstOrdenes.SelectedItem);
                            df.ordenRefer = ob.id;
                            df.detalle = ob.ToShortString();
                            df.precio = ob.GetPrecio();
                        }
                        foreach (DetalleFactura detalleFactura in factura.detalles)
                        {
                            if (detalleFactura.ordenRefer == df.ordenRefer)
                            {
                                throw new Exception("Esta orden ya está en la factura");
                            }
                        }
                        facBol.InsertarDetalleFactura(df, factura);
                        CargarFactura(comanda);
                    }
                    else
                    {
                        throw new Exception("Debe seleccionar una orden ");
                    }
                }
                else
                {
                    throw new Exception("Debe seleccionar una comanda");
                }
            }
            catch (Exception exep)
            {

                lblErrores.Text=exep.Message;
            }
        }

        private void BtnCancelarFactura_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                if (factura != null)
                {
                    if (MessageBox.Show("¿Desea CANCELAR la Factura?", "Eliminar Factura", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        facBol.EliminarFactura(factura);
                        factura = null;
                        lstOrdenes.Items.Clear();
                        comanda = null;
                        rtbFactura.Text = "    Seleccione una Comanda";
                    }
                }
                else
                {

                    throw new Exception("Debe seleccionar una comanda");
                }
            }
            catch (Exception exept)
            {

                lblErrores.Text=exept.Message;
            }
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                if (factura != null && comanda!=null)
                {
                    if (MessageBox.Show("¿Desea FACTURAR con los datos actuales?", "Facturar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        facBol.Facturar(factura);
                        foreach (DetalleFactura detalle in factura.detalles)
                        {
                            foreach (OrdenBebida ordenb in comanda.bebidas)
                            {
                                if (ordenb.id == detalle.ordenRefer)
                                {
                                comanBol.EliminarOrdenBebida(ordenb);
                                }
                            }
                            foreach (OrdenComida ordenc in comanda.comidas)
                            {
                                if (ordenc.id == detalle.ordenRefer)
                                {
                                    comanBol.EliminarOrdenComida(ordenc);
                                }
                            }
                        }
                        factura = null;
                        lstOrdenes.Items.Clear();
                        comanda = null;
                        rtbFactura.Text = "    Seleccione una Comanda";
                        CargarComandas();
                    }
                }
                else
                {

                    throw new Exception("Debe seleccionar una comanda");
                }
            }
            catch (Exception exept)
            {

                lblErrores.Text = exept.Message;
            }
        }
    }
}
