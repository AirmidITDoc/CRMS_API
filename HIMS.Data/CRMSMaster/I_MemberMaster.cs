using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSMaster;

namespace HIMS.Data.CRMSMaster
{
    public interface I_MemberMaster
    {
        public String InsertMemberMaster(MemberMasterParams memberMasterParams);
        public bool UpdateMemberMaster(MemberMasterParams memberMasterParams);
    }
}
