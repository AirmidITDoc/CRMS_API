using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Cardiology
{
    public class LesionDetailsParams
    {
        public SaveLesionDetails SaveLesionDetails { get; set; }
        public UpdateLesionDetails UpdateLesionDetails { get; set; }
    }
    public class SaveLesionDetails
    {
        public long LesionId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public long ProcedureId { get; set; }
        public string LesionType { get; set; }
        public string Location { get; set; }
        public float SyntaxScore { get; set; }
        public long IndexLesion { get; set; }
        public string LesionSeverity { get; set; }
        public string LesionDevice { get; set; }
        public string Calcified { get; set; }
        public string Thrombus { get; set; }
        public string ProximalTortuosity { get; set; }
        public string ImpSideBranch { get; set; }
        public long CreatedBy { get; set; }
    }
    public class UpdateLesionDetails
    {
        public string Operation { get; set; }
        public long LesionId { get; set; }
        public long PatientId { get; set; }
        public long VisitId { get; set; }
        public long ProcedureId { get; set; }
        public string LesionType { get; set; }
        public string Location { get; set; }
        public float SyntaxScore { get; set; }
        public long IndexLesion { get; set; }
        public string LesionSeverity { get; set; }
        public string LesionDevice { get; set; }
        public string Calcified { get; set; }
        public string Thrombus { get; set; }
        public string ProximalTortuosity { get; set; }
        public string ImpSideBranch { get; set; }
        public long UpdatedBy { get; set; }
    }
}
