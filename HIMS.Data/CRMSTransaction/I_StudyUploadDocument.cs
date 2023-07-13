using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSTransaction;

namespace HIMS.Data.CRMSTransaction
{
    public interface I_StudyUploadDocument
    {
        public string InsertStudyUploadDocument(StudyUploadDocumentParams studyUploadDocumentParams);
        public bool UpdateStudyUploadDocument(StudyUploadDocumentParams studyUploadDocumentParams);
    }
}
