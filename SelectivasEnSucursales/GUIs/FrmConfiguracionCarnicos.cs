using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmConfiguracionCarnicos : Form
    {
        public FrmConfiguracionCarnicos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                webPreview.Url = new Uri(txbUrl.Text);
                webPreview.Update();
            }
            catch 
            {
                MessageBox.Show("Error en la URL...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmConfiguracionCarnicos_Load(object sender, EventArgs e)
        {
            txbUrl.Text = Properties.Settings.Default.URLWebService;
            txbUrlFriolala.Text = Properties.Settings.Default.URLWebServiceFriolala;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.URLWebServiceFriolala = txbUrlFriolala.Text;
            Properties.Settings.Default.URLWebService = txbUrl.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("Las URLs han sido guardadas con éxito!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCargarFriolala_Click(object sender, EventArgs e)
        {
            try
            {
                webPreview.Url = new Uri(txbUrlFriolala.Text);
                webPreview.Update();
            }
            catch
            {
                MessageBox.Show("Error en la URL...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
