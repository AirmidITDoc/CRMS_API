using System;
using System.Collections.Generic;
using System.Text;

using HIMS.Model.Master;

namespace HIMS.Data.Master
{
   public interface I_GroupMaster
    {
        bool Update(GroupMasterParams GroupMasterParams);
        bool Save(GroupMasterParams GroupMasterParams);
    }
}
