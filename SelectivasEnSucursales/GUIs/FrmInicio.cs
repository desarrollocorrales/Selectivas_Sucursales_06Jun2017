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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnCarnicos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCarnicos().ShowDialog();
            this.Show();
        }

        private void btnAbarrotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAbarrotes().ShowDialog();
            this.Show();
        }
    }
}
