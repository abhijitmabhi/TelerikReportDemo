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
    
    public partial class Admission_ApplicantEnglishProficiency
    {
        public long Id { get; set; }
        public long ApplicantId { get; set; }
        public long ApplicationId { get; set; }
        public long EnglishProficiencyId { get; set; }
        public string Remarks { get; set; }
        public string Grade { get; set; }
        public string GradePoint { get; set; }
        public string Marks { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long CreateById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Admission_Applicant Admission_Applicant { get; set; }
    }
}
