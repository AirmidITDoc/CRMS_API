using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Cardiology
{
    public class PatientPastHistoryParams
    {
        public SavePatientPastHistory SavePatientPastHistory { get; set; }
        public UpdatePatientPastHistory UpdatePatientPastHistory { get; set; }
        public SavePatient2DEchoDetails SavePatient2DEchoDetails { get; set; }
    }

    public class SavePatientPastHistory
    {
        public long PastHistoryId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public string Angioplasty { get; set; }
        public string CABG { get; set; }
        public string VascularProcedure { get; set; }
        public long CreatedBy { get; set; }

    }

    public class UpdatePatientPastHistory
    {
        public string Operation { get; set; }
        public long PastHistoryId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public string Angioplasty { get; set; }
        public string CABG { get; set; }
        public string VascularProcedure { get; set; }
        public long UpdatedBy { get; set; }
    }

    public class SavePatient2DEchoDetails
    {
        public long Patient2DEchoId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public string LVEF { get; set; }
        public bool GlobalGLS { get; set; }
        public long RWMA { get; set; }
        public string Valve { get; set; }
        public string Stenotic { get; set; }
        public string Regurgitation { get; set; }
        public string MRAR { get; set; }
        public string MSAS { get; set; }
        public long CreatedBy { get; set; }
    }
}
