using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_BankMaster
    {
        bool Update(BankMasterParams BankMasterParams);
        bool Save(BankMasterParams BankMasterParams);
    }
}
