using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectivasEnSucursales.Modelos
{
    public class Etiqueta
    {
        public string NumeroDeEtiqueta { set; get; }
        public string ClaveNombre { set; get; }
        public DateTime FechaDeEmpaque { set; get; }
        public DateTime FechaDeCaducidad { set; get; }
        public decimal Cantidad { set; get; }
        public string Unidad { set; get; }
    }
}
