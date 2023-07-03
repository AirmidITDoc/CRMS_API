using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_CompanyTypeMaster
    {
        bool Update(CompanyTypeMasterParams CompanyTypeMasterParams);
        bool Save(CompanyTypeMasterParams CompanyTypeMasterParams);
    }
}
