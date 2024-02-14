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
    public class R_PatientPastHistory : GenericRepository, I_PatientPastHistory
    {

        public R_PatientPastHistory(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }
        public string SavePatientPastHistory(PatientPastHistoryParams _patientPastHistoryParams)
        {
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@PastHistoryId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _patientPastHistoryParams.SavePatientPastHistory.ToDictionary();
            disc3.Remove("PastHistoryId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_T_PatientPastHistory", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdatePatientPastHistory(PatientPastHistoryParams _patientPastHistoryParams)
        {
            var disc3 = _patientPastHistoryParams.UpdatePatientPastHistory.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("UpdDel_T_PatientPastHistory", disc3);

            _unitofWork.SaveChanges();
            return true;
        }

        public string SavePatient2DEchoDetails(PatientPastHistoryParams _patientPastHistoryParams)
        {
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@Patient2DEchoId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _patientPastHistoryParams.SavePatient2DEchoDetails.ToDictionary();
            disc3.Remove("Patient2DEchoId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_T_Patient2DEchoDetails", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }
    }
}
