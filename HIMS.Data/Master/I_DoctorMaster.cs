using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_DoctorMaster
    {
        String Insert(DoctorMasterparam DoctorMasterparam);
        bool Update(DoctorMasterparam DoctorMasterparam);
    }
}
