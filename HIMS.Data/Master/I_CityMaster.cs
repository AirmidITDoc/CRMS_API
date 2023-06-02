using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
 public   interface I_CityMaster
    {
        bool Update(CityMasterParam CityMasterParam);
        bool Save(CityMasterParam CityMasterParam);
    }
}
