using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_ConcessionReasion:GenericRepository,I_ConcessionReasion
    {
        public R_ConcessionReasion(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(ConcessionReasionParam ConcessionReasionParam)
        {
            // throw new NotImplementedException();

            var disc = ConcessionReasionParam.ConsessionReasonMasterInsert.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("insert_ConcessionReasonMaster_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(ConcessionReasionParam ConcessionReasionParam)
        {
            //throw new NotImplementedException();

            var disc1 = ConcessionReasionParam.ConsessionReasonMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_ConcessionReasonMaster_1", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
