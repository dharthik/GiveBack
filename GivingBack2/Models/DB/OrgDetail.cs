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
    
    public partial class OrgDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrgDetail()
        {
            this.Requirements = new HashSet<Requirement>();
        }
    
        public long OrgId { get; set; }
        public string OrgName { get; set; }
        public Nullable<System.DateTime> EnrolledDate { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requirement> Requirements { get; set; }
    }
}
