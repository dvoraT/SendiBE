//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.CUSTOMER = new HashSet<CUSTOMER>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ROUTE_ID { get; set; }
        public string USERNAME { get; set; }
        public string USER_PASSWORD { get; set; }
        public string NAME { get; set; }
        public string ADRESS { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER> CUSTOMER { get; set; }
        public virtual ROUTE ROUTE { get; set; }
    }
}