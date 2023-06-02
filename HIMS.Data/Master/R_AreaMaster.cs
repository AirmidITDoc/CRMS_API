using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
  public  class R_AreaMaster :GenericRepository,I_AreaMaster
    {
        public R_AreaMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork

        }

        public bool Save(AreaMasterParam AreaMasterParam)
        {
           // throw new NotImplementedException();
            var disc1 = AreaMasterParam.AreaMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_AreaMaster_1", disc1);
            //commit transaction
            _unitofWork.SaveChanges();
            return true;

        }

        public bool Update(AreaMasterParam AreaMasterParam)
        {
            // throw new NotImplementedException();

            var disc = AreaMasterParam.AreaMasterInsert.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("insert_AreaMaster_1", disc);
            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
