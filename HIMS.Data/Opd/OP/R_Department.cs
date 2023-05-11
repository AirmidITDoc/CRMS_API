using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_Department:GenericRepository,I_Department
    {
        public R_Department(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Insert(DepartmentParam DepartmentParam)
        {
            // throw new NotImplementedException();

            var dic = DepartmentParam.DepartmentSave.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("insert_DepartmentMaster_1", dic);

            _unitofWork.SaveChanges();

            return true;
        }

        public bool Update(DepartmentParam DepartmentParam)
        {
            //throw new NotImplementedException();
            var dic = DepartmentParam.DepartmentUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_Department", dic);

            _unitofWork.SaveChanges();

            return true;

        }
    }
}
