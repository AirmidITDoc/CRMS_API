using HIMS.Common.Utility;
using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public class R_VisitMaster:GenericRepository,I_VisitMaster
    {
        public R_VisitMaster(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public String Save(VisitMasterParam VisitMasterParam)
        {
            // throw new NotImplementedException();

            var outputId1 = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@VisitId",
                Value = 0,
                Direction = ParameterDirection.Output
            };


                 var dic1 = VisitMasterParam.VisitMasterAdd.ToDictionary();
            dic1.Remove("VisitId");
            var VisitID = ExecNonQueryProcWithOutSaveChanges("Insert_SingleVisitDetails", dic1, outputId1);

            _unitofWork.SaveChanges();

            return (VisitID);
        }

        public bool Update(VisitMasterParam VisitMasterParam)
        {
            // throw new NotImplementedException();


            var dic1 = VisitMasterParam.VisitMasterUpdate.ToDictionary();
             var VisitID = ExecNonQueryProcWithOutSaveChanges("Update_SingleVisitDetails", dic1);

            _unitofWork.SaveChanges();

            return (true);

        }
    }
}
