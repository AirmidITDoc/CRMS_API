using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_StateMaster:GenericRepository,I_StateMaster
    {
        public R_StateMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(StateMasterParam StateMasterParam)
        {
            //  throw new NotImplementedException();

            var disc1 = StateMasterParam.StateMasterInsert.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("insert_StateMaster_1", disc1); 

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(StateMasterParam StateMasterParam)
        {
            // throw new NotImplementedException();

            var disc = StateMasterParam.StateMasterUpdate.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("update_StateMaster_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
