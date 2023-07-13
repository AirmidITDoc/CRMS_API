using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSMaster;

namespace HIMS.Data.CRMSMaster
{
    public interface I_InstitutionInformation
    {
        public String InsertInstitutionInformation(InstitutionInformationParams institutionInformationParams);
        public bool UpdateInstitutionInformation(InstitutionInformationParams institutionInformationParams);
    }
}
