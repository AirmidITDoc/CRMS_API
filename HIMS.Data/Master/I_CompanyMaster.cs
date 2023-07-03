using HIMS.Model.Master;

using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_CompanyMaster
    {
        bool Update(CompanyMasterParams CompanyMasterParams);
        bool Save(CompanyMasterParams CompanyMasterParams);
    }
}
