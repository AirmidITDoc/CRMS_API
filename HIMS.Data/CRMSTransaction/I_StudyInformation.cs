using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSTransaction;

namespace HIMS.Data.CRMSTransaction
{
    public interface I_StudyInformation
    {
        public String InsertStudyInformation(StudyInformationParams StudyInformation);
        public bool UpdateStudyInformation(StudyInformationParams StudyInformation);
    }
}
