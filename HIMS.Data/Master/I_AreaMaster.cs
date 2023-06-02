using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_AreaMaster
    {
        bool Update(AreaMasterParam AreaMasterParam);
        bool Save(AreaMasterParam AreaMasterParam);
    }
}
