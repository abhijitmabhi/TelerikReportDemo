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
    
    public partial class User_Employee
    {
        public long Id { get; set; }
        public byte EmployeeCategoryEnumId { get; set; }
        public byte EmployeeTypeEnumId { get; set; }
        public byte JobClassEnumId { get; set; }
        public byte JobTypeEnumId { get; set; }
        public byte WorkingStatusEnumId { get; set; }
        public string IncomeTaxNo { get; set; }
        public string ProvidentFundNo { get; set; }
        public string EmployeeInsuranceNo { get; set; }
        public string MedicalInsuranceNo { get; set; }
        public System.DateTime JoiningDate { get; set; }
        public long DepartmentId { get; set; }
        public Nullable<long> PositionId { get; set; }
        public byte IncrementMonthEnumId { get; set; }
        public bool IsWorking { get; set; }
        public Nullable<System.DateTime> LeavingDate { get; set; }
        public Nullable<long> ImmediateSupervisorId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long CreateById { get; set; }
        public System.DateTime LastChanged { get; set; }
        public long LastChangedById { get; set; }
    
        public virtual User_Account User_Account { get; set; }
    }
}