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
    public partial class FrmJefeSaloneros : Form
    {
        public FrmJefeSaloneros()
        {
            InitializeComponent();
            AgregarFormEnPanel(new FrmReservas());
        }
        private void AgregarFormEnPanel(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form frm = formHijo;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(frm);
            this.pnlContenedor.Tag = frm;
            frm.Show();
        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            AgregarFormEnPanel(new FrmReservas());
        }

        private void BtnRecepcion_Click(object sender, EventArgs e)
        {
            AgregarFormEnPanel(new FrmRecepcion());
        }
    }
}
