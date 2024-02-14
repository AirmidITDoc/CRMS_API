using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Cardiology
{
    public class IdcadPatientDetailsParams
    {
        public SaveIdcadPatientDetails SaveIdcadPatientDetails { get; set; }
        public UpdateIdcadPatientDetails UpdateIdcadPatientDetails { get; set; }
    }

    public class SaveIdcadPatientDetails
    {
        public long IdcadPatientId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public long SymtomTypeId { get; set; }
        public string CT { get; set; }
        public string CalciumScore { get; set; }
        public string IdcadOther { get; set; }
        public long CreatedBy { get; set; }

    }

    public class UpdateIdcadPatientDetails
    {
        public string Operation { get; set; }
        public long IdcadPatientId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public long SymtomTypeId { get; set; }
        public string CT { get; set; }
        public string CalciumScore { get; set; }
        public string IdcadOther { get; set; }
        public long UpdatedBy { get; set; }
    }
}
