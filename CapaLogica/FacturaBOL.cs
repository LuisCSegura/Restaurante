using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaLogica
{
    
    public class FacturaBOL
    {
        FacturaDAL facDal = new FacturaDAL();
        public Factura CargarFacturaComanda(Comanda c)
        {
            try
            {
                return facDal.CargarFacturaComanda(c);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void InsertarFactura(Factura f)
        {
            try
            {
                facDal.InsertarFactura(f);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void InsertarDetalleFactura(DetalleFactura df, Factura factura)
        {
            try
            {
                facDal.InsertarDetalleFactura(df, factura);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void EliminarFactura(Factura factura)
        {
            try
            {
                facDal.EliminarFactura(factura);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Facturar(Factura factura)
        {
            try
            {
                facDal.Facturar(factura);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
