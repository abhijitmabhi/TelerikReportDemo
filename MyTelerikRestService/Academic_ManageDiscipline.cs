//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTelerikRestService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Academic_ManageDiscipline
    {
        public long Id { get; set; }
        public int CaseNumber { get; set; }
        public long UserId { get; set; }
        public string DisciplineType { get; set; }
        public string Description { get; set; }
        public string DisciplineCategory { get; set; }
        public string Status { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public bool IsDeleted { get; set; }
    }
}
