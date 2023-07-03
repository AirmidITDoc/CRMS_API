using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_GenderMaster
    {
        bool Update(GenderMasterParams GenderMasterParams);
        bool Save(GenderMasterParams GenderMasterParams);
       
    }
}
