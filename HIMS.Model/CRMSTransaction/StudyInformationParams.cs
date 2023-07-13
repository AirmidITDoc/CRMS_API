using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSTransaction
{
    public class StudyInformationParams
    {
        public InsertStudyInformation InsertStudyInformation { get; set; }
        public UpdateStudyInformation UpdateStudyInformation { get; set; }
    }

    public class InsertStudyInformation
    {
		public string ProtocolNo  { get; set; }
		public string ProtocolTitle { get; set; }
		public string StudyProduct { get; set; }
		public int TotalSubjects { get; set; }
		public int TotalVisits { get; set; }
		public int VisitFrequency { get; set; }
		public int Sponser { get; set; }
		public string Investigator { get; set; }
		public int Institution { get; set; }
		public DateTime StudyStartDate { get; set; }
		public DateTime StudyEndDate { get; set; }
		public string AgreementFileName { get; set; }
		public int CreatedBy { get; set; }
		public int StudyId { get; set; }

	}

    public class UpdateStudyInformation
    {
		public string Operation { get; set; }
		public string ProtocolNo { get; set; }
		public string ProtocolTitle { get; set; }
		public string StudyProduct { get; set; }
		public int TotalSubjects { get; set; }
		public int TotalVisits { get; set; }
		public int VisitFrequency { get; set; }
		public int Sponser { get; set; }
		public string Investigator { get; set; }
		public int Institution { get; set; }
		public DateTime StudyStartDate { get; set; }
		public DateTime StudyEndDate { get; set; }
		public string AgreementFileName { get; set; }
		public int UpdatedBy { get; set; }
		public int StudyId { get; set; }

	}


}
