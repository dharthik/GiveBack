//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GivingBack2.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductResource
    {
        public long Id { get; set; }
        public Nullable<long> ReqId { get; set; }
        public string Unit { get; set; }
        public Nullable<long> Quantity { get; set; }
        public string Name { get; set; }
        public Nullable<long> ResourceId { get; set; }
    
        public virtual Requirement Requirement { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
