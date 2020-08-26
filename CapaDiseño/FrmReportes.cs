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
    public partial class FrmReportes : Form
    {
        private ReportesBOL rbo;
        private Reportes reportes;

        public FrmReportes()
        {
            InitializeComponent();
            reportes = new Reportes();
            rbo = new ReportesBOL();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }



        
        

        private void segundoRepo_LinkcCicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                // Console.WriteLine(Convert.ToDateTime(txtFecha.Text));
                reportes = rbo.Segundo_repor(Convert.ToDateTime(txtFecha.Text));

                // Console.WriteLine(reportes.cantidad.ToString());
                chart1.Series[0].Points.DataBindY(reportes.cantidad);
            }
            catch (Exception ex)
            {

                lblErrores.Text = ex.Message;
            }

            
        }

        private void Quinto_LinkcCicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                reportes = rbo.Quinto_repor(Convert.ToDateTime(txtFecha.Text));

                // Console.WriteLine(reportes.cantidad.ToString());
                chart1.Series[0].Points.DataBindY(reportes.cantidad);
            }
            catch (Exception ex)
            {

                lblErrores.Text=ex.Message;
            }
            

        }

        private void tercerRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblErrores.Text ="";
            try
            {
                reportes = rbo.Tercer_repor(Convert.ToDateTime(txtFecha.Text));

                // Console.WriteLine(reportes.cantidad.ToString());
                chart1.Series[0].Points.DataBindY(reportes.cantidad);
            }
            catch (Exception ex)
            {

                lblErrores.Text = ex.Message;
            }
            

        }

        private void CuartoRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                reportes = rbo.Cuarto_repor(Convert.ToDateTime(txtFecha.Text));

                // Console.WriteLine(reportes.cantidad.ToString());
                chart1.Series[0].Points.DataBindY(reportes.cantidad);
            }
            catch (Exception ex)
            {

                lblErrores.Text = ex.Message;
            }
            
        }

        private void SextoRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                reportes = rbo.Sexto_repor(Convert.ToDateTime(txtFecha.Text));

                // Console.WriteLine(reportes.cantidad.ToString());
                chart1.Series[0].Points.DataBindY(reportes.cantidad);
            }
            catch (Exception ex)
            {

                lblErrores.Text = ex.Message;
            }
            
        }
    }
}
