using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_DoctorTypeMaster
    {
        bool Save(Doctortypeparam Doctortypeparam);
        bool Update(Doctortypeparam Doctortypeparam);

    }
}
