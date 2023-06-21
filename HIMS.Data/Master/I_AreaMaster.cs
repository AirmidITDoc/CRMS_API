using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_AreaMaster
    {
       public bool Update(AreaMasterParam AreaMasterParam);
      public  bool Save(AreaMasterParam AreaMasterParam);
    }
}
