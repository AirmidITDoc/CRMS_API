using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_StateMaster
    {
        bool Update(StateMasterParam StateMasterParam);
        bool Save(StateMasterParam StateMasterParam);
    }
}
