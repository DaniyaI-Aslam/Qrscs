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
    
    public partial class New_Admission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public New_Admission()
        {
            this.Audiology_Assessment = new HashSet<Audiology_Assessment>();
            this.BehavioralTherapies = new HashSet<BehavioralTherapy>();
            this.Case_History = new HashSet<Case_History>();
            this.IDD_Result = new HashSet<IDD_Result>();
            this.IEPlans = new HashSet<IEPlan>();
            this.IntelligenceQuotients = new HashSet<IntelligenceQuotient>();
            this.MidTerm_Result = new HashSet<MidTerm_Result>();
            this.OccupationalTherapy2 = new HashSet<OccupationalTherapy2>();
            this.OccupationalTherapy1 = new HashSet<OccupationalTherapy1>();
            this.Physiotherapies = new HashSet<Physiotherapy>();
            this.PsychologicalAssessments = new HashSet<PsychologicalAssessment>();
            this.Results = new HashSet<Result>();
            this.Speach_Case_History = new HashSet<Speach_Case_History>();
            this.Speech_Therapy_Assessment = new HashSet<Speech_Therapy_Assessment>();
            this.Student_Current_Class = new HashSet<Student_Current_Class>();
            this.Student_Current_Status = new HashSet<Student_Current_Status>();
        }
    
        public int GR_NO { get; set; }
        public int User_ID { get; set; }
        public System.DateTime Date_of_Addmission { get; set; }
        public string Student_First_Name { get; set; }
        public string Student_Last_Name { get; set; }
        public int Class { get; set; }
        public string Gender { get; set; }
        public System.DateTime Dob { get; set; }
        public string Place_of_Birth { get; set; }
        public string Religion { get; set; }
        public string Name_Last_School_Attended { get; set; }
        public string Hobbies { get; set; }
        public string Father_Name { get; set; }
        public string Education { get; set; }
        public string NIC { get; set; }
        public string Relationship_with_Student { get; set; }
        public string Monthly_Income { get; set; }
        public string Occupation { get; set; }
        public string Category { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_Code { get; set; }
        public string Contact { get; set; }
        public string Phone_Residence { get; set; }
        public string Phone_Office { get; set; }
        public string Disability { get; set; }
        public string Presenting_Complain { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public string Updated_By { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Audiology_Assessment> Audiology_Assessment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BehavioralTherapy> BehavioralTherapies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Case_History> Case_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IDD_Result> IDD_Result { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IEPlan> IEPlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IntelligenceQuotient> IntelligenceQuotients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MidTerm_Result> MidTerm_Result { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OccupationalTherapy2> OccupationalTherapy2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OccupationalTherapy1> OccupationalTherapy1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Physiotherapy> Physiotherapies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsychologicalAssessment> PsychologicalAssessments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Speach_Case_History> Speach_Case_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Speech_Therapy_Assessment> Speech_Therapy_Assessment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Current_Class> Student_Current_Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Current_Status> Student_Current_Status { get; set; }
    }
}
