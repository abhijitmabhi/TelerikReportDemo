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
    
    public partial class Admission_StudyLevelSubject
    {
        public long Id { get; set; }
        public long StudyLevelId { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long CreateById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
    }
}
