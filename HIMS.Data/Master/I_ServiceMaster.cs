﻿using HIMS.Model.Master;
using HIMS.Model.Master.Billing;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_ServiceMaster
    {
        bool Update(ServiceMasterParams ServiceMasterParams);
        bool Save(ServiceMasterParams ServiceMasterParams);
    }
}
