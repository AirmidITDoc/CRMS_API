using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_PatientType
    {
        bool Update(PatientTypeParam PatientTypeParam);
        bool Save(PatientTypeParam PatientTypeParam);
    }
}
