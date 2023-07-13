using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSMaster;

namespace HIMS.Data.CRMSMaster
{
    public interface I_SponserInformation
    {
        public String InsertSponserInformation(SponserInformationParams sponserInformationParams);
        public bool UpdateSponserInformation(SponserInformationParams sponserInformationParams);
    }
}
