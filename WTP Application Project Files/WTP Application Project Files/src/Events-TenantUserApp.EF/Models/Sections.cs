//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Events_TenantUserApp.EF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sections()
        {
            this.EventSections = new HashSet<EventSections>();
        }
    
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public short SeatRows { get; set; }
        public short SeatsPerRow { get; set; }
        public decimal StandardPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventSections> EventSections { get; set; }
    }
}