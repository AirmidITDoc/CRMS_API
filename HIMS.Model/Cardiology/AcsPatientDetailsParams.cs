using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Cardiology
{
    public class AcsPatientDetailsParams
    {
        public SaveAcsPatientDetails SaveAcsPatientDetails { get; set; }
        public UpdateAcsPatientDetails UpdateAcsPatientDetails { get; set; }
    }

    public class SaveAcsPatientDetails
    {
        public long AcsPatientId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public string ACSType { get; set; }
        public float CPPresentation { get; set; }
        public bool Hemodynamics { get; set; }
        public bool Hypotension { get; set; }
        public bool Tachy { get; set; }
        public bool Brady { get; set; }
        public bool ROSC { get; set; }
        public long AnatomicalPosition { get; set; }
        public string StemiOther { get; set; }
        public bool EKGChange { get; set; }
        public bool EnzymeRaised { get; set; }
        public string Other { get; set; }
        public string NstemiOther { get; set; }
        public long CreatedBy { get; set; }
    }

    public class UpdateAcsPatientDetails
    {
        public string Operation { get; set; }
        public long AcsPatientId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public string ACSType { get; set; }
        public float CPPresentation { get; set; }
        public bool Hemodynamics { get; set; }
        public bool Hypotension { get; set; }
        public bool Tachy { get; set; }
        public bool Brady { get; set; }
        public bool ROSC { get; set; }
        public long AnatomicalPosition { get; set; }
        public string StemiOther { get; set; }
        public bool EKGChange { get; set; }
        public bool EnzymeRaised { get; set; }
        public string Other { get; set; }
        public string NstemiOther { get; set; }
        public long UpdatedBy { get; set; }
    }
}
