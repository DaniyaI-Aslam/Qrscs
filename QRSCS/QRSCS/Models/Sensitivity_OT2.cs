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
    
    public partial class Sensitivity_OT2
    {
        public int SensitivityOT2_ID { get; set; }
        public int OT2_ID { get; set; }
        public string Raw_Score_3 { get; set; }
        public string Raw_Score_4 { get; set; }
        public string Raw_Score_6 { get; set; }
        public string Raw_Score_7 { get; set; }
        public string Raw_Score_9 { get; set; }
        public string Raw_Score_10 { get; set; }
        public string Raw_Score_13 { get; set; }
        public string Raw_Score_16 { get; set; }
        public string Raw_Score_19 { get; set; }
        public string Raw_Score_20 { get; set; }
        public string Raw_Score_44 { get; set; }
        public string Raw_Score_45 { get; set; }
        public string Raw_Score_46 { get; set; }
        public string Raw_Score_47 { get; set; }
        public string Raw_Score_52 { get; set; }
        public string Raw_Score_69 { get; set; }
        public string Raw_Score_73 { get; set; }
        public string Raw_Score_77 { get; set; }
        public string Raw_Score_78 { get; set; }
        public string Raw_Score_84 { get; set; }
        public Nullable<int> Sensitivity_Score { get; set; }
    
        public virtual OccupationalTherapy2 OccupationalTherapy2 { get; set; }
    }
}