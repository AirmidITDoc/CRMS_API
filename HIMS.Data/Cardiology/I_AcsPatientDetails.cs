using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;
namespace HIMS.Data.Cardiology
{
    public interface I_AcsPatientDetails
    {
        public String SaveAcsPatientDetails(AcsPatientDetailsParams acsPatientDetailsParams);
        public bool UpdateAcsPatientDetails(AcsPatientDetailsParams acsPatientDetailsParams);
    }
}
