//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M13TipusHab.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class costaDia
    {
        public int TipusHab_codi { get; set; }
        public System.DateTime data { get; set; }
        public decimal preu { get; set; }
    
        public virtual calendari calendari { get; set; }
        public virtual tipusHab tipusHab { get; set; }
    }
}
