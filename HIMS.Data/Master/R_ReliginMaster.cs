using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
    public class R_ReliginMaster : GenericRepository, I_ReligienMaster
    {
        public R_ReliginMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(ReliginMasterParam ReliginMasterParam)
        {
            // throw new NotImplementedException();

            var disc1 = ReliginMasterParam.ReligionMasterInsert.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("insert_ReligionMaster_1", disc1); 

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(ReliginMasterParam ReliginMasterParam)
        {
            // throw new NotImplementedException();

            var disc = ReliginMasterParam.ReligionMasterUpdate.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("Update_M_ReligionMaster", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
