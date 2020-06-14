//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RTCONSTRUCCIONES
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public Producto()
        {
            this.DetalleCompras = new HashSet<DetalleCompra>();
            this.DetalleEntradas = new HashSet<DetalleEntrada>();
            this.DetalleSalidas = new HashSet<DetalleSalida>();
        }
    
        public int IdProd { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public int Cantidad { get; set; }
        public int IdCategoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
        public virtual ICollection<DetalleEntrada> DetalleEntradas { get; set; }
        public virtual ICollection<DetalleSalida> DetalleSalidas { get; set; }
    }
}