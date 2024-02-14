using System;
using System.Collections.Generic;
using System.Text;
using HIMS.Model.Cardiology;
using HIMS.Data.Cardiology;
using System.Data.SqlClient;
using System.Data;
using HIMS.Common.Utility;

namespace HIMS.Data.Cardiology
{
    public class R_ScsPatientDetails : GenericRepository, I_ScsPatientDetails
    {
        public R_ScsPatientDetails(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string SaveScsPatientDetails(ScsPatientDetailsParams _scsPatientDetailsParams)
        {
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@ScsPatientId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _scsPatientDetailsParams.SaveScsPatientDetails.ToDictionary();
            disc3.Remove("ScsPatientId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_T_ScsPatientDetails", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateScsPatientDetails(ScsPatientDetailsParams _scsPatientDetailsParams)
        {
            var disc3 = _scsPatientDetailsParams.UpdateScsPatientDetails.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("UpdDel_T_ScsPatientDetails", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
