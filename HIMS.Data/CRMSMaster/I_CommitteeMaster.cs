using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.CRMSMaster;

namespace HIMS.Data.CRMSMaster
{
    public interface I_CommitteeMaster
    {
        String InsertCommitteeMaster(CommitteeMasterParams committeeMasterParams);
    }
}
