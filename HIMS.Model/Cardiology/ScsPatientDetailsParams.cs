using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Cardiology
{
    public class ScsPatientDetailsParams
    {
        public SaveScsPatientDetails SaveScsPatientDetails { get; set; }
        public UpdateScsPatientDetails UpdateScsPatientDetails { get; set; }
    }

    public class SaveScsPatientDetails
    {
        public long ScsPatientId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }  
        public long SymtomTypeId { get; set; }  
        public string Angina { get; set; }
        public long InducibleIschemia { get; set; }  
        public string InducibleIschemiaResult { get; set; }
        public long CreatedBy { get; set; }
    }
    public class UpdateScsPatientDetails
    {
        public string Operation { get; set; }
        public long ScsPatientId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public long SymtomTypeId { get; set; }
        public string Angina { get; set; }
        public long InducibleIschemia { get; set; }
        public string InducibleIschemiaResult { get; set; }
        public long UpdatedBy { get; set; }
    }
}
