//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mapa_Curricular
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expedientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Expedientes()
        {
            this.Tutores = new HashSet<Tutores>();
        }
    
        public int ID { get; set; }
        public bool Estado { get; set; }
        public string Etapa { get; set; }
        public string Programa_Educativo { get; set; }
        public int Matricula { get; set; }
    
        public virtual Estudiantes Estudiantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tutores> Tutores { get; set; }
    }
}
