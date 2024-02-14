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
    public class R_AcsPatientDetails : GenericRepository, I_AcsPatientDetails
    {
        public R_AcsPatientDetails(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string SaveAcsPatientDetails(AcsPatientDetailsParams _acsPatientDetailsParams)
        {
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@AcsPatientId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _acsPatientDetailsParams.SaveAcsPatientDetails.ToDictionary();
            disc3.Remove("AcsPatientId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_T_AcsPatientDetails", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateAcsPatientDetails(AcsPatientDetailsParams _acsPatientDetailsParams)
        {
            var disc3 = _acsPatientDetailsParams.UpdateAcsPatientDetails.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("UpdDel_T_AcsPatientDetails", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
