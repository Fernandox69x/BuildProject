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
    
    public partial class DetalleCompra
    {
        public int IdProd { get; set; }
        public int IdCompra { get; set; }
        public int Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
    
        public virtual Compra Compra { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
