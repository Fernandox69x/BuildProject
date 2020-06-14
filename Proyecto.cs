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
    
    public partial class Proyecto
    {
        public Proyecto()
        {
            this.Alquilers = new HashSet<Alquiler>();
            this.Compras = new HashSet<Compra>();
            this.Salida_Inventario = new HashSet<Salida_Inventario>();
        }
    
        public int IdProyecto { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFinalizacion { get; set; }
        public string Nombre { get; set; }
        public string NombreB { get; set; }
        public int IdEmpleadoAsignado { get; set; }
        public int IdPlanilla { get; set; }
    
        public virtual ICollection<Alquiler> Alquilers { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Planilla Planilla { get; set; }
        public virtual ICollection<Salida_Inventario> Salida_Inventario { get; set; }
    }
}
