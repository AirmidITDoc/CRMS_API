using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;
namespace HIMS.Data.Cardiology
{
    public interface I_ScsPatientDetails
    {
        public String SaveScsPatientDetails(ScsPatientDetailsParams scsPatientDetailsParams);
        public bool UpdateScsPatientDetails(ScsPatientDetailsParams scsPatientDetailsParams);
    }
}
