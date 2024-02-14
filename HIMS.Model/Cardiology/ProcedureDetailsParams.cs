using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Cardiology
{
    public class ProcedureDetailsParams
    {
        public SaveProcedureDetails SaveProcedureDetails { get; set; }
        public UpdateProcedureDetails UpdateProcedureDetails { get; set; }
    }
    public class SaveProcedureDetails
    {
        public long ProcedureId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public float AortogramSystolic { get; set; }
        public float AortogramDiastolic { get; set; }
        public float AortogramMAP { get; set; }
        public float LVEDP { get; set; }
        public float PASystolic { get; set; }
        public float PADiastolic { get; set; }
        public float PAMAP { get; set; }
        public float PAPCWP { get; set; }
        public long CreatedBy { get; set; }
    }
    public class UpdateProcedureDetails
    {
        public string Operation { get; set; }
        public long ProcedureId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public float AortogramSystolic { get; set; }
        public float AortogramDiastolic { get; set; }
        public float AortogramMAP { get; set; }
        public float LVEDP { get; set; }
        public float PASystolic { get; set; }
        public float PADiastolic { get; set; }
        public float PAMAP { get; set; }
        public float PAPCWP { get; set; }
        public long UpdatedBy { get; set; }
    }
}
