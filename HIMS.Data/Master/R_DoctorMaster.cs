using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_DoctorMaster :GenericRepository,I_DoctorMaster
    {
        public R_DoctorMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string Insert(DoctorMasterparam DoctorMasterparam)
        {
            //throw new NotImplementedException();
            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@DoctorId",
                Value = 0,
                Direction = ParameterDirection.Output
            };
            var disc1 = DoctorMasterparam.InsertDoctorMaster.ToDictionary();
            disc1.Remove("DoctorId");
            var doctorId = ExecNonQueryProcWithOutSaveChanges("Insert_DoctorMaster_1", disc1, outputId);

            //add DoctorDetails

            foreach (var a in DoctorMasterparam.AssignDoctorDepartmentDet)
            {
                var disc = a.ToDictionary();
                disc["DoctorId"] = doctorId;
                ExecNonQueryProcWithOutSaveChanges("Insert_M_DoctorDepartmentDet_1", disc);
            }

            //commit transaction
            _unitofWork.SaveChanges();
            return doctorId;
        }

        public bool Update(DoctorMasterparam DoctorMasterparam)
        {
            // throw new NotImplementedException();

            var disc1 = DoctorMasterparam.UpdateDoctorMaster.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("update_DoctorMaster_1", disc1);


            var D_Det = DoctorMasterparam.DeleteAssignDoctorToDepartment.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Delete_AssignDoctorToDepartment", D_Det);


            foreach (var a in DoctorMasterparam.AssignDoctorDepartmentDet)
            {
                var disc = a.ToDictionary();
                ExecNonQueryProcWithOutSaveChanges("Insert_M_DoctorDepartmentDet_1", disc);
            }
            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
