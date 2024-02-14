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
    public class R_IdcadPatientDetails : GenericRepository, I_IdcadPatientDetails
    {
        public R_IdcadPatientDetails(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string SaveIdcadPatientDetails(IdcadPatientDetailsParams _idcadPatientDetailsParams)
        {
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@IdcadPatientId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _idcadPatientDetailsParams.SaveIdcadPatientDetails.ToDictionary();
            disc3.Remove("IdcadPatientId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_T_IdcadPatientDetails", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateIdcadPatientDetails(IdcadPatientDetailsParams _idcadPatientDetailsParams)
        {
            var disc3 = _idcadPatientDetailsParams.UpdateIdcadPatientDetails.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("UpdDel_T_IdcadPatientDetails", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
