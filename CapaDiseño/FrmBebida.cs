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
    public partial class FrmBebida : Form
    {
        private BebidaBOL bbo;
        private Bebida bebida;
        LinkedList<Bebida> bebidas;


        public FrmBebida()
        {
            InitializeComponent();
            bbo = new BebidaBOL();
            bebida = new Bebida();
            CargarTablaBebidas();


        }
        private void FrmBebida_Load(object sender, EventArgs e)
        {
            bbo = new BebidaBOL();
            bebida = new Bebida();

        }
        /*
         * method that loads a list of beverages
         * */
        private void CargarTablaBebidas()
        {
            try
            {
                bebidas = bbo.CargarTodos();
                dgvBebidas.RowCount = 0;
                foreach (Bebida bebida in bebidas)
                {
                    int n = dgvBebidas.Rows.Add();
                    dgvBebidas.Rows[n].Cells[0].Value = bebida.id;
                    dgvBebidas.Rows[n].Cells[1].Value = bebida.codigo;
                    dgvBebidas.Rows[n].Cells[2].Value = bebida.nombre;
                    dgvBebidas.Rows[n].Cells[3].Value = bebida.categoria;
                    dgvBebidas.Rows[n].Cells[4].Value = bebida.descripcion;
                    dgvBebidas.Rows[n].Cells[5].Value = bebida.precio;
                    dgvBebidas.Rows[n].Cells[6].Value = bebida.activo;

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

                bebida.codigo = txtCod.Text.Trim();
                bebida.nombre = txtNombre.Text.Trim();
                bebida.categoria = cbxCategoria.Text;
                bebida.descripcion = txtDescrip.Text.Trim();
                bebida.precio = (double)txtPrecio.Value;

                if (bbo.Autenticar(bebida))
                {
                    if (MessageBox.Show("El código: " + bebida.codigo +", ya existe en el sistema.\nDesea restaurarlo? ",
                       "Restaurar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        
                        bbo.Restaurar(bebida);
                        CargarTablaBebidas();
                        bebida = new Bebida();
                        CargarDatos();
                    }

                }
                else
                {
                    bbo.Guardar(bebida);
                    CargarTablaBebidas();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNuevo_click(object sender, EventArgs e)
        {
            bebida = new Bebida();
            CargarDatos();
        }

        /*
         * method that loads the data of the drink in the text fields
         */
        private void CargarDatos()
        {
            txtNombre.Text = bebida.nombre;
            txtCod.Text = bebida.codigo;
            txtDescrip.Text = bebida.descripcion;
            cbxCategoria.Text = bebida.categoria;
            txtPrecio.Value = (decimal)bebida.precio;
        }

        private void dgvBebidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int row = dgvBebidas.SelectedRows.Count > 0 ? dgvBebidas.SelectedRows[0].Index : -1;
            if (row >= 0)
            {
                bebida = new Bebida();
                bebida.id = int.Parse(dgvBebidas.CurrentRow.Cells[0].Value.ToString());
                bebida.codigo = dgvBebidas.CurrentRow.Cells[1].Value.ToString();
                bebida.nombre = dgvBebidas.CurrentRow.Cells[2].Value.ToString();
                bebida.categoria = dgvBebidas.CurrentRow.Cells[3].Value.ToString();
                bebida.descripcion = dgvBebidas.CurrentRow.Cells[4].Value.ToString();
                bebida.precio = int.Parse(dgvBebidas.CurrentRow.Cells[5].Value.ToString());
                bebida.activo = bool.Parse(dgvBebidas.CurrentRow.Cells[6].Value.ToString());

                if (bebida != null)
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
                if (bebida.id > 0)
                {
                    if (MessageBox.Show("Desea Eliminar la bebida: " + bebida.codigo,
                        "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bbo.Eliminar(bebida);
                        CargarTablaBebidas();
                        bebida = new Bebida();
                        CargarDatos();
                    }

                }
                else
                {
                    throw new Exception("Debe seleccionar una bebida");
                }
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }

        private void LblErrores_Click(object sender, EventArgs e)
        {

        }
    }
}
