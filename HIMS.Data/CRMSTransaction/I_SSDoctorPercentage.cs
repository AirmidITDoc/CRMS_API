using HIMS.Model.CRMSTransaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.CRMSTransaction
{
   public interface I_SSDoctorPercentage
    {
        public bool Insert(SSDoctorPercentageparam SSDoctorPercentageparam);
        public bool update(SSDoctorPercentageparam SSDoctorPercentageparam);
    }
}
