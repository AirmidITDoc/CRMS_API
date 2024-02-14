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
    public class R_ProcedureDetails : GenericRepository, I_ProcedureDetails
    {
        public R_ProcedureDetails(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string SaveProcedureDetails(ProcedureDetailsParams _procedureDetailsParams)
        {
            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@ProcedureId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc3 = _procedureDetailsParams.SaveProcedureDetails.ToDictionary();
            disc3.Remove("ProcedureId");
            var No = ExecNonQueryProcWithOutSaveChanges("insert_T_ProcedureDetails", disc3, outputId1);

            _unitofWork.SaveChanges();
            return No;
        }

        public bool UpdateProcedureDetails(ProcedureDetailsParams _procedureDetailsParams)
        {
            var disc3 = _procedureDetailsParams.UpdateProcedureDetails.ToDictionary();
            var No = ExecNonQueryProcWithOutSaveChanges("UpdDel_T_ProcedureDetails", disc3);

            _unitofWork.SaveChanges();
            return true;
        }
    }
}
