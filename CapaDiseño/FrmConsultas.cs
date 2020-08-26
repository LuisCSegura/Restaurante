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
    public partial class FrmConsultas : Form
    {
        private ReportesBOL rbo;
        private Reportes reportes;
        LinkedList<Reportes> repor = new LinkedList<Reportes>();
        public FrmConsultas()
        {
            InitializeComponent();
            reportes = new Reportes();
            rbo = new ReportesBOL();
           // CargarTablaPrimera();
            
        }
        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            reportes = new Reportes();
            rbo = new ReportesBOL();
            
        }

        /*
         * method that loads the data of the first report in the table
         */
        private void CargarTablaPrimera()
        {
            try
            {
                repor = rbo.primer_repor(Convert.ToDateTime(txtFecha.Text));
                dgvPrimera.RowCount = 0;
                foreach (Reportes reportes in repor)
                {
                    int n = dgvPrimera.Rows.Add();
                    dgvPrimera.Rows[n].Cells[0].Value = reportes.mesa;
                    dgvPrimera.Rows[n].Cells[1].Value = reportes.seccion;
                }
            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }

        }


        /*
         *Method that loads the data of the seventh report in the table.
         */
        private void CargarTablaSetimo()
        {
            try
            {
                repor = rbo.Setimo_repor(Convert.ToDateTime(txtFecha.Text));
                dgvSetimo.RowCount = 0;
                foreach (Reportes reportes in repor)
                {
                    int n = dgvSetimo.Rows.Add();
                    dgvSetimo.Rows[n].Cells[0].Value = reportes.seccion;
                    dgvSetimo.Rows[n].Cells[1].Value = reportes.nombre;
                }
            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }

        }

        /*
         *Method that loads the data of the seventh report in the table.
         */
        private void CargarTablaOctava()
        {
            try
            {
                repor = rbo.Octavo_repor(Convert.ToDateTime(txtFecha.Text));
                dgvOctavo.RowCount = 0;
                foreach (Reportes reportes in repor)
                {
                    int n = dgvOctavo.Rows.Add();
                    dgvOctavo.Rows[n].Cells[0].Value = reportes.seccion;
                    dgvOctavo.Rows[n].Cells[1].Value = reportes.nombre;
                }
            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }

        }

        private void CargarTablaNoveno()
        {
            try
            {
                repor = rbo.Noveno_repor(Convert.ToDateTime(txtFecha.Text));
                dgvNoveno.RowCount = 0;
                foreach (Reportes reportes in repor)
                {
                    int n = dgvNoveno.Rows.Add();
                    dgvNoveno.Rows[n].Cells[0].Value = reportes.fecha1;
                    dgvNoveno.Rows[n].Cells[1].Value = reportes.fecha2;
                    dgvNoveno.Rows[n].Cells[2].Value = reportes.fecha3;
                }
            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void TxtFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarTablaPrimera();
            CargarTablaSetimo();
            CargarTablaOctava();
            CargarTablaNoveno();
        }
    }
}
