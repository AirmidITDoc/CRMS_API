﻿using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public interface I_VisitMaster
    {
        bool Update(VisitMasterParam VisitMasterParam);
        String Save(VisitMasterParam VisitMasterParam);
    }
}
