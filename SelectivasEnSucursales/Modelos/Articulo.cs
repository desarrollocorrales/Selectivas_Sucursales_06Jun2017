
namespace SelectivasEnSucursales.Modelos
{
    public class Articulo
    {
        public int Articulo_ID       { set; get; }
        public string Nombre         { set; get; }
        public string ClavePrincipal { set; get; }
        public string Clave          { set; get; }
        public decimal Existencia    { set; get; }
        public decimal Fisico        { set; get; }
    }
}
