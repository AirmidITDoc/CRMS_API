using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_ClassMaster:GenericRepository,I_ClassMaster
    {
        public R_ClassMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Save(Classparam Classparam)
        {
            // throw new NotImplementedException();

            var disc = Classparam.ClassMasterInsert.ToDictionary();

            ExecNonQueryProcWithOutSaveChanges("insert_ClassMaster_1", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }

        public bool Update(Classparam Classparam)
        {
            // throw new NotImplementedException();
            var disc1 = Classparam.ClassMasterUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_ClassMaster_1", disc1);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
