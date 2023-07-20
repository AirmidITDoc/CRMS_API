using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.CRMSTransaction
{
    public class StudyUploadDocumentParams
    {
        public List<InsertStudyUploadDocument> InsertStudyUploadDocument{ get; set;}
        public UpdateStudyUploadDocument UpdateStudyUploadDocument { get; set; }

    }
    public class InsertStudyUploadDocument
    {
        public int StudyDocId { get; set; }
        public int StudyId { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentName { get; set; }
	    public string DocumentPath { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateStudyUploadDocument
    {
        public string Operation { get;set; }
        public int StudyDocId { get; set; }
        public int StudyId { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public int UpdatedBy { get; set; }
    }

}
