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
    public class R_LesionDetails : GenericRepository, I_LesionDetails
    {
        public R_LesionDetails(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string SaveLesionDetails(LesionDetailsParams _lesionDetailsParams)
        {
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@LesionId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _lesionDetailsParams.SaveLesionDetails.ToDictionary();
            disc3.Remove("LesionId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_T_LesionDetails", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateLesionDetails(LesionDetailsParams _lesionDetailsParams)
        {
            var disc3 = _lesionDetailsParams.UpdateLesionDetails.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("UpdDel_T_LesionDetails", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
