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
    
    public partial class Academic_OtherFee
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FeeType { get; set; }
        public Nullable<System.DateTime> PaymentDue { get; set; }
        public string AcademicSemester { get; set; }
        public Nullable<int> LocalStudent { get; set; }
        public Nullable<int> InternationalStudent { get; set; }
        public Nullable<bool> WithTax { get; set; }
        public string Remarks { get; set; }
        public string ChargingFrequency { get; set; }
        public Nullable<long> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastChanged { get; set; }
        public long LastChangedById { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
