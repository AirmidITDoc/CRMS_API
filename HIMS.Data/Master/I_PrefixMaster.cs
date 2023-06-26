using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_PrefixMaster
    {
        bool Update(PrefixMasterParam PrefixMasterParam);
        bool Save(PrefixMasterParam PrefixMasterParam);
    }
}
