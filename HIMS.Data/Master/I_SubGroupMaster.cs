using HIMS.Model.Master;
using HIMS.Model.Master.Billing;
using System;
using System.Collections.Generic;
using System.Text;
//using HIMS.Model.Master.Billing;

namespace HIMS.Data.Master
{
  public  interface I_SubGroupMaster
    {
        bool Update(SubGroupMasterParams SubGroupMasterParams);
        bool Save(SubGroupMasterParams SubGroupMasterParams);
    }
}
