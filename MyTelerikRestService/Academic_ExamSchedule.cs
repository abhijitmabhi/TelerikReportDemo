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
    
    public partial class Academic_ExamSchedule
    {
        public long Id { get; set; }
        public long StudyIntake { get; set; }
        public long SubjectCode { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string Venue { get; set; }
        public string HeadInvigilator { get; set; }
        public string InvigilatorI { get; set; }
        public string InvigilatorII { get; set; }
        public string InvigilatorIII { get; set; }
        public string InvigilatorIV { get; set; }
        public string Remarks { get; set; }
        public long CreateById { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public bool IsDeleted { get; set; }
    }
}
