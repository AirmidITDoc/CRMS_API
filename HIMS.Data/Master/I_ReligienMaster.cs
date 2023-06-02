using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_ReligienMaster
    {
        bool Update(ReliginMasterParam ReliginMasterParam);
        bool Save(ReliginMasterParam ReliginMasterParam);
    }
}
