using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_BankMaster:GenericRepository,I_BankMaster
    {
        public R_BankMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(BankMasterParam BankMasterParam)
        {
            // throw new NotImplementedException();
            var disc = BankMasterParam.BankMasterInsert.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("insert_BankName_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(BankMasterParam BankMasterParam)
        {
            // throw new NotImplementedException();
            var disc1 = BankMasterParam.BankMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_BankMaster_1", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
