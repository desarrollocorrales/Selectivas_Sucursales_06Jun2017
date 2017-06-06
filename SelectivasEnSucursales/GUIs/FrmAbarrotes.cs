using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using SelectivasEnSucursales.Modelos;
using SelectivasEnSucursales.Controladores;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmAbarrotes : Form
    {
        private List<Articulo> lstArticulos;

        public FrmAbarrotes()
        {
            InitializeComponent();
            lstArticulos = new List<Articulo>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            int iAlmacen = Properties.Settings.Default.Almacen;
            string sClave = txbClave.Text.ToUpper();

            FBDAL FbDal = new FBDAL();            
            List<Articulo> lstArticulosEncontrados = FbDal.BuscarArticulo(sClave, iAlmacen);

            if (lstArticulosEncontrados.Count == 0)
            {
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine(string.Format("No se encontró el articulo con clave: [{0}]", sClave));
                MessageBox.Show(mensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Articulo art in lstArticulosEncontrados)
            {
                Articulo buscado = lstArticulos.Find(o => o.Articulo_ID == art.Articulo_ID);

                if (buscado == null)
                    lstArticulos.Add(art);
                else 
                {
                    StringBuilder mensaje = new StringBuilder();
                    mensaje.AppendLine(string.Format("El articulo con clave: [{0}] ya esta en la lista",sClave));
                    mensaje.AppendLine(string.Format("con el nombre: [{0}]", art.Nombre));
                    MessageBox.Show(mensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            gridExistencia.DataSource= lstArticulos;
            gvExistencia.BestFitColumns();

            txbClave.Text = string.Empty;
            txbClave.Focus();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            new FrmConfiguracionAbarrotes().ShowDialog();
        }

        private void txbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Buscar();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void Imprimir()
        {            
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            PageHeaderArea headerArea;

            headerArea = new PageHeaderArea();
            headerArea.Content.Add(Environment.NewLine);
            headerArea.Content.Add(Properties.Settings.Default.Sucursal);
            headerArea.Content.Add(DateTime.Today.ToShortDateString());
            headerArea.LineAlignment = BrickAlignment.Center;

            PageFooterArea footerArea;
            PageHeaderFooter headerfooter;

            footerArea = new PageFooterArea();
            footerArea.Content.Add("[Page #]");
            footerArea.LineAlignment = BrickAlignment.Far;

            headerfooter = new PageHeaderFooter(headerArea, footerArea);
            link.PageHeaderFooter = headerfooter;

            link.Component = gridExistencia;
            link.CreateDocument();
            link.ShowPreviewDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            gridExistencia.DataSource = null;
            gvExistencia.BestFitColumns();
        }

    }
}
