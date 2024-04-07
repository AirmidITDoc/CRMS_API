using HIMS.Common.Utility;
using HIMS.Model.CRMSTransaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.CRMSTransaction
{
   public class R_SSDoctorPercentage:GenericRepository,I_SSDoctorPercentage
    {
        public R_SSDoctorPercentage(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Insert(SSDoctorPercentageparam SSDoctorPercentageparam)
        {
            // throw new NotImplementedException();
            var disc = SSDoctorPercentageparam.InsertDoctorPercentage.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("insert_SSDoctorpercentage", disc);

            _unitofWork.SaveChanges();
            return true;
        }

        public bool update(SSDoctorPercentageparam SSDoctorPercentageparam)
        {
            // throw new NotImplementedException();

            var disc = SSDoctorPercentageparam.UpdateDoctorPercentage.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_SSDoctorpercentage", disc);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
