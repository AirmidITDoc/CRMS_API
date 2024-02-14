using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;

namespace HIMS.Data.Cardiology
{
    public interface I_PatientPastHistory
    {
        public String SavePatientPastHistory(PatientPastHistoryParams patientPastHistoryParams);
        public bool UpdatePatientPastHistory(PatientPastHistoryParams patientPastHistoryParams);
        public String SavePatient2DEchoDetails(PatientPastHistoryParams patientPastHistoryParams);
    }
}
