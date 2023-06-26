using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Opd.OP
{
  public  class CaseDetail
    {
        public InsertCaseDetail InsertCaseDetail { get; set; }

        public UpdateCaseDetail UpdateCaseDetail { get; set; }

    }

    public class InsertCaseDetail
    {
       
        public int CaseId { get; set; }
        public String CaseTitle { get; set; }
        public String CaseDescription { get; set; }
        public int TotalSubjects { get; set; }
        public int TotalVisits { get; set; }
        public String VisitFrequency { get; set; }
        public DateTime CaseStartDate { get; set; }
        public DateTime CaseEndDate { get; set; }
        public String CaseStatus { get; set; }
        public String CompanyName { get; set; }
        public String CaseRepresentative { get; set; }
        public String HospitalRepresentative { get; set; }
        public String AgreementFileName { get; set; }
        public int CreatedBy { get; set; }
      
    }

    public class UpdateCaseDetail
    {

        public int CaseId { get; set; }
        public String CaseTitle { get; set; }
        public String CaseDescription { get; set; }
        public int TotalSubjects { get; set; }
        public int TotalVisits { get; set; }
        public String VisitFrequency { get; set; }
        public DateTime CaseStartDate { get; set; }
        public DateTime CaseEndDate { get; set; }
        public String CaseStatus { get; set; }
        public String CompanyName { get; set; }
        public String CaseRepresentative { get; set; }
        public String HospitalRepresentative { get; set; }
        public String AgreementFileName { get; set; }
        public int CreatedBy { get; set; }

        public bool IsActive { get; set; }
        public int UpdatedBy { get; set; }

    }
}