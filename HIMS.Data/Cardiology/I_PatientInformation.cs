using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;

namespace HIMS.Data.Cardiology
{
    public interface I_PatientInformation
    {
        public String SavePatientInformation(PatientInformationParams patientInformationParams);
        public bool UpdatePatientInformation(PatientInformationParams patientInformationParams);
    }
}
