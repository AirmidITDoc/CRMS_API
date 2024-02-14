using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;
namespace HIMS.Data.Cardiology
{
    public interface I_LesionDetails
    {
        public String SaveLesionDetails(LesionDetailsParams lesionDetailsParams);
        public bool UpdateLesionDetails(LesionDetailsParams lesionDetailsParams);
    }
}
