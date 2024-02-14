using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;
namespace HIMS.Data.Cardiology
{
    public interface I_IdcadPatientDetails
    {
        public String SaveIdcadPatientDetails(IdcadPatientDetailsParams idcadPatientDetailsParams);
        public bool UpdateIdcadPatientDetails(IdcadPatientDetailsParams idcadPatientDetailsParams);
    }
}
