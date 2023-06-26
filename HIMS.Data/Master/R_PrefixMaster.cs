using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
  public  class R_PrefixMaster:GenericRepository,I_PrefixMaster
    {
        public R_PrefixMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(PrefixMasterParam PrefixMasterParam)
        {
            // throw new NotImplementedException();
            var disc = PrefixMasterParam.PrefixMasterInsert.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("ps_Insert_M_PrefixMaster", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(PrefixMasterParam PrefixMasterParam)
        {
            // throw new NotImplementedException();

            var disc1 = PrefixMasterParam.PrefixMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("ps_Update_M_PrefixMaster", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
