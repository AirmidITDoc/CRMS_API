using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_MaritalStatusMaster
    {
        bool Update(MaritalStatusMasterParams MaritalStatusMasterParams);
        bool Save(MaritalStatusMasterParams MaritalStatusMasterParams);
    }
}
