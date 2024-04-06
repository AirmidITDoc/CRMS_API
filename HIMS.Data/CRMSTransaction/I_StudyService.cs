using HIMS.Model.CRMSTransaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.CRMSTransaction
{
   public interface I_StudyService
    {
        public bool InsertStudyService(StudyServiceParam StudyServiceParam);
        public bool UpdateStudyService(StudyServiceParam StudyServiceParam);
        public bool UpdateStudyServiceId(StudyServiceParam StudyServiceParam);

    }
}
