using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesDeConfiguracion;
using SelectivasEnSucursales.Modelos;
using SelectivasEnSucursales.Controladores;
using AccSettings;
using System.IO;

namespace SelectivasEnSucursales.GUIs
{
    public partial class FrmConfiguracionAbarrotes : Form
    {
        ConfiguracionFB objConfig;
        private string _path = string.Empty;
        private bool _demo = false;
        private string _fecha = string.Empty;

        public FrmConfiguracionAbarrotes()
        {
            InitializeComponent();
            // objConfig = Properties.Settings.Default.Configuracion;
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SelecSuc\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                this._path = pathConfigFile + fileName;

                if (file != null)
                {
                    FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(this._path, "milagros");

                    if (result.status == FEncrypt.Estatus.ERROR)
                        throw new Exception(result.error);

                    if (result.status == FEncrypt.Estatus.OK)
                    {
                        string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                        this.txbSucursal.Text = list[0].Substring(2);           // sucursal
                        this.txbServidor.Text = list[1].Substring(2);           // servidor
                        this.txbDatabase.Text = list[2].Substring(2);           // base de datos
                        this.txbUser.Text = list[3].Substring(2);               // usuario
                        this.txbContraseña.Text = list[4].Substring(2);         // contraseña
                        this.nudPuerto.Text = list[5].Substring(2);             // puerto

                        this._demo = Convert.ToBoolean(list[8].Substring(2));
                        this._fecha = Convert.ToString(list[9].Substring(2));

                        /* hardcodeo para demostrativo */
                        if (this._demo)
                            this.lbDemo.Visible = true;

                        bool pruebaConn = pruebaCon();

                        if (pruebaConn)
                        {
                            MostrarAlmacenes();
                            /*
                            string s = list[6].Substring(2);

                            this.cbAlmacenes.SelectedValue = Convert.ToInt64(s);  // almacen

                            this.comboBox1.SelectedValue = s;
                            */
                            this.cbAlmacenes.SelectedIndex = Convert.ToInt16(list[6].Substring(2));
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            /*
            if (objConfig != null)
            {
                txbDatabase.Text = objConfig.Database;
                txbUser.Text = objConfig.Usuario;
                txbContraseña.Text = objConfig.Contraseña;
                txbSucursal.Text = Properties.Settings.Default.Sucursal;
                nudPuerto.Value = objConfig.Puerto;
            }
            */ 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                foreach (Control x in this.groupBox1.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)x).Text))
                            throw new Exception("Campos incompletos, Por favor verifique");
                    }
                }

                if(this.cbAlmacenes.SelectedIndex == -1)
                    throw new Exception("Debe seleccionar un almacén");

                /* P E R I O D O   D E   P R U E B A */

                if (!this._demo)
                {
                    bool pruebaConn = pruebaCon();

                    if (!pruebaConn)
                        throw new Exception("Falló la conexión a la base de datos");

                    FBDAL FbDal = new FBDAL();

                    this._fecha = FbDal.getFecha();
                }
                /* P E R I O D O   D E   P R U E B A */


                // define texto del archivo
                string cadena = string.Empty;

                // MICROSIP
                cadena += "S_" + this.txbSucursal.Text + "||";
                cadena += "S_" + this.txbServidor.Text + "||";
                cadena += "D_" + this.txbDatabase.Text + "||";
                cadena += "U_" + this.txbUser.Text + "||";
                cadena += "C_" + this.txbContraseña.Text + "||";
                cadena += "P_" + this.nudPuerto.Text + "||";
                cadena += "A_" + this.cbAlmacenes.SelectedIndex + "||";
                cadena += "A_" + ((Almacen)this.cbAlmacenes.SelectedItem).ID + "||";

                cadena += "D_true||";
                cadena += "D_" + this._fecha + "||";

                // prosigue con la creación del archivo
                FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.EncryptFile("milagros", cadena, this._path);

                if (result.status == FEncrypt.Estatus.ERROR)
                    throw new Exception(result.error);

                if (result.status == FEncrypt.Estatus.OK)
                {
                    objConfig = new ConfiguracionFB();
                    objConfig.Database = this.txbServidor.Text + ":" + this.txbDatabase.Text;
                    objConfig.Usuario = txbUser.Text;
                    objConfig.Contraseña = txbContraseña.Text;
                    objConfig.Puerto = (int)nudPuerto.Value;
                    Properties.Settings.Default.Configuracion = objConfig;

                    Properties.Settings.Default.Almacen = ((Almacen)this.cbAlmacenes.SelectedItem).ID;

                    Properties.Settings.Default.Sucursal = txbSucursal.Text;
                    Properties.Settings.Default.Save();

                    MessageBox.Show("La configuracion se ha guardado con exito!!!", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnMostrarAlmacenes_Click(object sender, EventArgs e)
        {
            try
            {

                bool pruebaConn = pruebaCon();

                if(!pruebaConn)
                    throw new Exception("Falló la conexión a la base de datos del Microsip");

                MostrarAlmacenes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarAlmacenes()
        {
            try
            {
                FBDAL FbDal = new FBDAL();
                List<Almacen> lstAlmacenes = FbDal.BuscarAlmacenes();

                cbAlmacenes.DataSource = lstAlmacenes;
                cbAlmacenes.DisplayMember = "Nombre";
                cbAlmacenes.ValueMember = "ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarConfiguraciones(string sFilePath)
        {
            //Obtener la ruta del archivo de configuraciones de Asistencia y la SettingsKey*
            MicroSipSettings oConfiguracion = new MicroSipSettings();
            oConfiguracion.FileName = sFilePath;
            oConfiguracion.Key = "C0RR4L35";

            MicroSipSettings MicrosipConfig = oConfiguracion.Deserialize<MicroSipSettings>(true);

            txbSucursal.Text = MicrosipConfig.Conexiones[0].Empresa;
            txbDatabase.Text = MicrosipConfig.Conexiones[0].Host;
            txbUser.Text = MicrosipConfig.Conexiones[0].Usuario;
            txbContraseña.Text = MicrosipConfig.Conexiones[0].PassWord;
            nudPuerto.Value = (decimal)MicrosipConfig.Conexiones[0].Puerto;
        }

        private void btnCargarParametros_Click(object sender, EventArgs e)
        {
            try
            {
                string ConfigPath = ObtenerArchivoDeConfiguracion();

                CargarConfiguraciones(ConfigPath);

                objConfig = new ConfiguracionFB();
                objConfig.Database = txbDatabase.Text;
                objConfig.Usuario = txbUser.Text;
                objConfig.Contraseña = txbContraseña.Text;
                objConfig.Puerto = (int)nudPuerto.Value;
                Properties.Settings.Default.Configuracion = objConfig;

                Properties.Settings.Default.Save();

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Error en el archivo de configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerArchivoDeConfiguracion()
        {
            ofdConfiguracion.InitialDirectory = Environment.CurrentDirectory + "\\Configuracion\\";
            ofdConfiguracion.ShowDialog();
            string FileName = ofdConfiguracion.FileName;
            
            return FileName;
        }

        private void btnProbCon_Click(object sender, EventArgs e)
        {
            try
            {
                bool pruebaConn = pruebaCon();

                if (pruebaConn)
                    MessageBox.Show("Conexión Exitosa!!!", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    throw new Exception("Falló la conexión a la base de datos");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool pruebaCon()
        {
            objConfig = new ConfiguracionFB();
            objConfig.Database = this.txbServidor.Text + ":" + this.txbDatabase.Text;
            objConfig.Usuario = txbUser.Text;
            objConfig.Contraseña = txbContraseña.Text;
            objConfig.Puerto = (int)nudPuerto.Value;
            Properties.Settings.Default.Configuracion = objConfig;

            Properties.Settings.Default.Save();

            FBDAL FbDal = new FBDAL();
            bool result = FbDal.pruebaConn();

            return result;
        }
    }
}
