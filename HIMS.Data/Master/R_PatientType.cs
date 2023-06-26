using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_PatientType:GenericRepository,I_PatientType
    {
        public R_PatientType(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(PatientTypeParam PatientTypeParam)
        {
            // throw new NotImplementedException();
            var disc = PatientTypeParam.PatientTypeMasterInsert.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("insert_PatientTypeMaster_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(PatientTypeParam PatientTypeParam)
        {
            // throw new NotImplementedException();
            var disc1 = PatientTypeParam.PatientTypeMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Update_M_PatientTypeMaster", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
