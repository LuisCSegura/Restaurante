using CapaLogica;
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

namespace CapaDiseño
{
    public partial class FrmComida : Form
    {
        private ComidaBOL cbo;
        private Comida comida;
        LinkedList<Comida> comidas;

        public FrmComida()
        {
            InitializeComponent();
            cbo = new ComidaBOL();
            comida = new Comida();
            CargarTablaComidas();

        }

        private void FrmComida_Load(object sender, EventArgs e)
        {
            cbo = new ComidaBOL();
            comida = new Comida();
        }

        /*
         * method that loads the list of foods in the table
         */
        private void CargarTablaComidas()
        {
            try
            {
                comidas = cbo.CargarTodos();
                dgvComidas.RowCount = 0;
                 foreach (Comida comida in comidas)
                {
                    int n = dgvComidas.Rows.Add();
                    dgvComidas.Rows[n].Cells[0].Value = comida.id;
                    dgvComidas.Rows[n].Cells[1].Value = comida.codigo;
                    dgvComidas.Rows[n].Cells[2].Value = comida.nombre;
                    dgvComidas.Rows[n].Cells[3].Value = comida.categoria;
                    dgvComidas.Rows[n].Cells[4].Value = comida.descripcion;
                    dgvComidas.Rows[n].Cells[5].Value = comida.precio;
                    dgvComidas.Rows[n].Cells[6].Value = comida.activo;
                    
                }
            }
            catch (Exception e)
            {
                lblErrores.Text = e.Message;
            }

        }

        private void btnGuardar_click(object sender, EventArgs e)
        {
            try
            {
               
                comida.codigo = txtCod.Text.Trim();
                comida.nombre = txtNombre.Text.Trim();
                comida.categoria = cbxCategoria.Text;
                comida.descripcion = txtDescrip.Text.Trim();
                comida.precio =(double)nudPrecio.Value;

                if (cbo.Autenticar(comida))
                {
                    if (MessageBox.Show("El código: " + comida.codigo + ", ya existe en el sistema.\n\nDesea restaurarlo? ",
                       "Restaurar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        cbo.Restaurar(comida);
                        CargarTablaComidas();
                        comida = new Comida();
                        CargarDatos();
                    }

                }
                else
                {
                    cbo.Guardar(comida);
                    CargarTablaComidas();
                    //CargarDatos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_click(object sender, EventArgs e)
        {
            comida = new Comida();
            CargarDatos();
        }

        /*
         * method that loads the data of the food in the text fields
         */

        private void CargarDatos()
        {
            txtNombre.Text = comida.nombre;
            txtCod.Text = comida.codigo;
            txtDescrip.Text = comida.descripcion;
            cbxCategoria.Text = comida.categoria;
            nudPrecio.Value = (decimal)comida.precio;
            
        }

        private void dgvComidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = dgvComidas.SelectedRows.Count > 0 ? dgvComidas.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                comida = new Comida();
                comida.id = int.Parse(dgvComidas.CurrentRow.Cells[0].Value.ToString());
                comida.codigo = dgvComidas.CurrentRow.Cells[1].Value.ToString();
                comida.nombre = dgvComidas.CurrentRow.Cells[2].Value.ToString();
                comida.categoria = dgvComidas.CurrentRow.Cells[3].Value.ToString();
                comida.descripcion = dgvComidas.CurrentRow.Cells[4].Value.ToString();
                comida.precio = int.Parse(dgvComidas.CurrentRow.Cells[5].Value.ToString());
                comida.activo = bool.Parse(dgvComidas.CurrentRow.Cells[6].Value.ToString());

                if (comida != null)
                {
                    CargarDatos();
                }

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            lblErrores.Text = "";
            try
            {
                if (comida.id > 0)
                {
                    if (MessageBox.Show("Desea Eliminar el platillo: " + comida.codigo,
                        "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cbo.Eliminar(comida);
                        CargarTablaComidas();
                        comida = new Comida();
                        CargarDatos();
                    }

                }
                else
                {
                    throw new Exception("Debe seleccionar un platillo");
                }
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }


        }

        private void DgvComidas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            
        }

    }
}
