using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_BankMaster
    {
        bool Update(BankMasterParam BankMasterParam);
        bool Save(BankMasterParam BankMasterParam);
    }
}
