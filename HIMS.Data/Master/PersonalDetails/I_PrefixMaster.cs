﻿using HIMS.Model.Master.PersonalDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master.PersonalDetails
{
   public interface I_PrefixMaster
    {
        bool Update(PrefixMasterParams PrefixMasterParams);
        bool Save(PrefixMasterParams PrefixMasterParams);
    }
}
