using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSTransaction;

namespace HIMS.Data.CRMSTransaction
{
    public interface I_StudySchedule
    {
        public bool InsertStudySchedule(StudyScheduleParams studyScheduleParams);
        public bool UpdateStudySchedule(StudyScheduleParams studyScheduleParams);
        public bool UpdateStudyScheduleId(StudyScheduleParams studyScheduleParams);
    }
}
