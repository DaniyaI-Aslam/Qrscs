//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QRSCS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MovementProcessing_OT2
    {
        public int MovementProcessingOT2_ID { get; set; }
        public int OT2_ID { get; set; }
        public string SK_27 { get; set; }
        public string SK_28 { get; set; }
        public string SK_29 { get; set; }
        public string SK_30 { get; set; }
        public string SK_31 { get; set; }
        public string SK_32 { get; set; }
        public string RG_33 { get; set; }
        public string RG_34 { get; set; }
        public Nullable<int> Movement_Raw_Score { get; set; }
        public string Movement_Comments { get; set; }
    
        public virtual OccupationalTherapy2 OccupationalTherapy2 { get; set; }
    }
}