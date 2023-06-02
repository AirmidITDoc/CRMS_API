using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_CountryMaster
    {
        bool Update(CountryMasterParam CountryMasterParam);
        bool Save(CountryMasterParam CountryMasterParam);
    }
}

