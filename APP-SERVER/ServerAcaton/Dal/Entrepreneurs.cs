//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entrepreneurs
    {
        public int IdEntrepreneur { get; set; }
        public byte[] Image { get; set; }
        public string CompanyName { get; set; }
        public string Miles { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
