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
    
    public partial class Admission_ApplicantMedicalTest
    {
        public long Id { get; set; }
        public long ApplicantId { get; set; }
        public long MedicalTestId { get; set; }
        public bool Status { get; set; }
        public string Remarks { get; set; }
        public long ApplicationId { get; set; }
        public string DocumentUrl { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long CreateById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Admission_Applicant Admission_Applicant { get; set; }
        public virtual Admission_MedicalTest Admission_MedicalTest { get; set; }
    }
}
