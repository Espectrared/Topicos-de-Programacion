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
    
    public partial class Mapa_Curricular
    {
        public int ID { get; set; }
        public System.DateTime Vigencia_del_plan { get; set; }
        public int ProgramaEducativoID { get; set; }
    
        public virtual Programa_Educativo Programa_Educativo { get; set; }
    }
}
