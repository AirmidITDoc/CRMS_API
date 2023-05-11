using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_DepartmentType:GenericRepository,I_DepartmentType
    {
        public R_DepartmentType(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public bool Insert(DepartmentTypeParam DepartmentTypeParam)
        {
            //throw new NotImplementedException();

            var dic = DepartmentTypeParam.DocDepartmentSave.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("insert_DoctorDepartmentDet", dic);

            _unitofWork.SaveChanges();

            return true;
        }

        public bool Update(DepartmentTypeParam DepartmentTypeParam)
        {
            // throw new NotImplementedException();
            var dic = DepartmentTypeParam.DocDepartmentUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_DocDepartmentDetail", dic);

            _unitofWork.SaveChanges();

            return true;
        }
    }
}
