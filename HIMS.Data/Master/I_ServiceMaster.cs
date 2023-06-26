using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
  public  interface I_ServiceMaster
    {
        bool Update(ServiceMasterParam ServiceMasterParam);
        bool Save(ServiceMasterParam ServiceMasterParam);
    }
}
