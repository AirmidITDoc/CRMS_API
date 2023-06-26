using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_DoctorTypeMaster:GenericRepository,I_DoctorTypeMaster
    {
        public R_DoctorTypeMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(Doctortypeparam Doctortypeparam)
        {
            // throw new NotImplementedException();
            var disc = Doctortypeparam.DoctortTypeMasterInsert.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("insert_DoctorTypeMaster_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(Doctortypeparam Doctortypeparam)
        {
            // throw new NotImplementedException();

            var disc1 = Doctortypeparam.DoctorTypeMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_DoctorTypeMaster_1", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
