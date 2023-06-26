using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_CompanyType
    {
        bool Update(CompanyTypeParam CompanyTypeParam);
        bool Save(CompanyTypeParam CompanyTypeParam);
    }
}
