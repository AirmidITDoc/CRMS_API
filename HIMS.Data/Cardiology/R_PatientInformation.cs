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
    public class R_PatientInformation : GenericRepository, I_PatientInformation
    {

        public R_PatientInformation(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string SavePatientInformation(PatientInformationParams _patientInformationParams)
        {
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@PatientId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _patientInformationParams.SavePatientInformation.ToDictionary();
            disc3.Remove("PatientId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_T_PatientDetails", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdatePatientInformation(PatientInformationParams _patientInformationParams)
        {
            var disc3 = _patientInformationParams.UpdatePatientInformation.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("UpdDel_T_PatientDetails", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
