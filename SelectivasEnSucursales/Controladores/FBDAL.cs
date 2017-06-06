using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using SelectivasEnSucursales.Modelos;
using System.Data;

namespace SelectivasEnSucursales.Controladores
{
    public class FBDAL
    {
        FbCommand Comando;
        FbConnection Conexion;        
        FbDataAdapter Adapter;

        public FBDAL()
        {
            Comando = new FbCommand();
            Conexion = new FbConnection();
            Adapter = new FbDataAdapter();

            Conexion.ConnectionString = getCadenaDeConexion();
        }

        private string getCadenaDeConexion()
        {
            FbConnectionStringBuilder fbcsb = new FbConnectionStringBuilder();
            fbcsb.DataSource = Properties.Settings.Default.Configuracion.Servidor;
            fbcsb.Database = Properties.Settings.Default.Configuracion.Database;
            fbcsb.UserID = Properties.Settings.Default.Configuracion.Usuario;
            fbcsb.Password = Properties.Settings.Default.Configuracion.Contraseña;
            fbcsb.Port = Properties.Settings.Default.Configuracion.Puerto;

            return fbcsb.ConnectionString;
        }
            
        public List<Articulo> BuscarArticulo(string Clave, int AlmacenID)
        {            
            Comando.Connection = Conexion;

            string Fecha = DateTime.Today.ToString("yyyy-MM-dd");
            Comando.CommandText = string.Format(
            @"SELECT 
                  A.ARTICULO_ID,
                  A.NOMBRE,
                  CA.CLAVE_ARTICULO,
                  (
                    SELECT 
                      CA.CLAVE_ARTICULO
                    FROM
                      CLAVES_ARTICULOS CA
                        INNER JOIN ARTICULOS ART ON (CA.ARTICULO_ID = A.ARTICULO_ID)
                        INNER JOIN ROLES_CLAVES_ARTICULOS RCA ON (CA.ROL_CLAVE_ART_ID = RCA.ROL_CLAVE_ART_ID)
                    WHERE
                      ART.ARTICULO_ID = A.ARTICULO_ID AND
                      RCA.ES_PPAL = 'S'
                  ) AS CLAVE_PRINCIPAL,
                  (
                    SELECT COALESCE(EXISTENCIA,0)
                       FROM EXIVAL_ART(A.ARTICULO_ID, {0}, '{1}', 'N')
                  ) AS EXISTENCIA
                FROM
                  CLAVES_ARTICULOS CA
                  INNER JOIN ARTICULOS A ON (CA.ARTICULO_ID = A.ARTICULO_ID)
                WHERE
                  CA.CLAVE_ARTICULO IN ('{2}')", AlmacenID, Fecha, Clave);

            //Conexion.Open();           
            Adapter.SelectCommand = Comando;
            DataTable tbResultado = new DataTable();
            Adapter.Fill(tbResultado);

            Articulo item;
            List<Articulo> lstArticulos = new List<Articulo>();
            foreach (DataRow fila in tbResultado.Rows)
            {
                item = new Articulo();
                item.Articulo_ID = Convert.ToInt32(fila["ARTICULO_ID"]);
                item.Nombre = Convert.ToString(fila["NOMBRE"]);
                item.ClavePrincipal = Convert.ToString(fila["CLAVE_PRINCIPAL"]);
                item.Clave = Convert.ToString(fila["CLAVE_ARTICULO"]);
                item.Existencia = Convert.ToDecimal(fila["EXISTENCIA"]);
                lstArticulos.Add(item);
            }

            return lstArticulos;
        }

        public List<Almacen> BuscarAlmacenes()
        {
            Comando.Connection = Conexion;
            Comando.CommandText = string.Format(
            @"SELECT 
                    ALMACEN_ID,
                    NOMBRE
                FROM
                    ALMACENES");
 
            Adapter.SelectCommand = Comando;
            DataTable tbResultado = new DataTable();
            Adapter.Fill(tbResultado);

            Almacen almacen;
            List<Almacen> lstAlmacenes = new List<Almacen>();
            foreach (DataRow fila in tbResultado.Rows)
            {
                almacen = new Almacen();
                almacen.ID = Convert.ToInt32(fila["ALMACEN_ID"]);
                almacen.Nombre = Convert.ToString(fila["NOMBRE"]);
                lstAlmacenes.Add(almacen);
            }

            return lstAlmacenes;
        }  
    }
}
