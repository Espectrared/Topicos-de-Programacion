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
    
    public partial class Materia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materia()
        {
            this.Trayectorias_academicas = new HashSet<Trayectorias_academicas>();
            this.Programa_Educativo = new HashSet<Programa_Educativo>();
        }
    
        public int Clave { get; set; }
        public int Créditos { get; set; }
        public string Nombre { get; set; }
        public int Horas_clase { get; set; }
        public int Horas_laboratorio { get; set; }
        public int Horas_taller { get; set; }
        public string Etapa { get; set; }
        public int Semestre { get; set; }
        public bool Obligatoria { get; set; }
        public string Carta_descriptiva { get; set; }
        public bool Seriada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trayectorias_academicas> Trayectorias_academicas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programa_Educativo> Programa_Educativo { get; set; }
    }
}
